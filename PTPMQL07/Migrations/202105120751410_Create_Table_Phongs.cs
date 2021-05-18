namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Phongs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128, fixedLength: true),
                        TenPhong = c.String(),
                        GiaPhong = c.String(),
                        LoaiPhong = c.String(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phongs");
        }
    }
}
