namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFaturaTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        FaturaId = c.Int(nullable: false, identity: true),
                        KiralamaId = c.Int(nullable: false),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaId)
                .ForeignKey("dbo.Kiralamas", t => t.KiralamaId, cascadeDelete: true)
                .Index(t => t.KiralamaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faturas", "KiralamaId", "dbo.Kiralamas");
            DropIndex("dbo.Faturas", new[] { "KiralamaId" });
            DropTable("dbo.Faturas");
        }
    }
}
