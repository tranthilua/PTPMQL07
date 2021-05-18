namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Khachhangsss : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.KhachHangs", "TenKh");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String(nullable: false, maxLength: 128, fixedLength: true));
            AddPrimaryKey("dbo.KhachHangs", "TenKh");
        }
    }
}
