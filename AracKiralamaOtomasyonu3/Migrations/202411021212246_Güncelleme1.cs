namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Güncelleme1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "Resim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "Resim");
        }
    }
}
