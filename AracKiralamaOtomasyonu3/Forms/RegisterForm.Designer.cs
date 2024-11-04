using System.Drawing;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private ComboBox cmbRol;
        private Button btnTogglePassword;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRol;

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

            this.BackColor = Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Kayıt Ol";
            this.Font = new Font("Arial", 10);

            // Bileşenleri Başlatma
            this.txtAd = new TextBox();
            this.txtSoyad = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnRegister = new Button();
            this.cmbRol = new ComboBox();
            this.btnTogglePassword = new Button();
            this.lblAd = new Label();
            this.lblSoyad = new Label();
            this.lblEmail = new Label();
            this.lblPassword = new Label();
            this.lblRol = new Label();

            // Form Özellikleri
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Text = "Kayıt Ol";
            this.Font = new System.Drawing.Font("Arial", 10);

            // Ad Label
            this.lblAd.Text = "Ad:";
            this.lblAd.Location = new System.Drawing.Point(50, 30);
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Ad TextBox
            this.txtAd.Location = new System.Drawing.Point(150, 30);
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Text = "Adınızı giriniz";
            this.txtAd.Enter += new System.EventHandler(this.RemoveText);
            this.txtAd.Leave += new System.EventHandler(this.AddText);

            // Soyad Label
            this.lblSoyad.Text = "Soyad:";
            this.lblSoyad.Location = new System.Drawing.Point(50, 70);
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Soyad TextBox
            this.txtSoyad.Location = new System.Drawing.Point(150, 70);
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.Text = "Soyadınızı giriniz";
            this.txtSoyad.Enter += new System.EventHandler(this.RemoveText);
            this.txtSoyad.Leave += new System.EventHandler(this.AddText);

            // Email Label
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(50, 110);
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Email TextBox
            this.txtEmail.Location = new System.Drawing.Point(150, 110);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Text = "Email adresinizi giriniz";
            this.txtEmail.Enter += new System.EventHandler(this.RemoveText);
            this.txtEmail.Leave += new System.EventHandler(this.AddText);

            // Password Label
            this.lblPassword.Text = "Şifre:";
            this.lblPassword.Location = new System.Drawing.Point(50, 150);
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Password TextBox
            this.txtPassword.Location = new System.Drawing.Point(150, 150);
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.RemoveText);
            this.txtPassword.Leave += new System.EventHandler(this.AddText);

            // Toggle Password Button
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.Location = new System.Drawing.Point(360, 150);
            this.btnTogglePassword.Size = new System.Drawing.Size(30, 22);
            this.btnTogglePassword.FlatStyle = FlatStyle.Flat;
            this.btnTogglePassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);

            // Rol Label
            this.lblRol.Text = "Rol:";
            this.lblRol.Location = new System.Drawing.Point(50, 190);
            this.lblRol.AutoSize = true;
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);

            // Rol ComboBox
            this.cmbRol.Location = new System.Drawing.Point(150, 190);
            this.cmbRol.Size = new System.Drawing.Size(200, 22);
            this.cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRol.Items.AddRange(new object[] { "Müşteri", "Kiralayan" });

            // Register Button
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Location = new System.Drawing.Point(150, 230);
            this.btnRegister.Size = new System.Drawing.Size(200, 40);
            this.btnRegister.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            this.btnRegister.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Bileşenleri Forma Ekleme
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnRegister);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
