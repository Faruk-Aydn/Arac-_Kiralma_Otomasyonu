namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralamas", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kiralamas", "Fiyat");
        }
    }
}
