namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Customers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NgayDen", c => c.String());
            AddColumn("dbo.Customers", "NgayDi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NgayDi");
            DropColumn("dbo.Customers", "NgayDen");
        }
    }
}
