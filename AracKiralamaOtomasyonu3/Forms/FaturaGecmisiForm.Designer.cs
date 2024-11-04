using System.Drawing;
using System.Windows.Forms;

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

            // Form arka plan rengi ve genel ayarları
            this.BackColor = Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FaturaGecmisiForm";
            this.Text = "Fatura Geçmişi";
            this.Load += new System.EventHandler(this.FaturaGecmisiForm_Load);

            // Label - Fatura Geçmişi Başlığı
            this.lblFaturaGecmisi.AutoSize = true;
            this.lblFaturaGecmisi.Font = new Font("Arial", 16F, FontStyle.Bold);
            this.lblFaturaGecmisi.ForeColor = Color.White;
            this.lblFaturaGecmisi.Location = new Point(30, 20);
            this.lblFaturaGecmisi.Name = "lblFaturaGecmisi";
            this.lblFaturaGecmisi.Size = new Size(168, 29);
            this.lblFaturaGecmisi.Text = "Fatura Geçmişi";

            // DataGridView - Fatura Geçmişi
            this.dgvFaturaGecmisi.Location = new Point(30, 60);
            this.dgvFaturaGecmisi.Size = new Size(740, 350);
            this.dgvFaturaGecmisi.BackgroundColor = Color.LightGray;
            this.dgvFaturaGecmisi.BorderStyle = BorderStyle.None;
            this.dgvFaturaGecmisi.EnableHeadersVisualStyles = false;
            this.dgvFaturaGecmisi.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            this.dgvFaturaGecmisi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvFaturaGecmisi.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            this.dgvFaturaGecmisi.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.dgvFaturaGecmisi.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvFaturaGecmisi.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            this.dgvFaturaGecmisi.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvFaturaGecmisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaGecmisi.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvFaturaGecmisi_CellDoubleClick);

            // Bileşenleri Forma Ekleme
            this.Controls.Add(this.lblFaturaGecmisi);
            this.Controls.Add(this.dgvFaturaGecmisi);

            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
