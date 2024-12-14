using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvMevcutAraclar = new System.Windows.Forms.DataGridView();
            this.dgvKiralanmisAraclar = new System.Windows.Forms.DataGridView();
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.btnGecmisiGor = new System.Windows.Forms.Button();
            this.lblMevcutAraclar = new System.Windows.Forms.Label();
            this.lblKiralanmisAraclar = new System.Windows.Forms.Label();
            this.numKiralamaGunu = new System.Windows.Forms.NumericUpDown();
            this.lblKiralamaGunu = new System.Windows.Forms.Label();
            this.btnFaturaGecmisi = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FormClosing += new FormClosingEventHandler(MusteriForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiralamaGunu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMevcutAraclar
            // 
            this.dgvMevcutAraclar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMevcutAraclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMevcutAraclar.Location = new System.Drawing.Point(20, 60);
            this.dgvMevcutAraclar.Name = "dgvMevcutAraclar";
            this.dgvMevcutAraclar.Size = new System.Drawing.Size(500, 200);
            this.dgvMevcutAraclar.TabIndex = 0;
            // 
            // dgvKiralanmisAraclar
            // 
            this.dgvKiralanmisAraclar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvKiralanmisAraclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKiralanmisAraclar.Location = new System.Drawing.Point(20, 300);
            this.dgvKiralanmisAraclar.Name = "dgvKiralanmisAraclar";
            this.dgvKiralanmisAraclar.Size = new System.Drawing.Size(500, 200);
            this.dgvKiralanmisAraclar.TabIndex = 2;
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAracKirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracKirala.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAracKirala.ForeColor = System.Drawing.Color.White;
            this.btnAracKirala.Location = new System.Drawing.Point(550, 60);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(120, 40);
            this.btnAracKirala.TabIndex = 4;
            this.btnAracKirala.Text = "Aracı Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = false;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // btnGecmisiGor
            // 
            this.btnGecmisiGor.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGecmisiGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmisiGor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGecmisiGor.ForeColor = System.Drawing.Color.White;
            this.btnGecmisiGor.Location = new System.Drawing.Point(550, 460);
            this.btnGecmisiGor.Name = "btnGecmisiGor";
            this.btnGecmisiGor.Size = new System.Drawing.Size(120, 40);
            this.btnGecmisiGor.TabIndex = 9;
            this.btnGecmisiGor.Text = "Geçmişi Gör";
            this.btnGecmisiGor.UseVisualStyleBackColor = false;
            this.btnGecmisiGor.Click += new System.EventHandler(this.btnGecmisiGor_Click);
            // 
            // lblMevcutAraclar
            // 
            this.lblMevcutAraclar.AutoSize = true;
            this.lblMevcutAraclar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMevcutAraclar.ForeColor = System.Drawing.Color.White;
            this.lblMevcutAraclar.Location = new System.Drawing.Point(20, 30);
            this.lblMevcutAraclar.Name = "lblMevcutAraclar";
            this.lblMevcutAraclar.Size = new System.Drawing.Size(151, 24);
            this.lblMevcutAraclar.TabIndex = 1;
            this.lblMevcutAraclar.Text = "Mevcut Araçlar";
            // 
            // lblKiralanmisAraclar
            // 
            this.lblKiralanmisAraclar.AutoSize = true;
            this.lblKiralanmisAraclar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblKiralanmisAraclar.ForeColor = System.Drawing.Color.White;
            this.lblKiralanmisAraclar.Location = new System.Drawing.Point(20, 270);
            this.lblKiralanmisAraclar.Name = "lblKiralanmisAraclar";
            this.lblKiralanmisAraclar.Size = new System.Drawing.Size(181, 24);
            this.lblKiralanmisAraclar.TabIndex = 3;
            this.lblKiralanmisAraclar.Text = "Kiralanmış Araçlar";
            // 
            // numKiralamaGunu
            // 
            this.numKiralamaGunu.Font = new System.Drawing.Font("Arial", 10F);
            this.numKiralamaGunu.Location = new System.Drawing.Point(550, 140);
            this.numKiralamaGunu.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numKiralamaGunu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKiralamaGunu.Name = "numKiralamaGunu";
            this.numKiralamaGunu.Size = new System.Drawing.Size(120, 27);
            this.numKiralamaGunu.TabIndex = 5;
            this.numKiralamaGunu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKiralamaGunu
            // 
            this.lblKiralamaGunu.AutoSize = true;
            this.lblKiralamaGunu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblKiralamaGunu.ForeColor = System.Drawing.Color.White;
            this.lblKiralamaGunu.Location = new System.Drawing.Point(550, 120);
            this.lblKiralamaGunu.Name = "lblKiralamaGunu";
            this.lblKiralamaGunu.Size = new System.Drawing.Size(125, 19);
            this.lblKiralamaGunu.TabIndex = 6;
            this.lblKiralamaGunu.Text = "Kiralama Günü";
            // 
            // btnFaturaGecmisi
            // 
            this.btnFaturaGecmisi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFaturaGecmisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaGecmisi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFaturaGecmisi.ForeColor = System.Drawing.Color.White;
            this.btnFaturaGecmisi.Location = new System.Drawing.Point(550, 406);
            this.btnFaturaGecmisi.Name = "btnFaturaGecmisi";
            this.btnFaturaGecmisi.Size = new System.Drawing.Size(120, 40);
            this.btnFaturaGecmisi.TabIndex = 10;
            this.btnFaturaGecmisi.Text = "Fatura Geçmişi";
            this.btnFaturaGecmisi.UseVisualStyleBackColor = false;
            this.btnFaturaGecmisi.Click += new System.EventHandler(this.btnFaturaGecmisi_Click);
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Arial", 10F);
            this.txtModel.Location = new System.Drawing.Point(550, 170);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(120, 27);
            this.txtModel.TabIndex = 7;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(550, 200);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(120, 40);
            this.btnFiltrele.TabIndex = 8;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(695, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 497);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // MusteriForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1015, 550);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvMevcutAraclar);
            this.Controls.Add(this.lblMevcutAraclar);
            this.Controls.Add(this.dgvKiralanmisAraclar);
            this.Controls.Add(this.lblKiralanmisAraclar);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.numKiralamaGunu);
            this.Controls.Add(this.lblKiralamaGunu);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.btnGecmisiGor);
            this.Controls.Add(this.btnFaturaGecmisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiralamaGunu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.DataGridView dgvMevcutAraclar;
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.Button btnGecmisiGor;
        private System.Windows.Forms.Label lblMevcutAraclar;
        private System.Windows.Forms.NumericUpDown numKiralamaGunu;
        private System.Windows.Forms.Label lblKiralamaGunu;
        private System.Windows.Forms.Button btnFaturaGecmisi;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.DataGridView dgvKiralanmisAraclar;
        private System.Windows.Forms.Label lblKiralanmisAraclar;

        private FlowLayoutPanel flowLayoutPanel1;
    }
}