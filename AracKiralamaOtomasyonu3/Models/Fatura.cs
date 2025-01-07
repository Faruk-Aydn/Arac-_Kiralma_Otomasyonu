using System;

namespace AracKiralamaOtomasyonu3.Models
{
    public class Fatura
    {
        public int FaturaId { get; set; }
        public int MusteriAdi { get; set; }
        public int KiralamaId { get; set; }  
        public decimal Tutar { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public DateTime? OdemeTarihi { get; set; }

        public virtual Kiralama Kiralama { get; set; }
    }
}

