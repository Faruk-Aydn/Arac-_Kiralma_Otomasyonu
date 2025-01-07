using AracKiralamaOtomasyonu3.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class FaturalarControl : XtraUserControl
    {
        private int _musteriId;
        private LabelControl lblBaslik;  

        public FaturalarControl(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
            InitializeGridView();
            InitializeHeaderLabel();  
        }

        private void FaturalarControl_Load(object sender, EventArgs e)
        {
            ListeFaturalari();
        }

        private void ListeFaturalari()
        {
            using (var context = new AracKiralamaContext())
            {
                var faturalar = context.Faturalar
                    .Include(f => f.Kiralama.Arac)
                    .Where(f => f.Kiralama.KullaniciId == _musteriId)
                    .Select(f => new
                    {
                        FaturaId = f.FaturaId, 
                        Araç_Modeli = f.Kiralama.Arac.Model,
                        Marka = f.Kiralama.Arac.Marka,
                        Model = f.Kiralama.Arac.Model,
                        Yıl = f.Kiralama.Arac.Yil,
                        Renk = f.Kiralama.Arac.Renk,
                        YakıtTürü = f.Kiralama.Arac.YakitCinsi,
                        BakımTarihi = f.Kiralama.Arac.BakimTarihi,
                        Fiyat = f.Kiralama.Arac.Fiyat,
                        Plaka = f.Kiralama.Arac.Plaka,
                        Fatura_Tarihi = f.FaturaTarihi,
                        Tutar = f.Tutar
                    }).ToList();

                gridControl.DataSource = faturalar;

          
                gridView.Columns["FaturaId"].Visible = false; 
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = gridControl.MainView as GridView;
            if (view != null)
            {
                var selectedRowHandle = view.FocusedRowHandle;
                if (selectedRowHandle >= 0)
                {
                    int faturaId = Convert.ToInt32(view.GetRowCellValue(selectedRowHandle, "FaturaId"));
                    FaturaDetayGoster(faturaId);
                }
            }
        }

        private void FaturaDetayGoster(int faturaId)
        {
            using (var context = new AracKiralamaContext())
            {
                var fatura = context.Faturalar
                    .Include(f => f.Kiralama.Arac)
                    .Include(f => f.Kiralama.Kullanici)
                    .FirstOrDefault(f => f.FaturaId == faturaId);

                if (fatura != null)
                {
                    XtraMessageBox.Show($"Fatura Detayları:\n\n" +
                                        $"Müşteri: {fatura.Kiralama.Kullanici.Ad} {fatura.Kiralama.Kullanici.Soyad}\n" +
                                        $"Araç Model: {fatura.Kiralama.Arac.Model}\n" +
                                        $"Plaka: {fatura.Kiralama.Arac.Plaka}\n" +
                                        $"Fatura Tarihi: {fatura.FaturaTarihi:dd/MM/yyyy}\n" +
                                        $"Tutar: {fatura.Tutar:C}",
                                        "Fatura Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void InitializeHeaderLabel()
        {
            this.lblBaslik = new LabelControl();
            this.lblBaslik.Appearance.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = Color.White;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBaslik.Dock = DockStyle.Top;
            this.lblBaslik.Location = new Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new Padding(10, 20, 10, 10);
            this.lblBaslik.Size = new Size(800, 67); 
            this.lblBaslik.Text = "FATURALAR";
            this.Controls.Add(this.lblBaslik);  
        }

        private void InitializeComponent()
        {
            this.gridControl = new GridControl();
            this.gridView = new GridView();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = DockStyle.Fill;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new Size(800, 450);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // FaturalarControl
            // 
            this.Controls.Add(this.gridControl);
            this.Name = "FaturalarControl";
            this.Size = new Size(800, 517); 
            this.Load += FaturalarControl_Load;
            this.ResumeLayout(false);
        }

        private GridControl gridControl;
        private GridView gridView;
    }
}
