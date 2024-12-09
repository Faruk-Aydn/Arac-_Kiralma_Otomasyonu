using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class KiralayanForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxAracResim;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxAracResim = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
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
            this.btnResimYukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAracResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAracResim
            // 
            this.pictureBoxAracResim.Location = new System.Drawing.Point(90, 199);
            this.pictureBoxAracResim.Name = "pictureBoxAracResim";
            this.pictureBoxAracResim.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxAracResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAracResim.TabIndex = 0;
            this.pictureBoxAracResim.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(296, 267);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(6, 267);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAracEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracEkle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAracEkle.ForeColor = System.Drawing.Color.White;
            this.btnAracEkle.Location = new System.Drawing.Point(12, 409);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(100, 40);
            this.btnAracEkle.TabIndex = 0;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAracSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracSil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAracSil.ForeColor = System.Drawing.Color.White;
            this.btnAracSil.Location = new System.Drawing.Point(118, 409);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(100, 40);
            this.btnAracSil.TabIndex = 1;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = false;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnKiralananAraclar
            // 
            this.btnKiralananAraclar.BackColor = System.Drawing.Color.Teal;
            this.btnKiralananAraclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiralananAraclar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnKiralananAraclar.ForeColor = System.Drawing.Color.White;
            this.btnKiralananAraclar.Location = new System.Drawing.Point(6, 461);
            this.btnKiralananAraclar.Name = "btnKiralananAraclar";
            this.btnKiralananAraclar.Size = new System.Drawing.Size(150, 40);
            this.btnKiralananAraclar.TabIndex = 2;
            this.btnKiralananAraclar.Text = "Kiralanan Araçları Listele";
            this.btnKiralananAraclar.UseVisualStyleBackColor = false;
            this.btnKiralananAraclar.Click += new System.EventHandler(this.btnKiralananAraclar_Click);
            // 
            // btnKiralanmayanAraclar
            // 
            this.btnKiralanmayanAraclar.BackColor = System.Drawing.Color.Teal;
            this.btnKiralanmayanAraclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiralanmayanAraclar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnKiralanmayanAraclar.ForeColor = System.Drawing.Color.White;
            this.btnKiralanmayanAraclar.Location = new System.Drawing.Point(162, 461);
            this.btnKiralanmayanAraclar.Name = "btnKiralanmayanAraclar";
            this.btnKiralanmayanAraclar.Size = new System.Drawing.Size(180, 40);
            this.btnKiralanmayanAraclar.TabIndex = 3;
            this.btnKiralanmayanAraclar.Text = "Kiralanmayan Araçları Listele";
            this.btnKiralanmayanAraclar.UseVisualStyleBackColor = false;
            this.btnKiralanmayanAraclar.Click += new System.EventHandler(this.btnKiralanmayanAraclar_Click);
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAraclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAraclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAraclar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAraclar.EnableHeadersVisualStyles = false;
            this.dgvAraclar.Location = new System.Drawing.Point(400, 20);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.Size = new System.Drawing.Size(580, 433);
            this.dgvAraclar.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(150, 20);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(140, 27);
            this.txtModel.TabIndex = 5;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(150, 60);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(140, 27);
            this.txtPlaka.TabIndex = 6;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(150, 100);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(140, 27);
            this.txtFiyat.TabIndex = 7;
            // 
            // dtpBakimTarihi
            // 
            this.dtpBakimTarihi.Location = new System.Drawing.Point(150, 140);
            this.dtpBakimTarihi.Name = "dtpBakimTarihi";
            this.dtpBakimTarihi.Size = new System.Drawing.Size(140, 27);
            this.dtpBakimTarihi.TabIndex = 8;
            // 
            // lblModel
            // 
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(60, 20);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 23);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblPlaka
            // 
            this.lblPlaka.ForeColor = System.Drawing.Color.White;
            this.lblPlaka.Location = new System.Drawing.Point(60, 60);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(100, 23);
            this.lblPlaka.TabIndex = 10;
            this.lblPlaka.Text = "Plaka:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(60, 100);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(100, 23);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblBakimTarihi
            // 
            this.lblBakimTarihi.ForeColor = System.Drawing.Color.White;
            this.lblBakimTarihi.Location = new System.Drawing.Point(56, 140);
            this.lblBakimTarihi.Name = "lblBakimTarihi";
            this.lblBakimTarihi.Size = new System.Drawing.Size(100, 23);
            this.lblBakimTarihi.TabIndex = 12;
            this.lblBakimTarihi.Text = "Bakım Tarihi:";
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.BackColor = System.Drawing.Color.SlateGray;
            this.btnResimYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimYukle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnResimYukle.ForeColor = System.Drawing.Color.White;
            this.btnResimYukle.Location = new System.Drawing.Point(224, 409);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(120, 40);
            this.btnResimYukle.TabIndex = 13;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = false;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // KiralayanForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1039, 541);
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
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pictureBoxAracResim);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "KiralayanForm";
            this.Text = "Kiralayan Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAracResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}