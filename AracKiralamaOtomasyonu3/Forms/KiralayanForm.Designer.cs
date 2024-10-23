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

        // Dispose işlemleri
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // InitializeComponent fonksiyonu
        private void InitializeComponent()
        {
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnKiralananAraclar = new System.Windows.Forms.Button();
            this.btnKiralanmayanAraclar = new System.Windows.Forms.Button();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.dtpBakimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblBakimTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(53, 247);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(97, 39);
            this.btnAracEkle.TabIndex = 9;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(175, 247);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(104, 39);
            this.btnAracSil.TabIndex = 10;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnKiralananAraclar
            // 
            this.btnKiralananAraclar.Location = new System.Drawing.Point(53, 310);
            this.btnKiralananAraclar.Name = "btnKiralananAraclar";
            this.btnKiralananAraclar.Size = new System.Drawing.Size(97, 39);
            this.btnKiralananAraclar.TabIndex = 11;
            this.btnKiralananAraclar.Text = "Kiralanan Araçları Listele";
            this.btnKiralananAraclar.Click += new System.EventHandler(this.btnKiralananAraclar_Click);
            // 
            // btnKiralanmayanAraclar
            // 
            this.btnKiralanmayanAraclar.Location = new System.Drawing.Point(175, 310);
            this.btnKiralanmayanAraclar.Name = "btnKiralanmayanAraclar";
            this.btnKiralanmayanAraclar.Size = new System.Drawing.Size(104, 39);
            this.btnKiralanmayanAraclar.TabIndex = 12;
            this.btnKiralanmayanAraclar.Text = "Kiralanmayan Araçları Listele";
            this.btnKiralanmayanAraclar.Click += new System.EventHandler(this.btnKiralanmayanAraclar_Click);
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.Location = new System.Drawing.Point(427, 20);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.Size = new System.Drawing.Size(600, 250);
            this.dgvAraclar.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(150, 20);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(150, 60);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 22);
            this.txtPlaka.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(150, 100);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // dtpBakimTarihi
            // 
            this.dtpBakimTarihi.Location = new System.Drawing.Point(150, 140);
            this.dtpBakimTarihi.Name = "dtpBakimTarihi";
            this.dtpBakimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBakimTarihi.TabIndex = 8;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(50, 20);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 23);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblPlaka
            // 
            this.lblPlaka.Location = new System.Drawing.Point(50, 60);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(100, 23);
            this.lblPlaka.TabIndex = 3;
            this.lblPlaka.Text = "Plaka:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.Location = new System.Drawing.Point(50, 100);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(100, 23);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblBakimTarihi
            // 
            this.lblBakimTarihi.Location = new System.Drawing.Point(50, 140);
            this.lblBakimTarihi.Name = "lblBakimTarihi";
            this.lblBakimTarihi.Size = new System.Drawing.Size(100, 23);
            this.lblBakimTarihi.TabIndex = 7;
            this.lblBakimTarihi.Text = "Bakım Tarihi:";
            // 
            // KiralayanForm
            // 
            this.ClientSize = new System.Drawing.Size(1190, 427);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblBakimTarihi);
            this.Controls.Add(this.dtpBakimTarihi);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnKiralananAraclar);
            this.Controls.Add(this.btnKiralanmayanAraclar);
            this.Controls.Add(this.dgvAraclar);
            this.Name = "KiralayanForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

