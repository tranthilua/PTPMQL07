namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_BaoCaos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaoCao",
                c => new
                    {
                        DTNgay = c.String(nullable: false, maxLength: 128),
                        DTThang = c.String(),
                        DTNam = c.String(),
                    })
                .PrimaryKey(t => t.DTNgay);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BaoCao");
        }
    }
}
