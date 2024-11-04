namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracResimEkleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "Resim", c => c.Binary());
            DropColumn("dbo.Aracs", "ImageBase64");
            DropColumn("dbo.Kiralamas", "ImageBase64");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralamas", "ImageBase64", c => c.String());
            AddColumn("dbo.Aracs", "ImageBase64", c => c.String());
            DropColumn("dbo.Aracs", "Resim");
        }
    }
}
