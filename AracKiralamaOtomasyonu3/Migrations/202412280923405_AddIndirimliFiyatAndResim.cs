namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndirimliFiyatAndResim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "IndirimliFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Aracs", "IndirimResmi", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "IndirimResmi");
            DropColumn("dbo.Aracs", "IndirimliFiyat");
        }
    }
}
