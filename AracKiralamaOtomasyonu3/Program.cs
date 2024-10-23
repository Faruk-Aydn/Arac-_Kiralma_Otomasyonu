using System;
using System.Linq;
using System.Windows.Forms;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;

namespace AracKiralamaOtomasyonu3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanı başlangıç kullanıcılarını ekleyin
            using (var context = new AracKiralamaContext())
            {
                if (!context.Kullanicilar.Any())
                {
                    var musteri = new Kullanici { Ad = "Ahmet", Soyad = "Yılmaz", Email = "ahmet@example.com", Sifre = "12345", Rol = "Musteri" };
                    var kiralayan = new Kullanici { Ad = "Mehmet", Soyad = "Kaya", Email = "mehmet@example.com", Sifre = "12345", Rol = "Kiralayan" };

                    context.Kullanicilar.Add(musteri);
                    context.Kullanicilar.Add(kiralayan);
                    context.SaveChanges();
                }
            }

            Application.Run(new LoginForm());  // Giriş formunu başlat
        }
    }
}
