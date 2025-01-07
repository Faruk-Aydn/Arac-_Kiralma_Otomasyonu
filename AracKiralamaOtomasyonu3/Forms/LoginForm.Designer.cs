using System.Drawing;

namespace AracKiralamaOtomasyonu3
{
    partial class LoginForm
    {
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnTogglePassword;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.PanelControl panelLeft;
        private DevExpress.XtraEditors.PanelControl panelRight;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraEditors.LabelControl lblAracKiralama;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblAracKiralama = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnTogglePassword = new DevExpress.XtraEditors.SimpleButton();
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.panelRight = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
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
            this.lblTitle.Location = new System.Drawing.Point(150, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Appearance.Options.UseForeColor = true;
            this.txtEmail.Properties.NullText = "E-posta ";
            this.txtEmail.Size = new System.Drawing.Size(280, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = "Password";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic);
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Location = new System.Drawing.Point(86, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegister.Appearance.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic);
            this.btnRegister.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Appearance.Options.UseBackColor = true;
            this.btnRegister.Appearance.Options.UseFont = true;
            this.btnRegister.Appearance.Options.UseForeColor = true;
            this.btnRegister.Location = new System.Drawing.Point(86, 302);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(250, 40);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Location = new System.Drawing.Point(357, 200);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(31, 22);
            this.btnTogglePassword.TabIndex = 3;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.Click += new System.EventHandler(this.BtnTogglePassword_Click);
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
            this.panelLeft.TabIndex = 1;
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
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.btnTogglePassword);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.btnRegister);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 500);
            this.panelRight.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
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