namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Güncelleme2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "ImageBase64", c => c.String());
            AddColumn("dbo.Kiralamas", "ImageBase64", c => c.String());
            DropColumn("dbo.Aracs", "Resim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aracs", "Resim", c => c.String());
            DropColumn("dbo.Kiralamas", "ImageBase64");
            DropColumn("dbo.Aracs", "ImageBase64");
        }
    }
}
