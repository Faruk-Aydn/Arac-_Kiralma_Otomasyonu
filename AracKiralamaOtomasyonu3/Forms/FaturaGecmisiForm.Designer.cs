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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFaturaGecmisi = new System.Windows.Forms.DataGridView();
            this.lblFaturaGecmisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaGecmisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaturaGecmisi
            // 
            this.dgvFaturaGecmisi.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFaturaGecmisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaturaGecmisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaturaGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaturaGecmisi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaturaGecmisi.EnableHeadersVisualStyles = false;
            this.dgvFaturaGecmisi.Location = new System.Drawing.Point(30, 60);
            this.dgvFaturaGecmisi.Name = "dgvFaturaGecmisi";
            this.dgvFaturaGecmisi.Size = new System.Drawing.Size(740, 350);
            this.dgvFaturaGecmisi.TabIndex = 1;
            this.dgvFaturaGecmisi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturaGecmisi_CellDoubleClick);
            // 
            // lblFaturaGecmisi
            // 
            this.lblFaturaGecmisi.AutoSize = true;
            this.lblFaturaGecmisi.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblFaturaGecmisi.ForeColor = System.Drawing.Color.White;
            this.lblFaturaGecmisi.Location = new System.Drawing.Point(30, 20);
            this.lblFaturaGecmisi.Name = "lblFaturaGecmisi";
            this.lblFaturaGecmisi.Size = new System.Drawing.Size(215, 32);
            this.lblFaturaGecmisi.TabIndex = 0;
            this.lblFaturaGecmisi.Text = "Fatura Geçmişi";
            // 
            // FaturaGecmisiForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFaturaGecmisi);
            this.Controls.Add(this.dgvFaturaGecmisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FaturaGecmisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Geçmişi";
            this.Load += new System.EventHandler(this.FaturaGecmisiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaGecmisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
