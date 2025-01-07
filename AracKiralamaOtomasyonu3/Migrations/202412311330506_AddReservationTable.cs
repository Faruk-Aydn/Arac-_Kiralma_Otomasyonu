namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        RezervasyonId = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        RezervasyonTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        Durum = c.String(),
                    })
                .PrimaryKey(t => t.RezervasyonId)
                .ForeignKey("dbo.Aracs", t => t.AracId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.AracId)
                .Index(t => t.KullaniciId);
            
            AddColumn("dbo.Aracs", "Durum", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.Rezervasyons", "AracId", "dbo.Aracs");
            DropIndex("dbo.Rezervasyons", new[] { "KullaniciId" });
            DropIndex("dbo.Rezervasyons", new[] { "AracId" });
            DropColumn("dbo.Aracs", "Durum");
            DropTable("dbo.Rezervasyons");
        }
    }
}
