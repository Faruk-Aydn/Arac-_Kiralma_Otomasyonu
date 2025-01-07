using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

public partial class AddCarControl : XtraUserControl
{
    private List<byte[]> _aracFotograflar = new List<byte[]>(); // Fotoğraf verilerini tutar
    private int _currentPhotoIndex = 0; // Şu anki fotoğraf indeksi
    int _kiralyanId;

    public AddCarControl(int kiralayanId)
    {
        InitializeComponent();
        _kiralyanId = kiralayanId;
    }

    private void btnAracEkle_Click(object sender, EventArgs e)
    {
        using (var context = new AracKiralamaContext())
        {
            // Fiyat doğrulama
            if (!decimal.TryParse(txtFiyat.Text, out var fiyat))
            {
                XtraMessageBox.Show("Lütfen geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtYil.Text, out var yil))
            {
                XtraMessageBox.Show("Lütfen geçerli bir yıl girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtKilometre.Text, out var kilometre))
            {
                XtraMessageBox.Show("Lütfen geçerli bir kilometre girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var arac = new Arac
            {
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                Plaka = txtPlaka.Text,
                Fiyat = fiyat,
                KiralandiMi = false,
                BakimTarihi = dtpBakimTarihi.DateTime,
                Yil = yil,
                Renk = txtRenk.Text,
                YakitCinsi = txtYakitCinsi.Text,
                Kilometre = kilometre,
                FotografListesi = _aracFotograflar.Select(foto => new AracFotograf { FotoData = foto }).ToList()
            };

            context.Araclar.Add(arac);
            context.SaveChanges();

            XtraMessageBox.Show("Araç ve fotoğraflar başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListeyiGuncelle();
            _aracFotograflar.Clear();
            imageSlider.Images.Clear();
        }
    }

    private void btnResimYukle_Click(object sender, EventArgs e)
    {
        using (var openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filePath in openFileDialog.FileNames)
                {
                    byte[] fotoData = File.ReadAllBytes(filePath);
                    _aracFotograflar.Add(fotoData);

                    // Resmi DevExpress ImageSlider'a ekle
                    using (var stream = new MemoryStream(fotoData))
                    {
                        imageSlider.Images.Add(Image.FromStream(stream));
                    }
                }

                XtraMessageBox.Show("Fotoğraflar başarıyla yüklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void ListeyiGuncelle()
    {
        // Eklenen araçları güncellemek için listeleme işlemi yapılabilir.
        // Şimdilik boş bırakıldı.
    }

    private void InitializeComponent()

    {
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.dtpBakimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lblBakimTarihi = new DevExpress.XtraEditors.LabelControl();
            this.txtYil = new DevExpress.XtraEditors.TextEdit();
            this.txtRenk = new DevExpress.XtraEditors.TextEdit();
            this.txtYakitCinsi = new DevExpress.XtraEditors.TextEdit();
            this.txtKilometre = new DevExpress.XtraEditors.TextEdit();
            this.btnAracEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnResimYukle = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBakimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBakimTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYakitCinsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.Location = new System.Drawing.Point(3, 3);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.lblBaslik.Size = new System.Drawing.Size(160, 67);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "ARAÇ EKLE";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(20, 124);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Properties.NullValuePrompt = "Marka";
            this.txtMarka.Size = new System.Drawing.Size(250, 22);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(20, 152);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.NullValuePrompt = "Model";
            this.txtModel.Size = new System.Drawing.Size(250, 22);
            this.txtModel.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(20, 180);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Properties.NullValuePrompt = "Plaka";
            this.txtPlaka.Size = new System.Drawing.Size(250, 22);
            this.txtPlaka.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(20, 208);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.NullValuePrompt = "Fiyat";
            this.txtFiyat.Size = new System.Drawing.Size(250, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // dtpBakimTarihi
            // 
            this.dtpBakimTarihi.EditValue = new System.DateTime(2024, 12, 26, 0, 0, 0, 0);
            this.dtpBakimTarihi.Location = new System.Drawing.Point(120, 348);
            this.dtpBakimTarihi.Name = "dtpBakimTarihi";
            this.dtpBakimTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBakimTarihi.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBakimTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpBakimTarihi.Size = new System.Drawing.Size(150, 22);
            this.dtpBakimTarihi.TabIndex = 9;
            // 
            // lblBakimTarihi
            // 
            this.lblBakimTarihi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBakimTarihi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBakimTarihi.Appearance.Options.UseBackColor = true;
            this.lblBakimTarihi.Appearance.Options.UseForeColor = true;
            this.lblBakimTarihi.Location = new System.Drawing.Point(20, 348);
            this.lblBakimTarihi.Name = "lblBakimTarihi";
            this.lblBakimTarihi.Size = new System.Drawing.Size(76, 16);
            this.lblBakimTarihi.TabIndex = 8;
            this.lblBakimTarihi.Text = "Bakım Tarihi:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(20, 236);
            this.txtYil.Name = "txtYil";
            this.txtYil.Properties.NullValuePrompt = "Yıl";
            this.txtYil.Size = new System.Drawing.Size(250, 22);
            this.txtYil.TabIndex = 4;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(20, 264);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Properties.NullValuePrompt = "Renk";
            this.txtRenk.Size = new System.Drawing.Size(250, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // txtYakitCinsi
            // 
            this.txtYakitCinsi.Location = new System.Drawing.Point(20, 292);
            this.txtYakitCinsi.Name = "txtYakitCinsi";
            this.txtYakitCinsi.Properties.NullValuePrompt = "Yakıt Cinsi";
            this.txtYakitCinsi.Size = new System.Drawing.Size(250, 22);
            this.txtYakitCinsi.TabIndex = 6;
            // 
            // txtKilometre
            // 
            this.txtKilometre.Location = new System.Drawing.Point(20, 320);
            this.txtKilometre.Name = "txtKilometre";
            this.txtKilometre.Properties.NullValuePrompt = "Kilometre";
            this.txtKilometre.Size = new System.Drawing.Size(250, 22);
            this.txtKilometre.TabIndex = 7;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(20, 391);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(250, 30);
            this.btnAracEkle.TabIndex = 10;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(20, 438);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(250, 30);
            this.btnResimYukle.TabIndex = 11;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // imageSlider
            // 
            this.imageSlider.Location = new System.Drawing.Point(407, 127);
            this.imageSlider.Name = "imageSlider";
            this.imageSlider.Size = new System.Drawing.Size(400, 300);
            this.imageSlider.TabIndex = 12;
            // 
            // AddCarControl
            // 
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtYakitCinsi);
            this.Controls.Add(this.txtKilometre);
            this.Controls.Add(this.lblBakimTarihi);
            this.Controls.Add(this.dtpBakimTarihi);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.imageSlider);
            this.Name = "AddCarControl";
            this.Size = new System.Drawing.Size(926, 587);
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBakimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBakimTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYakitCinsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilometre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    private DevExpress.XtraEditors.LabelControl lblBaslik;
    private DevExpress.XtraEditors.TextEdit txtMarka;
    private DevExpress.XtraEditors.TextEdit txtModel;
    private DevExpress.XtraEditors.TextEdit txtPlaka;
    private DevExpress.XtraEditors.TextEdit txtFiyat;
    private DevExpress.XtraEditors.DateEdit dtpBakimTarihi;
    private DevExpress.XtraEditors.LabelControl lblBakimTarihi;
    private DevExpress.XtraEditors.TextEdit txtYil;
    private DevExpress.XtraEditors.TextEdit txtRenk;
    private DevExpress.XtraEditors.TextEdit txtYakitCinsi;
    private DevExpress.XtraEditors.TextEdit txtKilometre;
    private DevExpress.XtraEditors.SimpleButton btnAracEkle;
    private DevExpress.XtraEditors.SimpleButton btnResimYukle;
    private DevExpress.XtraEditors.Controls.ImageSlider imageSlider;
}
