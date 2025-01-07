using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    public partial class YorumPuanlamaControl : XtraUserControl
    {
        public YorumPuanlamaControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ratingControl = new DevExpress.XtraEditors.RatingControl();
            this.txtYorum = new DevExpress.XtraEditors.MemoEdit();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYorum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingControl
            // 
            this.ratingControl.Location = new System.Drawing.Point(20, 90);
            this.ratingControl.Name = "ratingControl";
            this.ratingControl.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.ratingControl.Properties.Appearance.Options.UseForeColor = true;
            this.ratingControl.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Gray;
            this.ratingControl.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.ratingControl.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ratingControl.Size = new System.Drawing.Size(87, 16);
            this.ratingControl.TabIndex = 0;
            // 
            // txtYorum
            // 
            this.txtYorum.EditValue = "Yorumunuzu buraya yazın...";
            this.txtYorum.Location = new System.Drawing.Point(20, 130);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtYorum.Properties.Appearance.Options.UseForeColor = true;
            this.txtYorum.Properties.MaxLength = 500;
            this.txtYorum.Size = new System.Drawing.Size(400, 127);
            this.txtYorum.TabIndex = 1;
            this.txtYorum.Click += new System.EventHandler(this.TxtYorum_Click);
            this.txtYorum.Leave += new System.EventHandler(this.TxtYorum_Leave);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(20, 272);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 34);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblBaslik.Location = new System.Drawing.Point(3, 3);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.lblBaslik.Size = new System.Drawing.Size(319, 67);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "YORUM ve PUANLAMA";
            // 
            // pictureEdit
            // 
            this.pictureEdit.EditValue = global::AracKiralamaOtomasyonu3.Properties.Resources.raiting;
            this.pictureEdit.Location = new System.Drawing.Point(449, 3);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit.Size = new System.Drawing.Size(546, 554);
            this.pictureEdit.TabIndex = 7;
            // 
            // YorumPuanlamaControl
            // 
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.ratingControl);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.btnGonder);
            this.Name = "YorumPuanlamaControl";
            this.Size = new System.Drawing.Size(998, 642);
            ((System.ComponentModel.ISupportInitialize)(this.ratingControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYorum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.RatingControl ratingControl;
        private DevExpress.XtraEditors.MemoEdit txtYorum;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;

        // Butona tıklanınca yorum ve puanları işleme
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            string yorum = txtYorum.EditValue.ToString();
            int puan = Convert.ToInt32(ratingControl.EditValue);


            DevExpress.XtraEditors.XtraMessageBox.Show($"Yorum: {yorum}\nPuan: {puan}",
                "Gönderildi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                DevExpress.Utils.DefaultBoolean.True);
        }


        private void TxtYorum_Click(object sender, EventArgs e)
        {
            if (txtYorum.EditValue.ToString() == "Yorumunuzu buraya yazın...")
            {
                txtYorum.EditValue = string.Empty;
                txtYorum.ForeColor = Color.Black;
            }
        }


        private void TxtYorum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYorum.EditValue.ToString()))
            {
                txtYorum.EditValue = "Yorumunuzu buraya yazın...";
                txtYorum.ForeColor = Color.Gray;
            }
        }
    }
}
