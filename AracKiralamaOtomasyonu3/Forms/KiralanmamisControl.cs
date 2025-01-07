using AracKiralamaOtomasyonu3.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3.Forms
{
    public class KiralanmamisControl : XtraUserControl
    {
        private GridControl gridControl;
        private GridView gridView;
        private readonly int _kiralayanId;
        private LabelControl lblBaslik;  // Add the label here

        public KiralanmamisControl(int kiralayanId)
        {
            _kiralayanId = kiralayanId;
            InitializeUI();
            LoadAvailableCars();
        }

        private void InitializeUI()
        {
            this.Dock = DockStyle.Fill;

            // Create the label
            lblBaslik = new LabelControl
            {
                Text = "KİRALANMAMIŞ ARAÇLAR",
                Height = 67,
                Padding = new Padding(10, 20, 10, 10),
                Appearance =
                {
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center, VAlignment = DevExpress.Utils.VertAlignment.Center }
                }
            };

            this.Controls.Add(lblBaslik);  // Add label to the controls

            // GridControl
            gridControl = new GridControl
            {
                Dock = DockStyle.None,
                Location = new Point(0, 80), 
                Size = new Size(830, 700)
            };

            // GridView
            gridView = new GridView
            {
                GridControl = gridControl
            };

            // InitializeGridView tasarımı uygula
            InitializeGridView();

            gridControl.MainView = gridView;
            gridControl.ViewCollection.Add(gridView);
            AddContextMenu();

            this.Controls.Add(gridControl);
        }

        private void AddContextMenu()
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem deleteItem = new MenuItem("Sil");
            deleteItem.Click += DeleteItem_Click;

            contextMenu.MenuItems.Add(deleteItem);

            gridControl.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(gridControl, new Point(e.X, e.Y));
                }
            };
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            // GridView'den seçili satırın verilerini al
            var focusedRowHandle = gridView.FocusedRowHandle;

            if (focusedRowHandle >= 0) // Satır seçili mi kontrol et
            {
                // Seçili satırın verilerini al
                var marka = gridView.GetRowCellValue(focusedRowHandle, "Marka")?.ToString();
                var model = gridView.GetRowCellValue(focusedRowHandle, "Model")?.ToString();

                if (marka != null && model != null)
                {
                    // Kullanıcıdan onay al
                    DialogResult result = MessageBox.Show(
                        $"Seçili aracı silmek istediğinize emin misiniz?\nMarka: {marka}\nModel: {model}",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DeleteCarFromDatabase(marka, model);
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek aracın bilgileri alınamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir aracı seçin.");
            }
        }

        private void DeleteCarFromDatabase(string marka, string model)
        {
            using (var context = new AracKiralamaContext())
            {
                var carToDelete = context.Araclar.FirstOrDefault(a => a.Marka == marka && a.Model == model);
                if (carToDelete != null)
                {
                    context.Araclar.Remove(carToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla silindi.");
                    LoadAvailableCars(); // Listeyi güncelle
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı veya zaten silinmiş.");
                }
            }
        }

        private void InitializeGridView()
        {
            // GridView özellikleri
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.OptionsView.EnableAppearanceOddRow = true;
            

            // Çift ve tek satır arka plan renkleri
            gridView.Appearance.EvenRow.BackColor = Color.FromArgb(50, 50, 50);
            gridView.Appearance.OddRow.BackColor = Color.FromArgb(40, 40, 40);

            // Grid boş alan arka plan rengi (Mor)
            gridView.Appearance.Empty.BackColor = Color.FromArgb(30, 30, 45);

            // Grid genel satır tasarımı
            gridView.Appearance.Row.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridView.Appearance.Row.ForeColor = Color.White;

            // Grid başlık (header) tasarımı
            gridView.Appearance.HeaderPanel.BackColor = Color.FromArgb(28, 28, 28);
            gridView.Appearance.HeaderPanel.ForeColor = Color.FromArgb(75, 0, 130);
            gridView.Appearance.HeaderPanel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Hücre odaklama tasarımı
            gridView.Appearance.FocusedRow.BackColor = Color.FromArgb(104, 104, 204);
            gridView.Appearance.FocusedRow.ForeColor = Color.White;

            // Seçili satır tasarımı
            gridView.Appearance.SelectedRow.BackColor = Color.FromArgb(80, 80, 160);
            gridView.Appearance.SelectedRow.ForeColor = Color.White;

            // Grid çerçeve ve kenarlık rengi
            gridView.Appearance.RowSeparator.BackColor = Color.Black;
            gridView.Appearance.VertLine.BackColor = Color.Gray;
            gridView.Appearance.HorzLine.BackColor = Color.Gray;

            // Grup paneli ayarları
            gridView.OptionsView.ShowGroupPanel = false;

            // Çerçeve ve kenarlık ayarları
            gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;

            // Hücre düzenleme ve görünüm ayarları
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowFooter = false;
            gridView.OptionsCustomization.AllowFilter = true;
            gridView.OptionsCustomization.AllowSort = true;

            // Çift tıklama olay bağlama
            gridView.DoubleClick += gridView_DoubleClick;
        }

        private void LoadAvailableCars()
        {
            using (var context = new AracKiralamaContext())
            {
                var availableCars = context.Araclar
                    .Where(a => a.KiralandiMi == false) // Kiralanmamış araçları getir
                    .Select(a => new
                    {
                        Marka = a.Marka,
                        Model = a.Model,
                        Yıl = a.Yil,
                        Renk = a.Renk,
                        YakıtTürü = a.YakitCinsi,
                        BakımTarihi = a.BakimTarihi,
                        Fiyat = a.Fiyat
                    })
                    .ToList();

                // Veriyi GridControl'e bağla
                gridControl.DataSource = availableCars;
                // Kolon başlıklarını özelleştir
                gridView.Columns["Marka"].Caption = "Araç Markası";
                gridView.Columns["Model"].Caption = "Araç Modeli";
                gridView.Columns["Yıl"].Caption = "Üretim Yılı";
                gridView.Columns["Renk"].Caption = "Renk";
                gridView.Columns["YakıtTürü"].Caption = "Yakıt Türü";
                gridView.Columns["BakımTarihi"].Caption = "Bakım Tarihi";
                gridView.Columns["Fiyat"].Caption = "Günlük Fiyat (₺)";
                gridView.BestFitColumns(); // Kolonları otomatik boyutlandır
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            // Çift tıklama olayını işleyin
            MessageBox.Show("Satır çift tıklama olayı tetiklendi.");
        }
    }
}
