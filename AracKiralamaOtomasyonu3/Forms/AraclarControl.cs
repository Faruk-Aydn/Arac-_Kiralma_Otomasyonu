using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using AracKiralamaOtomasyonu3.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class AraclarControl : XtraUserControl
    {
        private int _musteriId;
        public AraclarControl(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
            InitializeGridView();


            LoadAracListesi();
            ApplyDarkTheme();
        }

        private void InitializeComponent()
        {
            this.gridControlAraclar = new DevExpress.XtraGrid.GridControl();
            this.gridViewAraclar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtModelFiltre = new DevExpress.XtraEditors.TextEdit();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.lblToplamFiyat = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanelFotolar = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter = new DevExpress.XtraEditors.SplitterControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.btnAracKirala = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditGunSayisi = new DevExpress.XtraEditors.SpinEdit();
            this.lblGunSecimBilgisi = new DevExpress.XtraEditors.LabelControl();
            this.btnRezervasyonYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelFiltre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGunSayisi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlAraclar
            // 
            this.gridControlAraclar.Location = new System.Drawing.Point(19, 134);
            this.gridControlAraclar.MainView = this.gridViewAraclar;
            this.gridControlAraclar.Name = "gridControlAraclar";
            this.gridControlAraclar.Size = new System.Drawing.Size(711, 535);
            this.gridControlAraclar.TabIndex = 2;
            this.gridControlAraclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAraclar});
            // 
            // gridViewAraclar
            // 
            this.gridViewAraclar.GridControl = this.gridControlAraclar;
            this.gridViewAraclar.Name = "gridViewAraclar";
            this.gridViewAraclar.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewAraclar.OptionsView.EnableAppearanceOddRow = true;
            // 
            // txtModelFiltre
            // 
            this.txtModelFiltre.Location = new System.Drawing.Point(19, 73);
            this.txtModelFiltre.Name = "txtModelFiltre";
            this.txtModelFiltre.Properties.NullValuePrompt = "Kiralamak istediğiniz Model...";
            this.txtModelFiltre.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtModelFiltre.Size = new System.Drawing.Size(555, 22);
            this.txtModelFiltre.TabIndex = 5;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnFiltrele.Location = new System.Drawing.Point(19, 95);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(555, 33);
            this.btnFiltrele.TabIndex = 4;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamFiyat.Appearance.Options.UseFont = true;
            this.lblToplamFiyat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblToplamFiyat.Location = new System.Drawing.Point(0, 67);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(0, 19);
            this.lblToplamFiyat.TabIndex = 3;
            // 
            // flowLayoutPanelFotolar
            // 
            this.flowLayoutPanelFotolar.AutoScroll = true;
            this.flowLayoutPanelFotolar.Location = new System.Drawing.Point(736, 134);
            this.flowLayoutPanelFotolar.Name = "flowLayoutPanelFotolar";
            this.flowLayoutPanelFotolar.Size = new System.Drawing.Size(557, 292);
            this.flowLayoutPanelFotolar.TabIndex = 0;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(0, 86);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(6, 601);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
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
            this.lblBaslik.Text = "ARAÇLAR";
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnAracKirala.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.btnAracKirala.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btnAracKirala.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAracKirala.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAracKirala.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAracKirala.Appearance.Options.UseBackColor = true;
            this.btnAracKirala.Appearance.Options.UseBorderColor = true;
            this.btnAracKirala.Appearance.Options.UseFont = true;
            this.btnAracKirala.Appearance.Options.UseForeColor = true;
            this.btnAracKirala.Location = new System.Drawing.Point(745, 432);
            this.btnAracKirala.LookAndFeel.SkinName = "";
            this.btnAracKirala.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAracKirala.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(200, 50);
            this.btnAracKirala.TabIndex = 7;
            this.btnAracKirala.Text = "Araç Kirala";
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // spinEditGunSayisi
            // 
            this.spinEditGunSayisi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditGunSayisi.Location = new System.Drawing.Point(745, 528);
            this.spinEditGunSayisi.Name = "spinEditGunSayisi";
            this.spinEditGunSayisi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.spinEditGunSayisi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.spinEditGunSayisi.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.spinEditGunSayisi.Properties.Appearance.Options.UseBackColor = true;
            this.spinEditGunSayisi.Properties.Appearance.Options.UseFont = true;
            this.spinEditGunSayisi.Properties.Appearance.Options.UseForeColor = true;
            this.spinEditGunSayisi.Properties.IsFloatValue = false;
            this.spinEditGunSayisi.Properties.Mask.EditMask = "N00";
            this.spinEditGunSayisi.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEditGunSayisi.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditGunSayisi.Size = new System.Drawing.Size(200, 30);
            this.spinEditGunSayisi.TabIndex = 8;
            // 
            // lblGunSecimBilgisi
            // 
            this.lblGunSecimBilgisi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGunSecimBilgisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGunSecimBilgisi.Appearance.Options.UseFont = true;
            this.lblGunSecimBilgisi.Appearance.Options.UseForeColor = true;
            this.lblGunSecimBilgisi.Location = new System.Drawing.Point(745, 488);
            this.lblGunSecimBilgisi.Name = "lblGunSecimBilgisi";
            this.lblGunSecimBilgisi.Size = new System.Drawing.Size(333, 23);
            this.lblGunSecimBilgisi.TabIndex = 9;
            this.lblGunSecimBilgisi.Text = "Seçtiğiniz aracı kaç gün kiralamak istersiniz?";
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btnRezervasyonYap.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.btnRezervasyonYap.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(160)))));
            this.btnRezervasyonYap.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonYap.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRezervasyonYap.Appearance.Options.UseBackColor = true;
            this.btnRezervasyonYap.Appearance.Options.UseBorderColor = true;
            this.btnRezervasyonYap.Appearance.Options.UseFont = true;
            this.btnRezervasyonYap.Appearance.Options.UseForeColor = true;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(745, 584);
            this.btnRezervasyonYap.LookAndFeel.SkinName = "";
            this.btnRezervasyonYap.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnRezervasyonYap.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(200, 50);
            this.btnRezervasyonYap.TabIndex = 6;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // AraclarControl
            // 
            this.Controls.Add(this.flowLayoutPanelFotolar);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.gridControlAraclar);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.txtModelFiltre);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.spinEditGunSayisi);
            this.Controls.Add(this.lblGunSecimBilgisi);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Name = "AraclarControl";
            this.Size = new System.Drawing.Size(1293, 687);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelFiltre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGunSayisi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeGridView()
        {
            // GridView'ın bağlı olduğu GridControl'ü kontrol edin
            if (gridViewAraclar == null || gridControlAraclar == null)
            {
                MessageBox.Show("GridView veya GridControl tanımlı değil!");
                return;
            }

            // Satırların görünüm renkleri
            gridViewAraclar.OptionsView.EnableAppearanceEvenRow = true;
            gridViewAraclar.OptionsView.EnableAppearanceOddRow = true;

            // Çift ve tek satır arka plan renkleri
            gridViewAraclar.Appearance.EvenRow.BackColor = Color.FromArgb(50, 50, 50); 
            gridViewAraclar.Appearance.OddRow.BackColor = Color.FromArgb(40, 40, 40); 
            gridViewAraclar.Appearance.Empty.BackColor = Color.FromArgb(30, 30, 45); 
            gridViewAraclar.Appearance.Row.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            gridViewAraclar.Appearance.Row.ForeColor = Color.White;

            // Grid başlık (header) tasarımı
            gridViewAraclar.Appearance.HeaderPanel.BackColor = Color.FromArgb(28, 28, 28);
            gridViewAraclar.Appearance.HeaderPanel.ForeColor = Color.FromArgb(75, 0, 130); 
            gridViewAraclar.Appearance.HeaderPanel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridViewAraclar.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Hücre tasarımı
            gridViewAraclar.Appearance.FocusedRow.BackColor = Color.FromArgb(104, 104, 204);
            gridViewAraclar.Appearance.FocusedRow.ForeColor = Color.White;

            gridViewAraclar.Appearance.SelectedRow.BackColor = Color.FromArgb(80, 80, 160);
            gridViewAraclar.Appearance.SelectedRow.ForeColor = Color.White;

            // Grid çerçeve ve kenarlık rengi
            gridViewAraclar.Appearance.RowSeparator.BackColor = Color.Black;
            gridViewAraclar.Appearance.VertLine.BackColor = Color.Gray;
            gridViewAraclar.Appearance.HorzLine.BackColor = Color.Gray;

            // Grup paneli ayarları
            gridViewAraclar.OptionsView.ShowGroupPanel = false;

            // Çerçeve ve kenarlık ayarları
            gridViewAraclar.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            gridViewAraclar.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;

            // Hücre düzenleme ve görünüm ayarları
            gridViewAraclar.OptionsBehavior.Editable = false;
            gridViewAraclar.OptionsView.ShowFooter = false;
            gridViewAraclar.OptionsCustomization.AllowFilter = true;
            gridViewAraclar.OptionsCustomization.AllowSort = true;

            // Olay bağlama
            gridViewAraclar.FocusedRowChanged += GridViewAraclar_FocusedRowChanged;
            LoadAracListesi();

            // Veri kaynağı kontrolü
            if (gridControlAraclar.DataSource == null)
            {
                MessageBox.Show("GridControl veri kaynağı bağlı değil!");
            }
        }





        private GridControl gridControlAraclar;
        private GridView gridViewAraclar;
        private TextEdit txtModelFiltre;
        private SimpleButton btnFiltrele;
        private LabelControl lblToplamFiyat;
        private FlowLayoutPanel flowLayoutPanelFotolar;
        private SplitterControl splitter;
        private LabelControl lblBaslik;
        private SimpleButton btnAracKirala;
        private DevExpress.XtraEditors.SpinEdit spinEditGunSayisi;
        private LabelControl lblGunSecimBilgisi;
        private SimpleButton btnRezervasyonYap;
        private void ApplyDarkTheme()
        {
            // Genel Form arka planı
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.Appearance.Options.UseBackColor = true;

          

            // TextEdit tasarımı
            txtModelFiltre.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(50, 50, 65); 
            txtModelFiltre.Properties.Appearance.ForeColor = System.Drawing.Color.White; 
            txtModelFiltre.Properties.Appearance.Font = new Font("Segoe UI", 10);

            // Buton tasarımı
            btnFiltrele.Appearance.BackColor = System.Drawing.Color.FromArgb(72, 72, 160);
            btnFiltrele.Appearance.ForeColor = System.Drawing.Color.White;
            btnFiltrele.Appearance.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnFiltrele.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            // Toplam Fiyat Etiketi tasarımı
            lblToplamFiyat.Appearance.ForeColor = System.Drawing.Color.White;
            lblToplamFiyat.Appearance.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }



        private void LoadAracListesi(DateTime? baslangicTarihi = null, DateTime? teslimTarihi = null)
        {
            using (var context = new AracKiralamaContext())
            {
                var araclar = context.Araclar
                    .Where(a => !a.KiralandiMi &&
                            !context.Rezervasyonlar.Any(r => r.AracId == a.AracId &&
                                // Eğer rezervasyon tarihi belirtilen tarihlerle çakışıyorsa, araç görünmesin.
                                ((r.BaslangicTarihi <= teslimTarihi && r.TeslimTarihi >= baslangicTarihi) ||
                                 (r.BaslangicTarihi >= baslangicTarihi && r.TeslimTarihi <= teslimTarihi))))
                    .Select(a => new
                    {
                        a.AracId,
                        Marka = a.Marka,
                        Model = a.Model,
                        Yıl = a.Yil,
                        Renk = a.Renk,
                        YakıtTürü = a.YakitCinsi,
                        BakımTarihi = a.BakimTarihi,
                        Fiyat = a.Fiyat,
                        Indirim = a.IndirimResmi
                    })
                    .ToList();

                gridControlAraclar.DataSource = araclar;
                gridViewAraclar.Columns["AracId"].Visible = false;
            }
        }


        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var memoryStream = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            string model = txtModelFiltre.Text.Trim();
            using (var context = new AracKiralamaContext())
            {
                var araclar = context.Araclar
                    .Where(a => a.Model.Contains(model) && !a.KiralandiMi)
                    .Select(a => new
                    {
                        a.AracId,
                        Marka = a.Marka,
                        Model = a.Model,
                        Yıl = a.Yil,
                        Renk = a.Renk,
                        YakıtTürü = a.YakitCinsi,
                        BakımTarihi = a.BakimTarihi,
                        Fiyat = a.Fiyat,
                        Indirim = a.IndirimResmi
                    })
                    .ToList();

                gridControlAraclar.DataSource = araclar;


            }
        }



        private void GridViewAraclar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewAraclar.GetFocusedRowCellValue("AracId") is int aracId)
            {
                FotograflariGoster(aracId);
            }
        }
        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            
            int kiralamaGunu = (int)spinEditGunSayisi.Value;


            if (gridViewAraclar.GetFocusedRowCellValue("AracId") is int aracId)
            {

                OdemeForm odemeForm = new OdemeForm();
                odemeForm.ShowDialog();

                if (odemeForm.OdemeBasarili)
                {
                    using (var context = new AracKiralamaContext())
                    {
                        var kiralama = new Kiralama
                        {
                            AracId = aracId,
                            KullaniciId = _musteriId,
                            KiralamaTarihi = DateTime.Now,
                            TeslimTarihi = DateTime.Now.AddDays(kiralamaGunu)
                        };
                        context.Kiralamalar.Add(kiralama);

                        var arac = context.Araclar.Find(aracId);
                        arac.KiralandiMi = true;
                        context.SaveChanges();

                        decimal toplamTutar = arac.Fiyat * kiralamaGunu;
                        Fatura fatura = new Fatura
                        {
                            KiralamaId = kiralama.KiralamaId,
                            Tutar = toplamTutar,
                            FaturaTarihi = DateTime.Now
                        };
                        context.Faturalar.Add(fatura);
                        context.SaveChanges();

                        MessageBox.Show(
                            $"Fatura Detayları:\n\n" +
                            $"Müşteri: {context.Kullanicilar.Find(_musteriId).Ad} {context.Kullanicilar.Find(_musteriId).Soyad}\n" +
                            $"Araç: {arac.Model}\n" +
                            $"Plaka: {arac.Plaka}\n" +
                            $"Kiralama Tarihi: {kiralama.KiralamaTarihi:dd/MM/yyyy}\n" +
                            $"Teslim Tarihi: {kiralama.TeslimTarihi:dd/MM/yyyy}\n" +
                            $"Toplam Tutar: {toplamTutar:C}",
                            "Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Araç başarıyla kiralandı ve ödeme tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAracListesi();
                }
                else
                {
                    MessageBox.Show("Ödeme başarısız. Kiralama işlemi iptal edildi.", "Ödeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kiralamak istediğiniz aracı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void FotograflariGoster(int aracId)
        {
            flowLayoutPanelFotolar.Controls.Clear();

            using (var context = new AracKiralamaContext())
            {
                var fotograflar = context.AracFotograflar
                    .Where(f => f.AracId == aracId)
                    .Select(f => f.FotoData)
                    .ToList();

                foreach (var foto in fotograflar)
                {
                    var pb = new PictureEdit
                    {
                        Image = Image.FromStream(new MemoryStream(foto)),
                        Properties = { SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch },
                        Width = 100,
                        Height = 100
                    };
                    flowLayoutPanelFotolar.Controls.Add(pb);
                }
            }
        }

    

        public void ApplyDiscountAndRefreshGrid(string discountType, double discountPercentage)
        {
            using (var context = new AracKiralamaContext())
            {
          
                var discountedCars = context.Araclar.Where(a =>
                    !a.KiralandiMi &&
                    (discountType == "Dizel" && a.YakitCinsi == "Dizel" ||
                     discountType == "Benzinli" && a.YakitCinsi == "Benzinli" ||
                     discountType == "Fiyat" && a.Fiyat > 13000)
                ).ToList();

      
                foreach (var car in discountedCars)
                {
                    car.Fiyat -= car.Fiyat * (decimal)(discountPercentage / 100);
                }

          
                context.SaveChanges();

              
                LoadAracListesi();

                MessageBox.Show($"İndirim ({discountPercentage}%) başarıyla uygulandı.", "İndirim Uygulandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (gridViewAraclar.GetFocusedRowCellValue("AracId") is int aracId)
            {
                // RezervasyonForm ekranını aracId parametresi ile açma
                RezervasyonForm rezervasyonForm = new RezervasyonForm(aracId, _musteriId);
                rezervasyonForm.ShowDialog(); // ShowDialog() ile form modally açılır.

                // Eğer rezervasyon başarıyla yapılmışsa, aracın 'KiralandiMi' durumunu güncelle
                if (rezervasyonForm.RezervasyonBasarili)
                {
                    using (var context = new AracKiralamaContext())
                    {
                        var arac = context.Araclar.Find(aracId);
                        if (arac != null)
                        {
                            arac.KiralandiMi = true;  // Araç kiralanmış olarak işaretlenir.
                            context.SaveChanges();
                        }
                    }
                    LoadAracListesi(); // Listeyi yeniden yükle
                }
                else
                {
                    MessageBox.Show("Rezervasyon işlemi başarısız oldu.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin.");
            }
        }





    }
}