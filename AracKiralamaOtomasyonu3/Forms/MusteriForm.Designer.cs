using System;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class MusteriForm
    {
        private Panel sideMenuPanel;
        private Panel mainPanel;
        private Button btnAraclar;
        private Button btnGecmisKiralamalar;
        private Button btnFaturalar;
        private Button btnIndirimler;
        private Button btnYorumPuanlama;
        private Button btnLogout;
        private PictureBox logoPictureBox; 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriForm));
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.btnYorumPuanlama = new System.Windows.Forms.Button();
            this.btnIndirimler = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnGecmisKiralamalar = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sideMenuPanel.Controls.Add(this.btnYorumPuanlama);
            this.sideMenuPanel.Controls.Add(this.btnIndirimler);
            this.sideMenuPanel.Controls.Add(this.btnFaturalar);
            this.sideMenuPanel.Controls.Add(this.btnGecmisKiralamalar);
            this.sideMenuPanel.Controls.Add(this.logoPictureBox);
            this.sideMenuPanel.Controls.Add(this.btnAraclar);
            this.sideMenuPanel.Controls.Add(this.btnLogout);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(200, 700);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // btnYorumPuanlama
            // 
            this.btnYorumPuanlama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnYorumPuanlama.FlatAppearance.BorderSize = 0;
            this.btnYorumPuanlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYorumPuanlama.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnYorumPuanlama.ForeColor = System.Drawing.Color.White;
            this.btnYorumPuanlama.Image = ((System.Drawing.Image)(resources.GetObject("btnYorumPuanlama.Image")));
            this.btnYorumPuanlama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYorumPuanlama.Location = new System.Drawing.Point(3, 355);
            this.btnYorumPuanlama.Name = "btnYorumPuanlama";
            this.btnYorumPuanlama.Size = new System.Drawing.Size(200, 50);
            this.btnYorumPuanlama.TabIndex = 4;
            this.btnYorumPuanlama.Text = " Yorum ve Puanlama";
            this.btnYorumPuanlama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYorumPuanlama.UseVisualStyleBackColor = false;
            this.btnYorumPuanlama.Click += new System.EventHandler(this.BtnYorumPuanlama_Click);
            // 
            // btnIndirimler
            // 
            this.btnIndirimler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIndirimler.FlatAppearance.BorderSize = 0;
            this.btnIndirimler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndirimler.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnIndirimler.ForeColor = System.Drawing.Color.White;
            this.btnIndirimler.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirimler.Image")));
            this.btnIndirimler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndirimler.Location = new System.Drawing.Point(3, 299);
            this.btnIndirimler.Name = "btnIndirimler";
            this.btnIndirimler.Size = new System.Drawing.Size(200, 50);
            this.btnIndirimler.TabIndex = 0;
            this.btnIndirimler.Text = " İndirimler";
            this.btnIndirimler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIndirimler.UseVisualStyleBackColor = false;
            this.btnIndirimler.Click += new System.EventHandler(this.BtnIndirimler_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFaturalar.FlatAppearance.BorderSize = 0;
            this.btnFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturalar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFaturalar.ForeColor = System.Drawing.Color.White;
            this.btnFaturalar.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.Image")));
            this.btnFaturalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturalar.Location = new System.Drawing.Point(3, 252);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(200, 50);
            this.btnFaturalar.TabIndex = 1;
            this.btnFaturalar.Text = " Faturalar";
            this.btnFaturalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturalar.UseVisualStyleBackColor = false;
            this.btnFaturalar.Click += new System.EventHandler(this.BtnFaturalar_Click);
            // 
            // btnGecmisKiralamalar
            // 
            this.btnGecmisKiralamalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGecmisKiralamalar.FlatAppearance.BorderSize = 0;
            this.btnGecmisKiralamalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmisKiralamalar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGecmisKiralamalar.ForeColor = System.Drawing.Color.White;
            this.btnGecmisKiralamalar.Image = ((System.Drawing.Image)(resources.GetObject("btnGecmisKiralamalar.Image")));
            this.btnGecmisKiralamalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGecmisKiralamalar.Location = new System.Drawing.Point(3, 206);
            this.btnGecmisKiralamalar.Name = "btnGecmisKiralamalar";
            this.btnGecmisKiralamalar.Size = new System.Drawing.Size(200, 50);
            this.btnGecmisKiralamalar.TabIndex = 2;
            this.btnGecmisKiralamalar.Text = " Geçmiş Kiralamalar";
            this.btnGecmisKiralamalar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGecmisKiralamalar.UseVisualStyleBackColor = false;
            this.btnGecmisKiralamalar.Click += new System.EventHandler(this.BtnGecmisKiralamalar_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.logoPictureBox.Image = global::AracKiralamaOtomasyonu3.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(200, 164);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // btnAraclar
            // 
            this.btnAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAraclar.FlatAppearance.BorderSize = 0;
            this.btnAraclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraclar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAraclar.ForeColor = System.Drawing.Color.White;
            this.btnAraclar.Image = ((System.Drawing.Image)(resources.GetObject("btnAraclar.Image")));
            this.btnAraclar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAraclar.Location = new System.Drawing.Point(3, 159);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(200, 50);
            this.btnAraclar.TabIndex = 3;
            this.btnAraclar.Text = " Araçlar";
            this.btnAraclar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAraclar.UseVisualStyleBackColor = false;
            this.btnAraclar.Click += new System.EventHandler(this.BtnAraclar_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = " Çıkış Yap";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1101, 700);
            this.mainPanel.TabIndex = 0;
            // 
            // MusteriForm
            // 
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusteriForm_FormClosing);
            this.sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
