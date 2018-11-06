using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.DataSource.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TrafficLawsTest.DataSource.Context.DomainContext"; 
        }

        protected override void Seed(DomainContext context)
        {
            if (!context.Users.Any())
            {
                AddUsers(context);
            }
        }

        private void AddUsers(DomainContext context)
        {
            const string admin = "admin";
            if (context.Users.Any(u => u.Login.Equals(admin)))
            {
                
            }
            var adminUser = new User
            {
                Login = admin,
                Password = admin,
                Roles = new List<Role>()
            };
            var adminRole = new Role
            {
                Name = admin,
                Users = new List<User>()
            };
            adminRole.Users.Add(adminUser);
            adminUser.Roles.Add(adminRole);
            context.Users.Add(adminUser);
            context.Roles.Add(adminRole);

            var firstQuestion = new TestPart
            {
                    CorrectAnswer = 3,
                    Image = LoadImage("Test_01"),
                    Seq = 0
                };
            firstQuestion.Answers = new List<TestPartAnswer>
            {
                new TestPartAnswer
                {
                    TestPart = firstQuestion,
                    AnswerNumber = 1,
                    Text = "70 км / ч"
                },
                new TestPartAnswer
                {
                    TestPart = firstQuestion,
                    AnswerNumber = 2,
                    Text = "50 км / ч"
                },
                new TestPartAnswer
                {
                    TestPart = firstQuestion,
                    AnswerNumber = 3,
                    Text = "90 км / ч"
                },
                new TestPartAnswer
                {
                    TestPart = firstQuestion,
                    AnswerNumber = 4,
                    Text = "110 км / ч"
                }
            };


            var secondQuestion = new TestPart
            {
                CorrectAnswer = 4,
                Image = LoadImage("Test_02"),
                Seq = 1
            };

            secondQuestion.Answers = new List<TestPartAnswer>
            {
                new TestPartAnswer
                {
                    TestPart = secondQuestion,
                    AnswerNumber = 1,
                    Text = "Только Г"
                },
                new TestPartAnswer
                {
                    TestPart = secondQuestion,
                    AnswerNumber = 2,
                    Text = "Б,В и Г"
                },
                new TestPartAnswer
                {
                    TestPart = secondQuestion,
                    AnswerNumber = 3,
                    Text = "Все"
                },
                new TestPartAnswer
                {
                    TestPart = secondQuestion,
                    AnswerNumber = 4,
                    Text = "Только В"
                }
            };


            var thirdQuestion = new TestPart
            {
                CorrectAnswer = 4,
                Image = LoadImage("Test_03"),
                Seq = 1
            };

            thirdQuestion.Answers = new List<TestPartAnswer>
            {
                new TestPartAnswer
                {
                    TestPart = thirdQuestion ,
                    AnswerNumber = 1,
                    Text = "Только водитель автомобиля А"
                },
                new TestPartAnswer
                {
                    TestPart = thirdQuestion ,
                    AnswerNumber = 2,
                    Text = "Только водитель автомобиля Б"
                },
                new TestPartAnswer
                {
                    TestPart = thirdQuestion ,
                    AnswerNumber = 3,
                    Text = "Оба"
                },
                new TestPartAnswer
                {
                    TestPart = thirdQuestion ,
                    AnswerNumber = 4,
                    Text = "Никто не нарушил"
                }
            };

            context.TestParts.Add(firstQuestion);
            context.TestParts.Add(secondQuestion);
            context.TestParts.Add(thirdQuestion);
        }

        private byte[] LoadImage(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.Contains(name));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null) return null;
                byte[] ba = new byte[stream.Length];
                stream.Read(ba, 0, ba.Length);
                return ba;
            }
        }
    }
}
