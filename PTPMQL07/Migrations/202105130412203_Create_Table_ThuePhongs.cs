namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ThuePhongs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ThuePhongs");
            AddColumn("dbo.ThuePhongs", "SoLuong", c => c.String());
            AlterColumn("dbo.ThuePhongs", "MaPhong", c => c.String());
            AlterColumn("dbo.ThuePhongs", "MaKh", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ThuePhongs", "MaKh");
            DropColumn("dbo.ThuePhongs", "SoLuongPhong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ThuePhongs", "SoLuongPhong", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.ThuePhongs");
            AlterColumn("dbo.ThuePhongs", "MaKh", c => c.String());
            AlterColumn("dbo.ThuePhongs", "MaPhong", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.ThuePhongs", "SoLuong");
            AddPrimaryKey("dbo.ThuePhongs", "MaPhong");
        }
    }
}
