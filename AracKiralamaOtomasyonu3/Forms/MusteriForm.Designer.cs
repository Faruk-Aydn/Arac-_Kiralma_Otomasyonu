namespace AracKiralamaOtomasyonu3
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;

        // Temizlik işlemleri
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMevcutAraclar = new System.Windows.Forms.DataGridView();
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.dgvKiralamaGecmisi = new System.Windows.Forms.DataGridView();
            this.btnGecmisiGor = new System.Windows.Forms.Button();
            this.lblMevcutAraclar = new System.Windows.Forms.Label();
            this.lblKiralamaGecmisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamaGecmisi)).BeginInit();
            this.SuspendLayout();

            // dgvMevcutAraclar
            this.dgvMevcutAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMevcutAraclar.Location = new System.Drawing.Point(30, 50);
            this.dgvMevcutAraclar.Name = "dgvMevcutAraclar";
            this.dgvMevcutAraclar.Size = new System.Drawing.Size(400, 150);
            this.dgvMevcutAraclar.TabIndex = 0;

            // btnAracKirala
            this.btnAracKirala.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAracKirala.Location = new System.Drawing.Point(450, 50);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(120, 40);
            this.btnAracKirala.TabIndex = 1;
            this.btnAracKirala.Text = "Aracı Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = true;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);

            // dgvKiralamaGecmisi
            this.dgvKiralamaGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralamaGecmisi.Location = new System.Drawing.Point(30, 250);
            this.dgvKiralamaGecmisi.Name = "dgvKiralamaGecmisi";
            this.dgvKiralamaGecmisi.Size = new System.Drawing.Size(400, 150);
            this.dgvKiralamaGecmisi.TabIndex = 2;

            // btnGecmisiGor
            this.btnGecmisiGor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnGecmisiGor.Location = new System.Drawing.Point(450, 250);
            this.btnGecmisiGor.Name = "btnGecmisiGor";
            this.btnGecmisiGor.Size = new System.Drawing.Size(120, 40);
            this.btnGecmisiGor.TabIndex = 3;
            this.btnGecmisiGor.Text = "Kiralama Geçmişini Gör";
            this.btnGecmisiGor.UseVisualStyleBackColor = true;
            this.btnGecmisiGor.Click += new System.EventHandler(this.btnGecmisiGor_Click);

            // lblMevcutAraclar
            this.lblMevcutAraclar.AutoSize = true;
            this.lblMevcutAraclar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMevcutAraclar.ForeColor = System.Drawing.Color.White;
            this.lblMevcutAraclar.Location = new System.Drawing.Point(30, 20);
            this.lblMevcutAraclar.Name = "lblMevcutAraclar";
            this.lblMevcutAraclar.Size = new System.Drawing.Size(136, 19);
            this.lblMevcutAraclar.TabIndex = 4;
            this.lblMevcutAraclar.Text = "Mevcut Araçlar";

            // lblKiralamaGecmisi
            this.lblKiralamaGecmisi.AutoSize = true;
            this.lblKiralamaGecmisi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblKiralamaGecmisi.ForeColor = System.Drawing.Color.White;
            this.lblKiralamaGecmisi.Location = new System.Drawing.Point(30, 220);
            this.lblKiralamaGecmisi.Name = "lblKiralamaGecmisi";
            this.lblKiralamaGecmisi.Size = new System.Drawing.Size(158, 19);
            this.lblKiralamaGecmisi.TabIndex = 5;
            this.lblKiralamaGecmisi.Text = "Kiralama Geçmişi";

            // MusteriForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue; // Arka plan rengini ayarla
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblKiralamaGecmisi);
            this.Controls.Add(this.lblMevcutAraclar);
            this.Controls.Add(this.btnGecmisiGor);
            this.Controls.Add(this.dgvKiralamaGecmisi);
            this.Controls.Add(this.btnAracKirala);
            this.Controls.Add(this.dgvMevcutAraclar);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Ekranı";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMevcutAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralamaGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMevcutAraclar;
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.DataGridView dgvKiralamaGecmisi;
        private System.Windows.Forms.Button btnGecmisiGor;
        private System.Windows.Forms.Label lblMevcutAraclar;
        private System.Windows.Forms.Label lblKiralamaGecmisi;
    }
}
