using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Arac
    {
        public int AracId { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public bool BakimDurumu { get; set; }
        // Yeni eklenen özellik
        public bool KiralandiMi { get; set; }  // Araç kiralandı mı?

        public decimal  Fiyat { get; set; }  // Araçların fiyatı

        public DateTime? BakimTarihi { get; set; }  // Nullable Bakım Tarihi

        public ICollection<Kiralama> Kiralamalar { get; set; }
    }
}
