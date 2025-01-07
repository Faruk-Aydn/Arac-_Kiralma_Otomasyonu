namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewFieldsToArac : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aracs", "Marka", c => c.String());
            AddColumn("dbo.Aracs", "Yil", c => c.Int(nullable: false));
            AddColumn("dbo.Aracs", "Renk", c => c.String());
            AddColumn("dbo.Aracs", "YakitCinsi", c => c.String());
            AddColumn("dbo.Aracs", "Kilometre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aracs", "Kilometre");
            DropColumn("dbo.Aracs", "YakitCinsi");
            DropColumn("dbo.Aracs", "Renk");
            DropColumn("dbo.Aracs", "Yil");
            DropColumn("dbo.Aracs", "Marka");
        }
    }
}
