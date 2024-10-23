namespace AracKiralamaOtomasyonu3
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnTogglePassword;

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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Location = new System.Drawing.Point(150, 30);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Adınızı giriniz";
            this.txtAd.Enter += new System.EventHandler(this.RemoveText);
            this.txtAd.Leave += new System.EventHandler(this.AddText);
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.Location = new System.Drawing.Point(150, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "Soyadınızı giriniz";
            this.txtSoyad.Enter += new System.EventHandler(this.RemoveText);
            this.txtSoyad.Leave += new System.EventHandler(this.AddText);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(150, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email adresinizi giriniz";
            this.txtEmail.Enter += new System.EventHandler(this.RemoveText);
            this.txtEmail.Leave += new System.EventHandler(this.AddText);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(513, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 178);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Musteri",
            "Kiralayan"});
            this.cmbRol.Location = new System.Drawing.Point(150, 148);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(200, 24);
            this.cmbRol.TabIndex = 4;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Location = new System.Drawing.Point(828, 172);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(40, 39);
            this.btnTogglePassword.TabIndex = 5;
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.UseVisualStyleBackColor = true;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 453);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnTogglePassword);
            this.Name = "RegisterForm";
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
