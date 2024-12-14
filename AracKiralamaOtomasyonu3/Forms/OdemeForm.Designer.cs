using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class OdemeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKartSahibi;
        private System.Windows.Forms.TextBox txtKartNumarasi;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblKartSahibi;
        private System.Windows.Forms.Label lblKartNumarasi;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.DateTimePicker dtpSonKullanmaTarihi;
        private System.Windows.Forms.Label lblSonKullanmaTarihi;

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
            this.txtKartSahibi = new System.Windows.Forms.TextBox();
            this.txtKartNumarasi = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblKartSahibi = new System.Windows.Forms.Label();
            this.lblKartNumarasi = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.dtpSonKullanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSonKullanmaTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKartSahibi
            // 
            this.txtKartSahibi.Location = new System.Drawing.Point(200, 20);
            this.txtKartSahibi.Name = "txtKartSahibi";
            this.txtKartSahibi.Size = new System.Drawing.Size(150, 22);
            this.txtKartSahibi.TabIndex = 0;
            // 
            // txtKartNumarasi
            // 
            this.txtKartNumarasi.Location = new System.Drawing.Point(200, 60);
            this.txtKartNumarasi.MaxLength = 16;
            this.txtKartNumarasi.Name = "txtKartNumarasi";
            this.txtKartNumarasi.Size = new System.Drawing.Size(150, 22);
            this.txtKartNumarasi.TabIndex = 1;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(200, 140);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(50, 22);
            this.txtCVV.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnOdemeYap.FlatAppearance.BorderSize = 0;
            this.btnOdemeYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdemeYap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(150, 200);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(120, 40);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblKartSahibi
            // 
            this.lblKartSahibi.AutoSize = true;
            this.lblKartSahibi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblKartSahibi.ForeColor = System.Drawing.Color.White;
            this.lblKartSahibi.Location = new System.Drawing.Point(50, 20);
            this.lblKartSahibi.Name = "lblKartSahibi";
            this.lblKartSahibi.Size = new System.Drawing.Size(102, 19);
            this.lblKartSahibi.TabIndex = 0;
            this.lblKartSahibi.Text = "Kart Sahibi:";
            // 
            // lblKartNumarasi
            // 
            this.lblKartNumarasi.AutoSize = true;
            this.lblKartNumarasi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblKartNumarasi.ForeColor = System.Drawing.Color.White;
            this.lblKartNumarasi.Location = new System.Drawing.Point(50, 60);
            this.lblKartNumarasi.Name = "lblKartNumarasi";
            this.lblKartNumarasi.Size = new System.Drawing.Size(128, 19);
            this.lblKartNumarasi.TabIndex = 1;
            this.lblKartNumarasi.Text = "Kart Numarası:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblCVV.ForeColor = System.Drawing.Color.White;
            this.lblCVV.Location = new System.Drawing.Point(50, 140);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(48, 19);
            this.lblCVV.TabIndex = 3;
            this.lblCVV.Text = "CVV:";
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(227, 100);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(100, 22);
            this.dtpSonKullanmaTarihi.TabIndex = 2;
            // 
            // lblSonKullanmaTarihi
            // 
            this.lblSonKullanmaTarihi.AutoSize = true;
            this.lblSonKullanmaTarihi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSonKullanmaTarihi.ForeColor = System.Drawing.Color.White;
            this.lblSonKullanmaTarihi.Location = new System.Drawing.Point(50, 100);
            this.lblSonKullanmaTarihi.Name = "lblSonKullanmaTarihi";
            this.lblSonKullanmaTarihi.Size = new System.Drawing.Size(171, 19);
            this.lblSonKullanmaTarihi.TabIndex = 2;
            this.lblSonKullanmaTarihi.Text = "Son Kullanma Tarihi:";
            // 
            // OdemeForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblKartSahibi);
            this.Controls.Add(this.txtKartSahibi);
            this.Controls.Add(this.lblKartNumarasi);
            this.Controls.Add(this.txtKartNumarasi);
            this.Controls.Add(this.lblSonKullanmaTarihi);
            this.Controls.Add(this.dtpSonKullanmaTarihi);
            this.Controls.Add(this.lblCVV);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.btnOdemeYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
