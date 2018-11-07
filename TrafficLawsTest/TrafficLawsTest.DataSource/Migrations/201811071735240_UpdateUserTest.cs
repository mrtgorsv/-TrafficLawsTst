namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserTests", "Total", c => c.Int(nullable: false));
            AlterColumn("dbo.UserTests", "Result", c => c.Int(nullable: false));
            DropColumn("dbo.UserTests", "IsCompleted");
            DropColumn("dbo.UserTests", "Attempt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTests", "Attempt", c => c.Int(nullable: false));
            AddColumn("dbo.UserTests", "IsCompleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.UserTests", "Result", c => c.Double(nullable: false));
            DropColumn("dbo.UserTests", "Total");
        }
    }
}
