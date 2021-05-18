namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lualua : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NhanVien1s");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NhanVien1s",
                c => new
                    {
                        MaNV = c.Int(nullable: false, identity: true),
                        HoNV = c.String(),
                        TenNV = c.String(),
                        ChucVu = c.String(),
                        SoCMT = c.Int(nullable: false),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
    }
}
