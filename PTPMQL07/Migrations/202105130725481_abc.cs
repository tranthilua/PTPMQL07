namespace PTPMQL07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MaKh", c => c.String());
            AlterColumn("dbo.Customers", "SoCMT", c => c.String());
            AlterColumn("dbo.Customers", "SoDT", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "SoDT", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "SoCMT", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "MaKh", c => c.Int(nullable: false));
        }
    }
}
