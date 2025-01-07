using System.Drawing;

namespace AracKiralamaOtomasyonu3
{
    partial class RegisterForm
    {
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRol;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.PanelControl panelLeft;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraEditors.PanelControl panelRight;
        private DevExpress.XtraEditors.LabelControl lblAracKiralama;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblAracKiralama = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.cmbRol = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAracKiralama
            // 
            this.lblAracKiralama.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblAracKiralama.Appearance.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.lblAracKiralama.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblAracKiralama.Appearance.Options.UseBackColor = true;
            this.lblAracKiralama.Appearance.Options.UseFont = true;
            this.lblAracKiralama.Appearance.Options.UseForeColor = true;
            this.lblAracKiralama.Appearance.Options.UseTextOptions = true;
            this.lblAracKiralama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAracKiralama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblAracKiralama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAracKiralama.Location = new System.Drawing.Point(3, 371);
            this.lblAracKiralama.Name = "lblAracKiralama";
            this.lblAracKiralama.Size = new System.Drawing.Size(391, 100);
            this.lblAracKiralama.TabIndex = 0;
            this.lblAracKiralama.Text = "ARAÇ KİRALAMA";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(136, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(75, 100);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.NullText = "Ad";
            this.txtAd.Size = new System.Drawing.Size(250, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(75, 150);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.NullText = "Soyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseForeColor = true;
            this.txtEmail.Properties.NullText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = "Password";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // cmbRol
            // 
            this.cmbRol.Location = new System.Drawing.Point(75, 300);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRol.Properties.NullText = "Rol Seçiniz";
            cmbRol.Properties.Items.Add("Musteri");
            cmbRol.Properties.Items.Add("Kiralayan");

            this.cmbRol.Size = new System.Drawing.Size(250, 22);
            this.cmbRol.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(75, 350);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(250, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panelLeft.Appearance.Options.UseBackColor = true;
            this.panelLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelLeft.Controls.Add(this.lblAracKiralama);
            this.panelLeft.Controls.Add(this.pictureBox);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(400, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.EditValue = global::AracKiralamaOtomasyonu3.Properties.Resources.logo;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox.Size = new System.Drawing.Size(400, 500);
            this.pictureBox.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelRight.Appearance.Options.UseBackColor = true;
            this.panelRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Controls.Add(this.txtAd);
            this.panelRight.Controls.Add(this.txtSoyad);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.cmbRol);
            this.panelRight.Controls.Add(this.btnRegister);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 500);
            this.panelRight.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelRight)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
