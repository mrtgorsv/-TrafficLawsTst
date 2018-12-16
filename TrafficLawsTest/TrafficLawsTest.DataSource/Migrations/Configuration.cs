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
			AddUsers(context);
			if (context.TestParts.Count() < 40)
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
            context.TestParts.Add(CreateTestPart(1, seq++, "Б и В", "Только В", "Все", "Только Б"));
            context.TestParts.Add(CreateTestPart(2, seq++, "О начале зоны, где запрещены любые манёвры", "О приближении к сплошной линии, разделяющей транспортные потоки", "О начале опасного участка дороги"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Разрешено, если вы проживаете в обозначенной знаком зоне", "Разрешено", "Запрещено"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Обязаны только при наличии движущихся сзади тс", "Только В", "Обязаны", "Не обязаны"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Проехать перекрёсток первым", "Уступить дорогу только грузовику", "Уступить дорогу только автобусу"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Будете действовать по договорённости с водителем легковушки", "Развернётесь первым", "Выедете на перекрёсток уступив дорогу легковушке"));
            context.TestParts.Add(CreateTestPart(2, seq++, "На правом рисунке", "На левом рисунке", "На обоих рисунках"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Нельзя", "Можно", "Можно, если грузовик движется со скоростью 30 км/час"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Все", "Только А", "А и В"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Прямо или налево", "Только налево", "Прямо, налево или в обратном направлении"));
            context.TestParts.Add(CreateTestPart(3, seq++, "В указанных местах пересекать сплошную линию разметки запрещено", "А и Б", "Только Б"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Должны", "Не должны", "Должны только с заездом на тротуар"));
            context.TestParts.Add(CreateTestPart(1, seq++, "По любой из указанных", "Только по А", "Только Б"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Можно только в светлое время суток", "Нельзя", "Можно"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Разрешено", "Запрещено", "Разрешено только для высадки пассажиров"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Обоим автомобилям", "Только легковому автомобилю", "Только грузовому автомобилю"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Только трамваю Б", "Обоим трамваям", "Только трамваю А"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Должны уступить дорогу легковому автомобилю и автобусу", "Должны уступить дорогу только автобусу", "Имеете преимущество"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Только водитель грузового автомобиля", "Оба", "Только водитель легковушки", "Никто не нарушает"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Очерёдность движения регулируется светофором", "Отсутствует искусственное освещение", "Будет затруднён разъезд со встречными тс"));
            context.TestParts.Add(CreateTestPart(1, seq++, "В направлениях А и В", "Во всех направлениях, кроме Г", "Только в направлении В"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Только разворот", "ТТолько поворот налево", "Поворот налево и разворот"));
            context.TestParts.Add(CreateTestPart(1, seq++, "В любом направлении", "Налево и в обратном направлении", "Только налево"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Имеет преимущество, так как на автомобиле включены поворотники", "Не должен создавать помехи двигающемуся по правой полосе авто", "Имеет преимущество, поскольку завершает обгон"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Разрешается при видимости дороги не менее 100 м", "Разрешается ", "Запрещается"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Только по А", "Только по Б", "ТРазрешается при видимости дороги не менее 100 м"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Запрещается", "Разрешается", "Разрешается только для посадки или высадки пассажиров"));
            context.TestParts.Add(CreateTestPart(2, seq++, "Налево и в обратном направлении", "В любом", "Только на лево"));
            context.TestParts.Add(CreateTestPart(1, seq++, "Уступите дорогу трамваю", "Проедете первым, руководствуясь знаком “Главная дорога”", "Проедете первым, руководствуясь сигналом светофора"));
            context.TestParts.Add(CreateTestPart(3, seq++, "Никому", "Никому", "Только легковому автомобилю"));
            context.TestParts.Add(CreateTestPart(1, seq, "Нарушил, если не выставил знак аварийной остановки", "Нарушил", "Не нарушил"));
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

			context.Users.RemoveRange(context.Users.ToList());
			context.SaveChanges();

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
            context.Roles.Add(adminRole);
			context.Users.Add(CreateUser(test, test));

			context.Users.Add(CreateUser("user3", "user3"));
			context.Users.Add(CreateUser("Дмитрий Дмитриевич Дмитров", "Дмитрий Дмитриевич Дмитров"));
		}

        private User CreateUser(string name , string pass)
        {
			var newUser = new User
            {
                Login = name,
                Password = pass,
                Roles = new List<Role>()
            };
			return newUser;
        }
    }
}