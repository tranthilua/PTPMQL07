namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien1s : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NhanViens", newName: "NhanVien1s");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.NhanVien1s", newName: "NhanViens");
        }
    }
}
