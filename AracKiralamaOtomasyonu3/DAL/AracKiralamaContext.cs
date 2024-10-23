using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AracKiralamaOtomasyonu3.Models;
using System.Data.Entity;

namespace AracKiralamaOtomasyonu3.DAL
{
    public class AracKiralamaContext : DbContext
    {
        public AracKiralamaContext() : base("name=AracKiralamaDb")
        {
        }
       

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
    }
}
