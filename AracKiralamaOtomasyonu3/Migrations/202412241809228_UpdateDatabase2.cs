namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Faturas", "MusteriAdi", c => c.Int(nullable: false));
            AddColumn("dbo.Faturas", "OdemeTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faturas", "OdemeTarihi");
            DropColumn("dbo.Faturas", "MusteriAdi");
        }
    }
}
