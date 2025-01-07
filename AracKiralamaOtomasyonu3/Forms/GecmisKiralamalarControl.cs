using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;
using AracKiralamaOtomasyonu3.DAL;

namespace AracKiralamaOtomasyonu3
{
    public partial class GecmisKiralamalarControl : XtraUserControl
    {
        private int _musteriId;
        private GridControl gridControl;
        private GridView gridView;
        private LabelControl lblBaslik;

        public GecmisKiralamalarControl(int musteriId)
        {
            _musteriId = musteriId;

            InitializeLayout();
            LoadKiralamaGecmisi();
        }

        private void InitializeLayout()
        {
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();


            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.lblBaslik.Size = new System.Drawing.Size(145, 67);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "GEÇMİŞ KİRALAMALAR";
            this.Controls.Add(this.lblBaslik);

            // Genel görünüm ayarları
            this.BackColor = Color.FromArgb(30, 30, 45);

            // GridControl oluşturma ve ayarları
            // GridControl oluşturma ve ayarları
            gridControl = new GridControl
            {
                Dock = DockStyle.None,  // Dock özelliğini None yapıyoruz çünkü konumu manuel ayarlayacağız
                Parent = this,
                Location = new Point(0, 80) , // GridControl'ün konumunu (0, 80) olarak ayarlıyoruz
                 Size = new Size(1050, 700)
            };

            gridView = new GridView
            {
                GridControl = gridControl
            };
            gridControl.MainView = gridView;

            // Grid tasarımı
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.OptionsView.EnableAppearanceOddRow = true;

            gridView.Appearance.EvenRow.BackColor = Color.FromArgb(50, 50, 50); // Gri ton
            gridView.Appearance.OddRow.BackColor = Color.FromArgb(40, 40, 40); // Daha koyu gri
            gridView.Appearance.Empty.BackColor = Color.FromArgb(30, 30, 45); // Boş alan rengi
            gridView.Appearance.Row.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridView.Appearance.Row.ForeColor = Color.White;

            gridView.Appearance.HeaderPanel.BackColor = Color.FromArgb(28, 28, 28);
            gridView.Appearance.HeaderPanel.ForeColor = Color.FromArgb(75, 0, 130); // Koyu mor
            gridView.Appearance.HeaderPanel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView.Appearance.FocusedRow.BackColor = Color.FromArgb(104, 104, 204);
            gridView.Appearance.FocusedRow.ForeColor = Color.White;

            gridView.Appearance.SelectedRow.BackColor = Color.FromArgb(80, 80, 160);
            gridView.Appearance.SelectedRow.ForeColor = Color.White;

            gridView.Appearance.RowSeparator.BackColor = Color.Black;
            gridView.Appearance.VertLine.BackColor = Color.Gray;
            gridView.Appearance.HorzLine.BackColor = Color.Gray;

            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowFooter = false;
            gridView.OptionsCustomization.AllowFilter = true;
            gridView.OptionsCustomization.AllowSort = true;

            this.Controls.Add(gridControl);

        }

        private void LoadKiralamaGecmisi()
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralamaGecmisi = context.Kiralamalar
                    .Where(k => k.KullaniciId == _musteriId)
                    .Include(k => k.Arac)
                    .ToList()
                    .Select(k => new
                    {
                        Marka = k.Arac.Marka,
                        Model = k.Arac.Model,
                        Yıl = k.Arac.Yil,
                        Renk = k.Arac.Renk,
                        YakıtTürü = k.Arac.YakitCinsi,
                        BakımTarihi = k.Arac.BakimTarihi.HasValue
                            ? k.Arac.BakimTarihi.Value.ToString("dd/MM/yyyy")
                            : "Bilinmiyor",
                        Fiyat = k.Arac.Fiyat,
                        Plaka = k.Arac.Plaka,
                        KiralamaTarihi = k.KiralamaTarihi.ToString("dd/MM/yyyy"),
                        TeslimTarihi = k.TeslimTarihi.HasValue
                            ? k.TeslimTarihi.Value.ToString("dd/MM/yyyy")
                            : "Henüz Teslim Edilmedi"
                    }).ToList();

                gridControl.DataSource = kiralamaGecmisi;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GecmisKiralamalarControl
            // 
            this.Name = "GecmisKiralamalarControl";
            this.Size = new System.Drawing.Size(1069, 681);
            this.ResumeLayout(false);

        }
    }
}