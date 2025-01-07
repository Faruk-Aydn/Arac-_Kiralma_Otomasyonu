namespace AracKiralamaOtomasyonu3.Forms
{
    partial class RezervasyonForm
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.DateEdit dtpBaslangicTarihi;
        private DevExpress.XtraEditors.DateEdit dtpTeslimTarihi;
        private DevExpress.XtraEditors.SimpleButton BtnRezervasyonYap;
        private DevExpress.XtraEditors.SimpleButton BtnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonForm));
            this.dtpBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dtpTeslimTarihi = new DevExpress.XtraEditors.DateEdit();
            this.BtnRezervasyonYap = new DevExpress.XtraEditors.SimpleButton();
            this.BtnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangicTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangicTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTeslimTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTeslimTarihi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.EditValue = null;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(150, 30);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangicTarihi.TabIndex = 0;
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.EditValue = null;
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(150, 70);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpTeslimTarihi.TabIndex = 1;
            // 
            // BtnRezervasyonYap
            // 
            this.BtnRezervasyonYap.Location = new System.Drawing.Point(142, 110);
            this.BtnRezervasyonYap.Name = "BtnRezervasyonYap";
            this.BtnRezervasyonYap.Size = new System.Drawing.Size(108, 30);
            this.BtnRezervasyonYap.TabIndex = 2;
            this.BtnRezervasyonYap.Text = "Rezervasyon Yap";
            this.BtnRezervasyonYap.Click += new System.EventHandler(this.BtnRezervasyonYap_Click);
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(260, 110);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(90, 30);
            this.BtnIptal.TabIndex = 3;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Başlangıç Tarihi :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Teslim Tarihi :";
            // 
            // RezervasyonForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnRezervasyonYap);
            this.Controls.Add(this.dtpTeslimTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Araç Rezervasyonu";
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangicTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangicTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTeslimTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTeslimTarihi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
