namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTestReference : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserTests", "TestId", "dbo.Tests");
            DropIndex("dbo.UserTests", new[] { "TestId" });
            DropColumn("dbo.UserTests", "TestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTests", "TestId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserTests", "TestId");
            AddForeignKey("dbo.UserTests", "TestId", "dbo.Tests", "Id", cascadeDelete: true);
        }
    }
}
