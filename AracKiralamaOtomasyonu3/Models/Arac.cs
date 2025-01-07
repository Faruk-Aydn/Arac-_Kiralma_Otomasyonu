using System;
using System.Collections.Generic;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Arac
    {
        public int AracId { get; set; } // Araç ID

        public string Marka { get; set; } // Marka bilgisi

        public string Model { get; set; } // Model bilgisi

        public string Plaka { get; set; } // Araç plakası

        public int Yil { get; set; } // Üretim yılı

        public string Renk { get; set; } // Araç rengi

        public string YakitCinsi { get; set; } // Yakıt türü (Benzin, Dizel, Elektrik vb.)

        public int Kilometre { get; set; } // Araç kilometresi

        public bool BakimDurumu { get; set; } 

        public byte[] Resim { get; set; } 

        public bool KiralandiMi { get; set; } 

        public decimal Fiyat { get; set; }
        public string Durum { get; set; }

        public DateTime? BakimTarihi { get; set; } 
        public decimal IndirimliFiyat { get; set; } 
        public byte[] IndirimResmi { get; set; } 

        public ICollection<Kiralama> Kiralamalar { get; set; } 

        public virtual ICollection<AracFotograf> FotografListesi { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }
    }
}
