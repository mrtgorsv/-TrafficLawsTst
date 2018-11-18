using System.Collections.Generic;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;
using TrafficLawsTest.DataSource.Utils;

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

            if (context.TestParts.Count() < 10)
            {
                context.TestParts.RemoveRange(context.TestParts.ToList());
                context.SaveChanges();
                AddQuestions(context);
            }
        }

        private void AddQuestions(DomainContext context)
        {
            int seq = 1;

            context.TestParts.Add(CreateTestPart(3, seq++, "70 км/ч", "50 км/ч", "90 км/ч", "110 км/ч"));
            context.TestParts.Add(CreateTestPart(4, seq++, "Только Г", "Б,В и Г", "Все", "Только В"));
            context.TestParts.Add(CreateTestPart(4, seq++, "Только водитель автомобиля А", "Только водитель автомобиля Б", "Оба", "Никто не нарушил"));
            context.TestParts.Add(CreateTestPart(2, seq++, "А и В", "А и Г", "Б и В", "Б и Г"));
            context.TestParts.Add(CreateTestPart(4, seq++, "110 км/ч", "60 км/ч", "70 км/ч", "90 км/ч"));
            context.TestParts.Add(CreateTestPart(3, seq++, "А и В", "Б и В", "Только В", "В любом из указанных"));
            context.TestParts.Add(CreateTestPart(1, seq++, "10 м", "5 м", "15 м", "20 м"));
            context.TestParts.Add(CreateTestPart(4, seq++, "Только автобусу", "Только мотоциклу", "Легковушке и автобусу", "Никому"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Прямо и налево", "Прямо и в обратном направлении", "Только прямо", "В любом направлении"));
            context.TestParts.Add(CreateTestPart(1, seq, "Б и В", "Только В", "Все", "Только Б"));
        }

        private TestPart CreateTestPart(int correctAnswer, int seq, params string[] answers)
        {
            var question = new TestPart
            {
                CorrectAnswer = correctAnswer,
                Image = ImageLoader.FromAssembly($"Test_{seq:00}"),
                Seq = seq,
                Answers = new List<TestPartAnswer>()
            };

            for (int i = 0; i < answers.Length; i++)
            {
                question.Answers.Add(
                    new TestPartAnswer
                    {
                        TestPart = question,
                        AnswerNumber = i + 1,
                        Text = answers[i]
                    });
            }

            return question;
        }

        private void AddUsers(DomainContext context)
        {
            const string admin = "admin";
            const string test = "test";

            if (context.Users.Any(u => u.Login.Equals(admin)))
            {
                return;
            }

            var adminUser = new User
            {
                Login = admin,
                Password = admin,
                Roles = new List<Role>()
            };
            var testUser = new User
            {
                Login = test,
                Password = test,
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
            context.Users.Add(testUser);
            context.Roles.Add(adminRole);
        }
    }
}