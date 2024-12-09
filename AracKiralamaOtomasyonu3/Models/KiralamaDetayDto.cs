using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class KiralamaDetayDto
    {
        public string AracModel { get; set; }
        public string Plaka { get; set; }
        public DateTime KiralamaTarihi { get; set; }
        public string TeslimTarihi { get; set; }
        public string Fiyat { get; set; }

    }
}