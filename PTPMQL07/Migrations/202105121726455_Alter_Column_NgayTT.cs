namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_NgayTT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HoaDons", "NgayTT", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HoaDons", "NgayTT", c => c.Int(nullable: false));
        }
    }
}
