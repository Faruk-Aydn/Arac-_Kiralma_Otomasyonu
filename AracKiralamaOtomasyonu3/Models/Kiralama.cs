using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AracKiralamaOtomasyonu3.Models
{
     public class Kiralama
    {
        [Key]
        public int KiralamaId { get; set; }
        public DateTime KiralamaTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }  // Teslim edilip edilmediğini kontrol edeceğiz

        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public int AracId { get; set; }
        public virtual  Arac Arac { get; set; }
   

    }
}