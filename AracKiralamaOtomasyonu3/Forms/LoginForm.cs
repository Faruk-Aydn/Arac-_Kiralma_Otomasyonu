using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoginForm_Load);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Test kullanıcılarını veritabanına ekle
            using (var context = new AracKiralamaContext())
            {
                if (!context.Kullanicilar.Any())
                {
                    var musteri = new Kullanici
                    {
                        Ad = "Ahmet",
                        Soyad = "Yılmaz",
                        Email = "ahmet@example.com",
                        Sifre = "12345",
                        Rol = "Musteri"
                    };

                    var kiralayan = new Kullanici
                    {
                        Ad = "Mehmet",
                        Soyad = "Kaya",
                        Email = "mehmet@example.com",
                        Sifre = "12345",
                        Rol = "Kiralayan"
                    };

                    context.Kullanicilar.Add(musteri);
                    context.Kullanicilar.Add(kiralayan);
                    context.SaveChanges();
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Email ve şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanında kullanıcıyı kontrol et
            using (var context = new AracKiralamaContext())
            {
                var kullanici = context.Kullanicilar
                    .FirstOrDefault(k => k.Email == email && k.Sifre == password);

                if (kullanici != null)
                {
                    if (kullanici.Rol == "Musteri")
                    {
                        XtraMessageBox.Show("Müşteri olarak giriş yapıldı!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusteriForm musteriForm = new MusteriForm(kullanici.KullaniciId);
                        musteriForm.Show();
                        this.Hide();
                    }
                    else if (kullanici.Rol == "Kiralayan")
                    {
                        XtraMessageBox.Show("Kiralayan olarak giriş yapıldı!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KiralayanForm kiralayanForm = new KiralayanForm(kullanici.KullaniciId);
                        kiralayanForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Email veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Kayıt olma formu gösterilecek!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void BtnTogglePassword_Click(object sender, EventArgs e)
        {
            // Şifre gizleme/gösterme
            if (txtPassword.Properties.PasswordChar == '*')
            {
                txtPassword.Properties.PasswordChar = '\0'; // Şifreyi göster
                btnTogglePassword.Text = "Şifreyi Gizle";
            }
            else
            {
                txtPassword.Properties.PasswordChar = '*'; // Şifreyi gizle
                btnTogglePassword.Text = "Şifreyi Göster";
            }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
           
                Application.Exit();
            
        }


    }
}
