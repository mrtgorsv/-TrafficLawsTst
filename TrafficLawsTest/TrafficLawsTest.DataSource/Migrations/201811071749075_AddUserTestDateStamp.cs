namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTestDateStamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserTests", "DateStamp", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserTests", "StartTime");
            DropColumn("dbo.UserTests", "EndTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTests", "EndTime", c => c.DateTime());
            AddColumn("dbo.UserTests", "StartTime", c => c.DateTime());
            DropColumn("dbo.UserTests", "DateStamp");
        }
    }
}
