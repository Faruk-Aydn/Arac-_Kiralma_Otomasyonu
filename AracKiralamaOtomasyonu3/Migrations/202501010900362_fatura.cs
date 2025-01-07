namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fatura : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Faturas", "FaturaTarihi", c => c.DateTime());
            AlterColumn("dbo.Faturas", "OdemeTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Faturas", "OdemeTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Faturas", "FaturaTarihi", c => c.DateTime(nullable: false));
        }
    }
}
