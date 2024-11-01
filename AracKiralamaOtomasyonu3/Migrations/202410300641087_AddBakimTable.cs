namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBakimTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bakims",
                c => new
                    {
                        BakimId = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        BakimTarihi = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.BakimId)
                .ForeignKey("dbo.Aracs", t => t.AracId, cascadeDelete: true)
                .Index(t => t.AracId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bakims", "AracId", "dbo.Aracs");
            DropIndex("dbo.Bakims", new[] { "AracId" });
            DropTable("dbo.Bakims");
        }
    }
}
