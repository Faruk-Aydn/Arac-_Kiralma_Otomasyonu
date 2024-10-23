using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System.Collections.Generic;


namespace AracKiralamaOtomasyonu3.BLL
{
    public class AracService
    {
        private AracKiralamaContext _context;

        public AracService()
        {
            _context = new AracKiralamaContext();
        }
        public Kullanici GirisYap(string email, string sifre)
        {
            return _context.Kullanicilar
                .FirstOrDefault(k => k.Email == email && k.Sifre == sifre);
        }

        public List<Arac> TumAraclariGetir()
        {
            return _context.Araclar.ToList();
        }

        public List<Arac> KiralanabilirAraclariGetir()
        {
            // Kiralanmamış (KiralandiMi == false) araçları getir
            return _context.Araclar
                           .Where(arac => !arac.KiralandiMi)
                           .ToList();
        }

        public void AracEkle(Arac arac)
        {
            _context.Araclar.Add(arac);
            _context.SaveChanges();
        }

        public void AracSil(int aracId)
        {
            var arac = _context.Araclar.Find(aracId);
            if (arac != null)
            {
                _context.Araclar.Remove(arac);
                _context.SaveChanges();
            }
        }

        public void AracGuncelle(Arac arac)
        {
            var mevcutArac = _context.Araclar.Find(arac.AracId);
            if (mevcutArac != null)
            {
                mevcutArac.Model = arac.Model;
                mevcutArac.Plaka = arac.Plaka;
                mevcutArac.BakimDurumu = arac.BakimDurumu;
                _context.SaveChanges();
            }
        }
    }
}
