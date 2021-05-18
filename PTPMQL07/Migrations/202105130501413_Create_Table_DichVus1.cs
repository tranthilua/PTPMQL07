namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DichVus1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DichVus");
            AlterColumn("dbo.DichVus", "MaDV", c => c.String());
            AlterColumn("dbo.DichVus", "TenDV", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.DichVus", "Gia", c => c.String());
            AddPrimaryKey("dbo.DichVus", "TenDV");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.DichVus");
            AlterColumn("dbo.DichVus", "Gia", c => c.Int(nullable: false));
            AlterColumn("dbo.DichVus", "TenDV", c => c.String());
            AlterColumn("dbo.DichVus", "MaDV", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.DichVus", "MaDV");
        }
    }
}
