namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_NgayDi_NgayDen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ThuePhongs", "NgayDen", c => c.String());
            AlterColumn("dbo.ThuePhongs", "NgayDi", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ThuePhongs", "NgayDi", c => c.Int(nullable: false));
            AlterColumn("dbo.ThuePhongs", "NgayDen", c => c.Int(nullable: false));
        }
    }
}
