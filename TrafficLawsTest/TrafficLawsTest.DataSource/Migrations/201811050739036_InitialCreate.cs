namespace TrafficLawsTest.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestPartAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestPartId = c.Int(nullable: false),
                        Text = c.String(),
                        ImagePath = c.String(),
                        Options = c.String(),
                        AnswerNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestParts", t => t.TestPartId, cascadeDelete: true)
                .Index(t => t.TestPartId);
            
            CreateTable(
                "dbo.TestParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seq = c.Int(nullable: false),
                        Description = c.String(),
                        CorrectAnswer = c.String(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seq = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        TestTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TestId = c.Int(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        Attempt = c.Int(nullable: false),
                        Result = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTests", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserTests", "TestId", "dbo.Tests");
            DropForeignKey("dbo.TestParts", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.TestPartAnswers", "TestPartId", "dbo.TestParts");
            DropIndex("dbo.UserTests", new[] { "TestId" });
            DropIndex("dbo.UserTests", new[] { "UserId" });
            DropIndex("dbo.TestParts", new[] { "Test_Id" });
            DropIndex("dbo.TestPartAnswers", new[] { "TestPartId" });
            DropTable("dbo.UserTests");
            DropTable("dbo.Users");
            DropTable("dbo.Tests");
            DropTable("dbo.TestParts");
            DropTable("dbo.TestPartAnswers");
        }
    }
}
