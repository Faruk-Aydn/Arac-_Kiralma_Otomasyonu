using AracKiralamaOtomasyonu3.DAL;
using AracKiralamaOtomasyonu3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu3.BLL
{
    public class KiralamaService
    {
        private AracKiralamaContext _context;

        public KiralamaService()
        {
            _context = new AracKiralamaContext();
        }

        private bool BakimKontrolu(int aracId)
        {
            using (var context = new AracKiralamaContext())
            {
                var sonBakim = context.Bakimlar
                    .Where(b => b.AracId == aracId)
                    .OrderByDescending(b => b.BakimTarihi)
                    .FirstOrDefault();

                if (sonBakim != null && sonBakim.BakimTarihi.AddMonths(6) < DateTime.Now)
                {
                    MessageBox.Show("Bu aracın bakım zamanı geldi.", "Bakım Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        // Dinamik fiyat hesaplama metodu
        private decimal DinamikFiyatHesapla(decimal temelFiyat, DateTime kiralamaTarihi)
        {
            decimal fiyat = temelFiyat;

            // Tatil günlerini belirleyin (Örnek olarak sabit tatil günleri eklendi)
            List<DateTime> tatilGunleri = new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1),  // Yılbaşı
                new DateTime(DateTime.Now.Year, 5, 1),  // İşçi Bayramı
                new DateTime(DateTime.Now.Year, 7, 15), // Demokrasi Günü
                new DateTime(DateTime.Now.Year, 10, 29), // Cumhuriyet Bayramı
                new DateTime(DateTime.Now.Year, 8, 30) // Zafer bayramı 
                // Diğer tatil günleri buraya eklenebilir
            };

            // Hafta sonu kontrolü
            if (kiralamaTarihi.DayOfWeek == DayOfWeek.Saturday || kiralamaTarihi.DayOfWeek == DayOfWeek.Sunday)
            {
                fiyat *= 1.2m; // %20 artış
            }

            // Tatil günlerine denk geliyorsa fiyat artışı uygula
            if (tatilGunleri.Contains(kiralamaTarihi.Date))
            {
                fiyat *= 1.3m; // %30 artış
            }

            return fiyat;
        }

        // Araç kiralama işlemi
        public void AracKirala(int aracId, int musteriId, DateTime kiralamaBaslangic, int kiralamaSuresi, decimal temelFiyat)
        {
            if (!BakimKontrolu(aracId)) return; // Bakım zamanı gelmişse kiralama yapılmaz

            decimal toplamFiyat = 0;

            // Dinamik fiyatı günlere göre hesapla
            for (int i = 0; i < kiralamaSuresi; i++)
            {
                var gun = kiralamaBaslangic.AddDays(i);
                toplamFiyat += DinamikFiyatHesapla(temelFiyat, gun);
            }

            // Yeni kiralama işlemi oluştur
            Kiralama yeniKiralama = new Kiralama
            {
                AracId = aracId,
                KullaniciId = musteriId,
                KiralamaTarihi = DateTime.Now,
                TeslimTarihi = null,
                Fiyat = toplamFiyat // Dinamik fiyatlandırılmış toplam fiyat
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
                    TeslimTarihi = k.TeslimTarihi.HasValue ? k.TeslimTarihi.Value.ToString("dd/MM/yyyy") : "Henüz İade Edilmedi",
                    Fiyat = k.Fiyat.ToString("C") // Fiyatı formatlı olarak göster
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
