namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
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
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
