namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dene : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rezervasyons", "BaslangicTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rezervasyons", "BaslangicTarihi");
        }
    }
}
