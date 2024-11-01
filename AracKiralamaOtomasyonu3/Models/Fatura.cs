using System;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Fatura
    {
        public int FaturaId { get; set; }
        public int KiralamaId { get; set; }  // Kiralama ile ilişki
        public decimal Tutar { get; set; }
        public DateTime FaturaTarihi { get; set; }

        public virtual Kiralama Kiralama { get; set; }
    }
}

