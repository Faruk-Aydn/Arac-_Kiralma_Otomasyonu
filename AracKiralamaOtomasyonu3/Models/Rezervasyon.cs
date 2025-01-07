using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int AracId { get; set; } 
        public int KullaniciId { get; set; } 
        public DateTime RezervasyonTarihi { get; set; } 
        public DateTime TeslimTarihi { get; set; } 
        public DateTime BaslangicTarihi { get; set; } 
        public string Durum { get; set; } 

      
        public virtual Arac Arac { get; set; } 
        public virtual Kullanici Kullanici { get; set; } 
    }

}
