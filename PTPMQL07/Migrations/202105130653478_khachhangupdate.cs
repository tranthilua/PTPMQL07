namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khachhangupdate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AddColumn("dbo.KhachHangs", "IDKH", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String());
            AddPrimaryKey("dbo.KhachHangs", "IDKH");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "TenKh", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.KhachHangs", "IDKH");
            AddPrimaryKey("dbo.KhachHangs", "TenKh");
        }
    }
}
