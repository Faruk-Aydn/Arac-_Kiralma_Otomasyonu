using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Bakim
    {
        public int BakimId { get; set; }
        public int AracId { get; set; }
        public DateTime BakimTarihi { get; set; }
        public string Aciklama { get; set; }

        public virtual Arac Arac { get; set; }
    }

}
