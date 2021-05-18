namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        TenKh = c.String(nullable: false, maxLength: 128),
                        MaKh = c.Int(nullable: false),
                        HoKh = c.String(),
                        SoCMT = c.Int(nullable: false),
                        SoDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TenKh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
