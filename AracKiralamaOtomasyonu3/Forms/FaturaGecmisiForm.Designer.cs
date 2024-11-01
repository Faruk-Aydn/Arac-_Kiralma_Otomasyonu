namespace AracKiralamaOtomasyonu3
{
    partial class FaturaGecmisiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFaturaGecmisi;
        private System.Windows.Forms.Label lblFaturaGecmisi;

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
            this.dgvFaturaGecmisi = new System.Windows.Forms.DataGridView();
            this.lblFaturaGecmisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaturaGecmisi
            // 
            this.dgvFaturaGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaGecmisi.Location = new System.Drawing.Point(30, 50);
            this.dgvFaturaGecmisi.Name = "dgvFaturaGecmisi";
            this.dgvFaturaGecmisi.Size = new System.Drawing.Size(740, 350);
            this.dgvFaturaGecmisi.TabIndex = 0;
            this.dgvFaturaGecmisi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturaGecmisi_CellDoubleClick);
            // 
            // lblFaturaGecmisi
            // 
            this.lblFaturaGecmisi.AutoSize = true;
            this.lblFaturaGecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblFaturaGecmisi.Location = new System.Drawing.Point(30, 20);
            this.lblFaturaGecmisi.Name = "lblFaturaGecmisi";
            this.lblFaturaGecmisi.Size = new System.Drawing.Size(168, 29);
            this.lblFaturaGecmisi.TabIndex = 1;
            this.lblFaturaGecmisi.Text = "Fatura Geçmişi";
            // 
            // FaturaGecmisiForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFaturaGecmisi);
            this.Controls.Add(this.dgvFaturaGecmisi);
            this.Name = "FaturaGecmisiForm";
            this.Text = "Fatura Geçmişi";
            this.Load += new System.EventHandler(this.FaturaGecmisiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
