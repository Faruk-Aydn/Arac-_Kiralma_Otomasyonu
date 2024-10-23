using System;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;  // Modelleri dahil ediyoruz

namespace AracKiralamaOtomasyonu3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEmail.Text;
            string sifre = txtPassword.Text;
            string rol = cmbRol.SelectedItem.ToString();

            // Basit doğrulama
            if (string.IsNullOrEmpty(ad) || ad == "Adınızı giriniz" ||
                string.IsNullOrEmpty(soyad) || soyad == "Soyadınızı giriniz" ||
                string.IsNullOrEmpty(email) || email == "Email adresinizi giriniz" ||
                string.IsNullOrEmpty(sifre) || sifre == "Şifrenizi giriniz")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            // Yeni kullanıcıyı kaydet
            using (var context = new AracKiralamaContext())
            {
                var yeniKullanici = new Kullanici
                {
                    Ad = ad,
                    Soyad = soyad,
                    Email = email,
                    Sifre = sifre,
                    Rol = rol,
                };

                context.Kullanicilar.Add(yeniKullanici);
                context.SaveChanges();
            }

            MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Kayıt ekranını kapat ve LoginForm'u göster
            this.Close();  // Kayıt formunu kapat
            LoginForm loginForm = new LoginForm();
            loginForm.Show();  // Giriş ekranını aç
        }
        // txtPassword TextBox'ına odaklanıldığında placeholder silinir
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;  // Şifreyi gizlemek için
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }
        }


        // txtPassword TextBox'ından çıkıldığında placeholder geri gelir
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
        // Şifre textBox değiştiğinde çalışacak event
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Buraya da şifre kontrolü veya başka mantık ekleyebilirsin
        }



        // Şifre göster/gizle butonuna tıklandığında çalışacak olay
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;  // Şifreyi göster/gizle
        }
        // Placeholder işlevselliği için event'ler
        private void RemoveText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.ForeColor == System.Drawing.Color.Gray)
            {
                txt.Text = "";
                txt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt.Name == "txtAd")
                    txt.Text = "Adınızı giriniz";
                else if (txt.Name == "txtSoyad")
                    txt.Text = "Soyadınızı giriniz";
                else if (txt.Name == "txtEmail")
                    txt.Text = "Email adresinizi giriniz";
                else if (txt.Name == "txtPassword")
                    txt.Text = "Şifrenizi giriniz";

                txt.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
