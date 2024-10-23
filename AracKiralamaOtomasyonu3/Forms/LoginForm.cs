using System;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load);  // Form yüklendiğinde çağrılır
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Test kullanıcılarını veritabanına ekliyoruz
            using (var context = new AracKiralamaContext())
            {
                if (!context.Kullanicilar.Any())
                {
                    var musteri = new Kullanici
                    {
                        Ad = "Ahmet",
                        Soyad = "Yılmaz",
                        Email = "ahmet@example.com",
                        Sifre = "12345",  // Not: Güçlü şifreleme kullanılmalı
                        Rol = "Musteri"
                    };

                    var kiralayan = new Kullanici
                    {
                        Ad = "Mehmet",
                        Soyad = "Kaya",
                        Email = "mehmet@example.com",
                        Sifre = "12345",  // Not: Güçlü şifreleme kullanılmalı
                        Rol = "Kiralayan"
                    };

                    context.Kullanicilar.Add(musteri);
                    context.Kullanicilar.Add(kiralayan);
                    context.SaveChanges();
                }
            }
        }

        // Şifre göster/gizle butonuna tıklandığında çalışacak olay
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;  // Şifreyi göster/gizle
        }

        // Giriş butonuna tıklandığında çalışacak kod
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Giriş bilgilerini al
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email ve şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı ile kullanıcıyı kontrol et
            using (var context = new AracKiralamaContext())
            {
                var kullanici = context.Kullanicilar
                    .FirstOrDefault(k => k.Email == email && k.Sifre == password);

                if (kullanici != null)
                {
                    // Kullanıcı bulundu, rolüne göre yönlendirme
                    if (kullanici.Rol == "Musteri")
                    {
                        MessageBox.Show("Müşteri olarak giriş yapıldı!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriForm musteriForm = new MusteriForm(kullanici.KullaniciId);
                        musteriForm.Show();
                        this.Hide();  // Giriş ekranını gizle
                    }
                    else if (kullanici.Rol == "Kiralayan")
                    {
                        MessageBox.Show("Kiralayan olarak giriş yapıldı!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KiralayanForm kiralayanForm = new KiralayanForm(kullanici.KullaniciId);
                        kiralayanForm.Show();
                        this.Hide();  // Giriş ekranını gizle
                    }
                }
                else
                {
                    // Kullanıcı bulunamadıysa hata mesajı göster
                    MessageBox.Show("Email veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // txtEmail TextBox'ına odaklanıldığında placeholder silinir
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = System.Drawing.Color.Black;
            }
        }

        // txtEmail TextBox'ından çıkıldığında placeholder geri gelir
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = System.Drawing.Color.Gray;
            }
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
        // Email textBox değiştiğinde çalışacak event
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Buraya istediğin mantığı ekleyebilirsin, örneğin anlık doğrulama yapılabilir
        }

        // Şifre textBox değiştiğinde çalışacak event
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Buraya da şifre kontrolü veya başka mantık ekleyebilirsin
        }


        // Kayıt ol butonuna tıklandığında yeni bir kayıt formu açabilir ya da kayıt işlemi yapılabilir
        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt olma formu gösterilecek!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Buraya kayıt olma işlemleri ya da yeni form açılması eklenebilir
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
         
        }


    }
}
