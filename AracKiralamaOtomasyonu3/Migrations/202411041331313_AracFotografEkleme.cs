namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracFotografEkleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AracFotografs",
                c => new
                    {
                        FotografId = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        FotoData = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.FotografId)
                .ForeignKey("dbo.Aracs", t => t.AracId, cascadeDelete: true)
                .Index(t => t.AracId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AracFotografs", "AracId", "dbo.Aracs");
            DropIndex("dbo.AracFotografs", new[] { "AracId" });
            DropTable("dbo.AracFotografs");
        }
    }
}
