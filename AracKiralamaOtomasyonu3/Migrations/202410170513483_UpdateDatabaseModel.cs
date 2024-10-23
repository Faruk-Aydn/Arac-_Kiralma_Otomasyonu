namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "Fiyat");
        }
    }
}
