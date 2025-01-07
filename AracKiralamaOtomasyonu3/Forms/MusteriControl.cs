using AracKiralamaOtomasyonu3.DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class MusteriControl : UserControl
    {
        private GridControl gridControlCustomers;
        private GridView gridViewCustomers;
        private LabelControl lblBaslik;  // Başlık LabelControl

        public MusteriControl()
        {
            InitializeComponent();
            LoadCustomers();
            InitializeGridView();
            InitializeLabel();  // Başlık LabelControl'ü başlatıyoruz
        }

        private void LoadCustomers()
        {
            using (var context = new AracKiralamaContext())
            {
                var customers = context.Kullanicilar
                    .Join(
                        context.Kiralamalar,
                        kullanici => kullanici.KullaniciId,
                        kiralama => kiralama.KullaniciId,
                        (kullanici, kiralama) => new
                        {
                            kullanici.Ad,
                            kullanici.Soyad,
                            kullanici.Email,
                            kiralama.AracId,
                            kiralama.KiralamaTarihi,
                            kiralama.TeslimTarihi
                        }
                    )
                    .Join(
                        context.Araclar,
                        kiralama => kiralama.AracId,
                        arac => arac.AracId,
                        (kiralama, arac) => new
                        {
                            kiralama.Ad,
                            kiralama.Soyad,
                            kiralama.Email,
                            AracAdi = arac.Marka + " " + arac.Model,
                            kiralama.KiralamaTarihi,
                            kiralama.TeslimTarihi
                        }
                    )
                    .ToList()
                    .Select(result => new
                    {
                        result.Ad,
                        result.Soyad,
                        result.Email,
                        result.AracAdi,
                        Tarihler = $"{result.KiralamaTarihi:dd/MM/yyyy} - {result.TeslimTarihi:dd/MM/yyyy}"
                    })
                    .ToList();

                // Veri kaynağını bağlama
                gridControlCustomers.DataSource = customers;
            }
        }

        private void InitializeGridView()
        {
            if (gridControlCustomers == null || gridViewCustomers == null)
            {
                MessageBox.Show("GridControl veya GridView tanımlı değil!");
                return;
            }

            // GridControl boyutları
            gridControlCustomers.Dock = DockStyle.Fill;

            // GridView ayarları
            gridViewCustomers.OptionsView.EnableAppearanceEvenRow = true;
            gridViewCustomers.OptionsView.EnableAppearanceOddRow = true;

            // Çift ve tek satır arka plan renkleri
            gridViewCustomers.Appearance.EvenRow.BackColor = Color.FromArgb(50, 50, 50);
            gridViewCustomers.Appearance.OddRow.BackColor = Color.FromArgb(40, 40, 40);
            gridViewCustomers.Appearance.Empty.BackColor = Color.FromArgb(30, 30, 45);
            gridViewCustomers.Appearance.Row.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridViewCustomers.Appearance.Row.ForeColor = Color.White;

            // Grid başlık (header) tasarımı
            gridViewCustomers.Appearance.HeaderPanel.BackColor = Color.White;
            gridViewCustomers.Appearance.HeaderPanel.ForeColor = Color.FromArgb(75, 0, 130);
            gridViewCustomers.Appearance.HeaderPanel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridViewCustomers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Hücre tasarımı
            gridViewCustomers.Appearance.FocusedRow.BackColor = Color.FromArgb(104, 104, 204);
            gridViewCustomers.Appearance.FocusedRow.ForeColor = Color.White;

            gridViewCustomers.Appearance.SelectedRow.BackColor = Color.FromArgb(80, 80, 160);
            gridViewCustomers.Appearance.SelectedRow.ForeColor = Color.White;

            // Grid çerçeve ve kenarlık rengi
            gridViewCustomers.Appearance.RowSeparator.BackColor = Color.Black;
            gridViewCustomers.Appearance.VertLine.BackColor = Color.Gray;
            gridViewCustomers.Appearance.HorzLine.BackColor = Color.Gray;

            // Grup paneli ayarları
            gridViewCustomers.OptionsView.ShowGroupPanel = false;

            // Çerçeve ve kenarlık ayarları
            gridViewCustomers.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            gridViewCustomers.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;

            // Hücre düzenleme ve görünüm ayarları
            gridViewCustomers.OptionsBehavior.Editable = false;
            gridViewCustomers.OptionsView.ShowFooter = false;
            gridViewCustomers.OptionsCustomization.AllowFilter = true;
            gridViewCustomers.OptionsCustomization.AllowSort = true;

            // Olay bağlama
            gridViewCustomers.FocusedRowChanged += GridViewCustomers_FocusedRowChanged;
        }

        private void GridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowIndex = e.FocusedRowHandle;
            if (rowIndex >= 0)
            {
                var selectedCustomer = gridViewCustomers.GetRow(rowIndex);
                // Seçilen müşteri ile ilgili işlemler yapılabilir
            }
        }

        private void InitializeLabel()
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
            this.lblBaslik.Text = "MÜŞTERİLER";
            this.Controls.Add(this.lblBaslik);
        }

        private void InitializeComponent()
        {
            this.gridControlCustomers = new GridControl();
            this.gridViewCustomers = new GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            this.SuspendLayout();

            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.Dock = DockStyle.Fill;
            this.gridControlCustomers.Location = new System.Drawing.Point(0, 67); 
            this.gridControlCustomers.MainView = this.gridViewCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.Size = new System.Drawing.Size(800, 450);  
            this.gridControlCustomers.TabIndex = 0;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});

            // 
            // MusteriControl
            // 
            this.Controls.Add(this.gridControlCustomers);
            this.Name = "MusteriControl";
            this.Size = new System.Drawing.Size(800, 517);  
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
