using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;




namespace AracKiralamaOtomasyonu3.BLL
{
    public class KiralamaService
    {
        private AracKiralamaContext _context;

        public KiralamaService()
        {
            _context = new AracKiralamaContext();
        }

        // Araç kiralama işlemi
        public void AracKirala(int aracId, int musteriId)
        {
            // Araç kiralama işlemi
            Kiralama yeniKiralama = new Kiralama
            {
                AracId = aracId,
                KullaniciId = musteriId,
                KiralamaTarihi = DateTime.Now,
                TeslimTarihi = null
            };

            // Aracı kiralanmış olarak işaretle
            var kiralananArac = _context.Araclar.Find(aracId);
            if (kiralananArac != null)
            {
                kiralananArac.KiralandiMi = true;  // Araç kiralandı
                _context.Kiralamalar.Add(yeniKiralama);
                _context.SaveChanges();  // Veritabanına kaydet
            }
        }

        // Müşterinin kiralama geçmişi
        public List<KiralamaDetayDto> MusteriKiralamaGecmisi(int musteriId)
        {
            using (var context = new AracKiralamaContext())
            {
                var kiralamaDetaylari = context.Kiralamalar
                    .Include(k => k.Arac)       // Aracı dahil et
                    .Include(k => k.Kullanici)  // Kullanıcıyı dahil et (navigation property)
                    .Where(k => k.KullaniciId == musteriId) // Müşteri ID'sine göre filtrele
                    .ToList();

                // Verileri işleyip döndürüyoruz
                return kiralamaDetaylari.Select(k => new KiralamaDetayDto
                {
                    AracModel = k.Arac.Model,
                    Plaka = k.Arac.Plaka,
                    KiralamaTarihi = k.KiralamaTarihi,
                    TeslimTarihi = k.TeslimTarihi.HasValue ? k.TeslimTarihi.Value.ToString("dd/MM/yyyy") : "Henüz İade Edilmedi"
                }).ToList();
            }
        }




        // Tüm kiralamaları getir (gerekirse)
        public List<Kiralama> TumKiralamalariGetir()
        {
            return _context.Kiralamalar.ToList();
        }
    }
}
