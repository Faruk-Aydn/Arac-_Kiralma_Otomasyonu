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

            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKiralamaGunu)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvMevcutAraclar
            // 
            this.dgvMevcutAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevcutAraclar.Location = new System.Drawing.Point(30, 100);
            this.dgvMevcutAraclar.Name = "dgvMevcutAraclar";
            this.dgvMevcutAraclar.Size = new System.Drawing.Size(900, 300);
            this.dgvMevcutAraclar.TabIndex = 0;

            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Location = new System.Drawing.Point(450, 450);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(100, 40);
            this.btnAracKirala.TabIndex = 1;
            this.btnAracKirala.Text = "Aracı Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = true;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);

            // 
            // btnGecmisiGor
            // 
            this.btnGecmisiGor.Location = new System.Drawing.Point(600, 450);
            this.btnGecmisiGor.Name = "btnGecmisiGor";
            this.btnGecmisiGor.Size = new System.Drawing.Size(150, 40);
            this.btnGecmisiGor.TabIndex = 2;
            this.btnGecmisiGor.Text = "Kiralama Geçmişini Gör";
            this.btnGecmisiGor.UseVisualStyleBackColor = true;
            this.btnGecmisiGor.Click += new System.EventHandler(this.btnGecmisiGor_Click);

            // 
            // lblMevcutAraclar
            // 
            this.lblMevcutAraclar.AutoSize = true;
            this.lblMevcutAraclar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMevcutAraclar.ForeColor = System.Drawing.Color.White;
            this.lblMevcutAraclar.Location = new System.Drawing.Point(30, 60);
            this.lblMevcutAraclar.Name = "lblMevcutAraclar";
            this.lblMevcutAraclar.Size = new System.Drawing.Size(120, 24);
            this.lblMevcutAraclar.TabIndex = 3;
            this.lblMevcutAraclar.Text = "Araç Listesi";

            // 
            // numKiralamaGunu
            // 
            this.numKiralamaGunu.Location = new System.Drawing.Point(30, 450);
            this.numKiralamaGunu.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.numKiralamaGunu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numKiralamaGunu.Name = "numKiralamaGunu";
            this.numKiralamaGunu.Size = new System.Drawing.Size(60, 22);
            this.numKiralamaGunu.TabIndex = 4;
            this.numKiralamaGunu.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // lblKiralamaGunu
            // 
            this.lblKiralamaGunu.AutoSize = true;
            this.lblKiralamaGunu.Location = new System.Drawing.Point(100, 450);
            this.lblKiralamaGunu.Name = "lblKiralamaGunu";
            this.lblKiralamaGunu.Size = new System.Drawing.Size(100, 17);
            this.lblKiralamaGunu.TabIndex = 5;
            this.lblKiralamaGunu.Text = "Kiralama Günü";

            // 
            // btnFaturaGecmisi
            // 
            this.btnFaturaGecmisi.Location = new System.Drawing.Point(300, 450);
            this.btnFaturaGecmisi.Name = "btnFaturaGecmisi";
            this.btnFaturaGecmisi.Size = new System.Drawing.Size(120, 40);
            this.btnFaturaGecmisi.TabIndex = 6;
            this.btnFaturaGecmisi.Text = "Fatura Geçmişi";
            this.btnFaturaGecmisi.UseVisualStyleBackColor = true;
            this.btnFaturaGecmisi.Click += new System.EventHandler(this.btnFaturaGecmisi_Click);

            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(650, 20);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 22);
            this.txtModel.TabIndex = 7;
            this.txtModel.Text = "Model Ara";

            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(810, 20);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrele.TabIndex = 8;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);

            // 
            // MusteriForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.dgvMevcutAraclar);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.btnGecmisiGor);
            this.Controls.Add(this.lblMevcutAraclar);
            this.Controls.Add(this.numKiralamaGunu);
            this.Controls.Add(this.lblKiralamaGunu);
            this.Controls.Add(this.btnFaturaGecmisi);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnFiltrele);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Ekranı";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).EndInit();
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
    }
}
