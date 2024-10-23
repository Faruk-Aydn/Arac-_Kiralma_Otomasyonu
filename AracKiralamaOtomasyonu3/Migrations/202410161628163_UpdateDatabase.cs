namespace AracKiralamaOtomasyonu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kullanicis", "Ad", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Kullanicis", "Soyad", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Kullanicis", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Kullanicis", "Sifre", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Kullanicis", "Rol", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kullanicis", "Rol", c => c.String());
            AlterColumn("dbo.Kullanicis", "Sifre", c => c.String());
            AlterColumn("dbo.Kullanicis", "Email", c => c.String());
            AlterColumn("dbo.Kullanicis", "Soyad", c => c.String());
            AlterColumn("dbo.Kullanicis", "Ad", c => c.String());
        }
    }
}
