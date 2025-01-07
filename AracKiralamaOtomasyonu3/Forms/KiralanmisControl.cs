using AracKiralamaOtomasyonu3.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3.Forms
{
    public class KiralanmisControl : XtraUserControl
    {
        private GridControl gridControl;
        private GridView gridView;
        private LabelControl lblBaslik;  // Başlık için LabelControl ekleyelim

        private readonly int _kiralayanId;

        public KiralanmisControl(int kiralayanId)
        {
            _kiralayanId = kiralayanId;
            InitializeUI();
            LoadRentedCars();
        }

        private void InitializeUI()
        {
            this.Dock = DockStyle.Fill;

            // Başlık için LabelControl oluşturuluyor
            lblBaslik = new LabelControl
            {
                Appearance = { Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = Color.White },
                Padding = new Padding(10, 20, 10, 10),
                Text = "KİRALANMIŞ ARAÇLAR",
                Location = new Point(0, 3),  // Başlık konumu
                Size = new Size(160, 67)   // Başlık boyutu
            };

            // TextAlignment için doğru kullanımı yapıyoruz
            lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBaslik.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            this.Controls.Add(lblBaslik);  // Başlık kontrolünü forma ekliyoruz

            // GridControl
            gridControl = new GridControl
            {
                Dock = DockStyle.None,
                Location = new Point(0, 80),  // Başlık ile grid arasında boşluk bırakıyoruz
                Size = new Size(830, 700)
            };

            // GridView
            gridView = new GridView
            {
                GridControl = gridControl
            };

            // Tasarımı uygula
            InitializeGridView();

            gridControl.MainView = gridView;
            gridControl.ViewCollection.Add(gridView);

            this.Controls.Add(gridControl);  // GridControl'ü forma ekliyoruz
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
        }

        private void LoadRentedCars()
        {
            using (var context = new AracKiralamaContext())
            {
                var rentedCars = context.Araclar
                    .Where(a => a.KiralandiMi == true) // Kiralanmış araçları getir
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
                gridControl.DataSource = rentedCars;

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
    }
}
