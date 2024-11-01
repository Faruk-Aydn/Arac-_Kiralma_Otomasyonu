namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Güncelleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralamas", "KiralamaTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Kiralamas", "TeslimTarihi", c => c.DateTime());
            DropColumn("dbo.Kiralamas", "BaslangicTarihi");
            DropColumn("dbo.Kiralamas", "BitisTarihi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralamas", "BitisTarihi", c => c.DateTime(nullable: false));
            AddColumn("dbo.Kiralamas", "BaslangicTarihi", c => c.DateTime(nullable: false));
            DropColumn("dbo.Kiralamas", "TeslimTarihi");
            DropColumn("dbo.Kiralamas", "KiralamaTarihi");
        }
    }
}
