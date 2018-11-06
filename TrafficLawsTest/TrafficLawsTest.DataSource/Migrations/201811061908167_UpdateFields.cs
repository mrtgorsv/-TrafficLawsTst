namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TestParts", "CorrectAnswer", c => c.Int(nullable: false));
            DropColumn("dbo.TestPartAnswers", "ImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestPartAnswers", "ImagePath", c => c.String());
            AlterColumn("dbo.TestParts", "CorrectAnswer", c => c.String());
        }
    }
}
