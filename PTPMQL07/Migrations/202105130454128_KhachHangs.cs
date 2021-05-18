namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhachHangs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DichVus");
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.DichVus", "MaDV", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String(nullable: false, maxLength: 128, fixedLength: true));
            AddPrimaryKey("dbo.DichVus", "MaDV");
            AddPrimaryKey("dbo.KhachHangs", "TenKh");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            DropPrimaryKey("dbo.DichVus");
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.DichVus", "MaDV", c => c.String(nullable: false, maxLength: 128, fixedLength: true));
            AddPrimaryKey("dbo.KhachHangs", "TenKh");
            AddPrimaryKey("dbo.DichVus", "MaDV");
        }
    }
}
