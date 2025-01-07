using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class KullaniciIndirimi
    {
        public int KullaniciIndirimiId { get; set; }
        public int UserId { get; set; } // İndirim hangi kullanıcıya ait
        public int DiscountId { get; set; } // Hangi indirim uygulandı
        public DateTime Tarih { get; set; } // İndirim uygulama tarihi
    }

}
