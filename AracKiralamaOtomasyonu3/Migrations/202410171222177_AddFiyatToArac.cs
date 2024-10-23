namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFiyatToArac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "BakimTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "BakimTarihi");
        }
    }
}
