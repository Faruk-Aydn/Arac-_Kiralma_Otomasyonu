using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class KiralayanForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAracEkle;
        private Button btnAracSil;
        private Button btnKiralananAraclar;
        private Button btnKiralanmayanAraclar;
        private DataGridView dgvAraclar;
        private TextBox txtModel;
        private TextBox txtPlaka;
        private TextBox txtFiyat;
        private DateTimePicker dtpBakimTarihi;
        private Label lblModel;
        private Label lblPlaka;
        private Label lblFiyat;
        private Label lblBakimTarihi;
        private Button btnResimYukle;
        private PictureBox pbAracResim;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Form Genel Ayarlar
            this.BackColor = Color.CadetBlue; // Arka plan rengi
            this.Font = new Font("Arial", 10, FontStyle.Regular); // Genel font ayarı
            this.ClientSize = new Size(1120, 400); // Form boyutu
            this.Name = "KiralayanForm";
            this.Text = "Kiralayan Ekranı";

            // Bileşenleri Başlatma
            this.btnAracEkle = new Button();
            this.btnAracSil = new Button();
            this.btnKiralananAraclar = new Button();
            this.btnKiralanmayanAraclar = new Button();
            this.dgvAraclar = new DataGridView();
            this.txtModel = new TextBox();
            this.txtPlaka = new TextBox();
            this.txtFiyat = new TextBox();
            this.dtpBakimTarihi = new DateTimePicker();
            this.lblModel = new Label();
            this.lblPlaka = new Label();
            this.lblFiyat = new Label();
            this.lblBakimTarihi = new Label();
            this.btnResimYukle = new Button();
            this.pbAracResim = new PictureBox();

            // Araç Ekle Butonu
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.BackColor = Color.LightSlateGray;
            this.btnAracEkle.ForeColor = Color.White;
            this.btnAracEkle.FlatStyle = FlatStyle.Flat;
            this.btnAracEkle.Font = new Font("Arial", 10, FontStyle.Bold);
            this.btnAracEkle.Size = new Size(100, 40);
            this.btnAracEkle.Location = new Point(60, 260);
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);

            // Araç Sil Butonu
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.BackColor = Color.LightSlateGray;
            this.btnAracSil.ForeColor = Color.White;
            this.btnAracSil.FlatStyle = FlatStyle.Flat;
            this.btnAracSil.Font = new Font("Arial", 10, FontStyle.Bold);
            this.btnAracSil.Size = new Size(100, 40);
            this.btnAracSil.Location = new Point(170, 260);
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);

            // Kiralanan Araçları Listele Butonu
            this.btnKiralananAraclar.Text = "Kiralanan Araçları Listele";
            this.btnKiralananAraclar.BackColor = Color.Teal;
            this.btnKiralananAraclar.ForeColor = Color.White;
            this.btnKiralananAraclar.FlatStyle = FlatStyle.Flat;
            this.btnKiralananAraclar.Font = new Font("Arial", 10, FontStyle.Bold);
            this.btnKiralananAraclar.Size = new Size(150, 40);
            this.btnKiralananAraclar.Location = new Point(60, 310);
            this.btnKiralananAraclar.Click += new System.EventHandler(this.btnKiralananAraclar_Click);

            // Kiralanmayan Araçları Listele Butonu
            this.btnKiralanmayanAraclar.Text = "Kiralanmayan Araçları Listele";
            this.btnKiralanmayanAraclar.BackColor = Color.Teal;
            this.btnKiralanmayanAraclar.ForeColor = Color.White;
            this.btnKiralanmayanAraclar.FlatStyle = FlatStyle.Flat;
            this.btnKiralanmayanAraclar.Font = new Font("Arial", 10, FontStyle.Bold);
            this.btnKiralanmayanAraclar.Size = new Size(180, 40);
            this.btnKiralanmayanAraclar.Location = new Point(230, 310);
            this.btnKiralanmayanAraclar.Click += new System.EventHandler(this.btnKiralanmayanAraclar_Click);

            // Resim Yükle Butonu
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.BackColor = Color.SlateGray;
            this.btnResimYukle.ForeColor = Color.White;
            this.btnResimYukle.FlatStyle = FlatStyle.Flat;
            this.btnResimYukle.Font = new Font("Arial", 10, FontStyle.Bold);
            this.btnResimYukle.Size = new Size(120, 40);
            this.btnResimYukle.Location = new Point(330, 150);
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);

            // TextBox ve Label Bileşenleri
            this.txtModel.Location = new Point(150, 20); this.txtModel.Size = new Size(140, 22);
            this.txtPlaka.Location = new Point(150, 60); this.txtPlaka.Size = new Size(140, 22);
            this.txtFiyat.Location = new Point(150, 100); this.txtFiyat.Size = new Size(140, 22);
            this.dtpBakimTarihi.Location = new Point(150, 140); this.dtpBakimTarihi.Size = new Size(140, 22);

            this.lblModel.Text = "Model:"; this.lblModel.Location = new Point(60, 20); this.lblModel.ForeColor = Color.White;
            this.lblPlaka.Text = "Plaka:"; this.lblPlaka.Location = new Point(60, 60); this.lblPlaka.ForeColor = Color.White;
            this.lblFiyat.Text = "Fiyat:"; this.lblFiyat.Location = new Point(60, 100); this.lblFiyat.ForeColor = Color.White;
            this.lblBakimTarihi.Text = "Bakım Tarihi:"; this.lblBakimTarihi.Location = new Point(60, 140); this.lblBakimTarihi.ForeColor = Color.White;

            // DataGridView - Araç Listesi
            this.dgvAraclar.Location = new Point(500, 20);
            this.dgvAraclar.Size = new Size(580, 250);
            this.dgvAraclar.BackgroundColor = Color.LightGray;
            this.dgvAraclar.BorderStyle = BorderStyle.None;
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            this.dgvAraclar.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.dgvAraclar.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.dgvAraclar.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvAraclar.EnableHeadersVisualStyles = false;

            // PictureBox - Araç Resmi
            this.pbAracResim.Location = new Point(330, 20);
            this.pbAracResim.Size = new Size(140, 100);
            this.pbAracResim.BackColor = Color.Gray;
            this.pbAracResim.SizeMode = PictureBoxSizeMode.StretchImage;

            // Bileşenleri Forma Ekleme
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnKiralananAraclar);
            this.Controls.Add(this.btnKiralanmayanAraclar);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.dtpBakimTarihi);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblBakimTarihi);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.pbAracResim);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAracResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
