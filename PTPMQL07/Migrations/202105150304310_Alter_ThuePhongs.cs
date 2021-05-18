namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_ThuePhongs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ThuePhongs");
            AddColumn("dbo.ThuePhongs", "TenPhong", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.ThuePhongs", "ViTri", c => c.String());
            AddColumn("dbo.ThuePhongs", "Loai", c => c.String());
            AddColumn("dbo.ThuePhongs", "Gia", c => c.String());
            AddPrimaryKey("dbo.ThuePhongs", "TenPhong");
            DropColumn("dbo.ThuePhongs", "MaKh");
            DropColumn("dbo.ThuePhongs", "MaPhong");
            DropColumn("dbo.ThuePhongs", "SoLuong");
            DropColumn("dbo.ThuePhongs", "NgayDen");
            DropColumn("dbo.ThuePhongs", "NgayDi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ThuePhongs", "NgayDi", c => c.String());
            AddColumn("dbo.ThuePhongs", "NgayDen", c => c.String());
            AddColumn("dbo.ThuePhongs", "SoLuong", c => c.String());
            AddColumn("dbo.ThuePhongs", "MaPhong", c => c.String());
            AddColumn("dbo.ThuePhongs", "MaKh", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.ThuePhongs");
            DropColumn("dbo.ThuePhongs", "Gia");
            DropColumn("dbo.ThuePhongs", "Loai");
            DropColumn("dbo.ThuePhongs", "ViTri");
            DropColumn("dbo.ThuePhongs", "TenPhong");
            AddPrimaryKey("dbo.ThuePhongs", "MaKh");
        }
    }
}
