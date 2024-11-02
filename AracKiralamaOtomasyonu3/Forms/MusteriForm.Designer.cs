// MusteriForm.Designer.cs
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
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.btnGecmisiGor = new System.Windows.Forms.Button();
            this.lblMevcutAraclar = new System.Windows.Forms.Label();
            this.numKiralamaGunu = new System.Windows.Forms.NumericUpDown();
            this.lblKiralamaGunu = new System.Windows.Forms.Label();
            this.btnFaturaGecmisi = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.dgvKiralanmisAraclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiralamaGunu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMevcutAraclar
            // 
            this.dgvMevcutAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevcutAraclar.Location = new System.Drawing.Point(20, 65);
            this.dgvMevcutAraclar.Name = "dgvMevcutAraclar";
            this.dgvMevcutAraclar.Size = new System.Drawing.Size(500, 179);
            this.dgvMevcutAraclar.TabIndex = 0;
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Location = new System.Drawing.Point(548, 113);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(120, 30);
            this.btnAracKirala.TabIndex = 1;
            this.btnAracKirala.Text = "Aracı Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = true;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // btnGecmisiGor
            // 
            this.btnGecmisiGor.Location = new System.Drawing.Point(548, 292);
            this.btnGecmisiGor.Name = "btnGecmisiGor";
            this.btnGecmisiGor.Size = new System.Drawing.Size(120, 30);
            this.btnGecmisiGor.TabIndex = 2;
            this.btnGecmisiGor.Text = "Geçmişi Gör";
            this.btnGecmisiGor.UseVisualStyleBackColor = true;
            this.btnGecmisiGor.Click += new System.EventHandler(this.btnGecmisiGor_Click);
            // 
            // lblMevcutAraclar
            // 
            this.lblMevcutAraclar.AutoSize = true;
            this.lblMevcutAraclar.Location = new System.Drawing.Point(17, 33);
            this.lblMevcutAraclar.Name = "lblMevcutAraclar";
            this.lblMevcutAraclar.Size = new System.Drawing.Size(102, 17);
            this.lblMevcutAraclar.TabIndex = 3;
            this.lblMevcutAraclar.Text = "Mevcut Araçlar";
            // 
            // numKiralamaGunu
            // 
            this.numKiralamaGunu.Location = new System.Drawing.Point(548, 85);
            this.numKiralamaGunu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKiralamaGunu.Name = "numKiralamaGunu";
            this.numKiralamaGunu.Size = new System.Drawing.Size(120, 22);
            this.numKiralamaGunu.TabIndex = 4;
            this.numKiralamaGunu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblKiralamaGunu
            // 
            this.lblKiralamaGunu.AutoSize = true;
            this.lblKiralamaGunu.Location = new System.Drawing.Point(545, 65);
            this.lblKiralamaGunu.Name = "lblKiralamaGunu";
            this.lblKiralamaGunu.Size = new System.Drawing.Size(102, 17);
            this.lblKiralamaGunu.TabIndex = 5;
            this.lblKiralamaGunu.Text = "Kiralama Günü";
            // 
            // btnFaturaGecmisi
            // 
            this.btnFaturaGecmisi.Location = new System.Drawing.Point(548, 330);
            this.btnFaturaGecmisi.Name = "btnFaturaGecmisi";
            this.btnFaturaGecmisi.Size = new System.Drawing.Size(120, 30);
            this.btnFaturaGecmisi.TabIndex = 6;
            this.btnFaturaGecmisi.Text = "Fatura Geçmişi";
            this.btnFaturaGecmisi.UseVisualStyleBackColor = true;
            this.btnFaturaGecmisi.Click += new System.EventHandler(this.btnFaturaGecmisi_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(402, 14);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 22);
            this.txtModel.TabIndex = 8;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(558, 10);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrele.TabIndex = 9;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // dgvKiralanmisAraclar
            // 
            this.dgvKiralanmisAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralanmisAraclar.Location = new System.Drawing.Point(20, 292);
            this.dgvKiralanmisAraclar.Name = "dgvKiralanmisAraclar";
            this.dgvKiralanmisAraclar.Size = new System.Drawing.Size(500, 179);
            this.dgvKiralanmisAraclar.TabIndex = 1;
            // 
            // MusteriForm
            // 
            this.ClientSize = new System.Drawing.Size(680, 487);
            this.Controls.Add(this.dgvMevcutAraclar);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.btnGecmisiGor);
            this.Controls.Add(this.lblMevcutAraclar);
            this.Controls.Add(this.numKiralamaGunu);
            this.Controls.Add(this.lblKiralamaGunu);
            this.Controls.Add(this.btnFaturaGecmisi);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.dgvKiralanmisAraclar);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiralamaGunu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralanmisAraclar)).EndInit();
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

    }
}
