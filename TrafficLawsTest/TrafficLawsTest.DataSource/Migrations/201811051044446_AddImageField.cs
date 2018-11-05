namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestParts", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestParts", "Image");
        }
    }
}
