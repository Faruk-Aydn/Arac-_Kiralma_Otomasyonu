using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;


namespace AracKiralamaOtomasyonu3.BLL
{
    public class KullaniciService
    {
        private AracKiralamaContext _context;

        public KullaniciService()
        {
            _context = new AracKiralamaContext();
        }

        public Kullanici GirisYap(string email, string sifre)
        {
            return _context.Kullanicilar
                .FirstOrDefault(k => k.Email == email && k.Sifre == sifre);
        }

        // Diğer kullanıcı işlemleri burada olabilir
   

    }
}