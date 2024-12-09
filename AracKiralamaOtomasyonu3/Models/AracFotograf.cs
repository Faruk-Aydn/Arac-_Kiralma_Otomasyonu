using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AracKiralamaOtomasyonu3.Models
{
    public class AracFotograf
    {
        [Key]
        public int FotografId { get; set; }
        public int AracId { get; set; }
        [Required]
        public byte[] FotoData { get; set; }

        public virtual Arac Arac { get; set; }
    }
}