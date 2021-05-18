namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DichVus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 128),
                        TenDV = c.String(),
                        Gia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DichVus");
        }
    }
}
