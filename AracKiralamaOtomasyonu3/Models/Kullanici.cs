using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        [Required]
        [StringLength(100)]
        public string Ad { get; set; }

        [Required]
        [StringLength(100)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Sifre { get; set; }

        [Required]
        public string Rol { get; set; }  // "Musteri" veya "Kiralayan"
    }
}

