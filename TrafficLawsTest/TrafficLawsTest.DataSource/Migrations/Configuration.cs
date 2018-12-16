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

            context.TestParts.Add(CreateTestPart(3, seq++, "70 ��/�", "50 ��/�", "90 ��/�", "110 ��/�"));
            context.TestParts.Add(CreateTestPart(4, seq++, "������ �", "�,� � �", "���", "������ �"));
            context.TestParts.Add(CreateTestPart(4, seq++, "������ �������� ���������� �", "������ �������� ���������� �", "���", "����� �� �������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "� � �", "� � �", "� � �", "� � �"));
            context.TestParts.Add(CreateTestPart(4, seq++, "110 ��/�", "60 ��/�", "70 ��/�", "90 ��/�"));
            context.TestParts.Add(CreateTestPart(3, seq++, "� � �", "� � �", "������ �", "� ����� �� ���������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "10 �", "5 �", "15 �", "20 �"));
            context.TestParts.Add(CreateTestPart(4, seq++, "������ ��������", "������ ���������", "���������� � ��������", "������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "����� � ������", "����� � � �������� �����������", "������ �����", "� ����� �����������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "� � �", "������ �", "���", "������ �"));
            context.TestParts.Add(CreateTestPart(2, seq++, "� ������ ����, ��� ��������� ����� ������", "� ����������� � �������� �����, ����������� ������������ ������", "� ������ �������� ������� ������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "���������, ���� �� ���������� � ������������ ������ ����", "���������", "���������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "������� ������ ��� ������� ���������� ����� ��", "������ �", "�������", "�� �������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "�������� ���������� ������", "�������� ������ ������ ���������", "�������� ������ ������ ��������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "������ ����������� �� ������������� � ��������� ����������", "����������� ������", "������� �� ���������� ������� ������ ����������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "�� ������ �������", "�� ����� �������", "�� ����� ��������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "������", "�����", "�����, ���� �������� �������� �� ��������� 30 ��/���"));
            context.TestParts.Add(CreateTestPart(3, seq++, "���", "������ �", "� � �"));
            context.TestParts.Add(CreateTestPart(3, seq++, "����� ��� ������", "������ ������", "�����, ������ ��� � �������� �����������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "� ��������� ������ ���������� �������� ����� �������� ���������", "� � �", "������ �"));
            context.TestParts.Add(CreateTestPart(1, seq++, "������", "�� ������", "������ ������ � ������� �� �������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "�� ����� �� ���������", "������ �� �", "������ �"));
            context.TestParts.Add(CreateTestPart(3, seq++, "����� ������ � ������� ����� �����", "������", "�����"));
            context.TestParts.Add(CreateTestPart(1, seq++, "���������", "���������", "��������� ������ ��� ������� ����������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "����� �����������", "������ ��������� ����������", "������ ��������� ����������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "������ ������� �", "����� ��������", "������ ������� �"));
            context.TestParts.Add(CreateTestPart(2, seq++, "������ �������� ������ ��������� ���������� � ��������", "������ �������� ������ ������ ��������", "������ ������������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "������ �������� ��������� ����������", "���", "������ �������� ����������", "����� �� ��������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "���������� �������� ������������ ����������", "����������� ������������� ���������", "����� �������� ������� �� ���������� ��"));
            context.TestParts.Add(CreateTestPart(1, seq++, "� ������������ � � �", "�� ���� ������������, ����� �", "������ � ����������� �"));
            context.TestParts.Add(CreateTestPart(3, seq++, "������ ��������", "������� ������� ������", "������� ������ � ��������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "� ����� �����������", "������ � � �������� �����������", "������ ������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "����� ������������, ��� ��� �� ���������� �������� �����������", "�� ������ ��������� ������ ������������ �� ������ ������ ����", "����� ������������, ��������� ��������� �����"));
            context.TestParts.Add(CreateTestPart(1, seq++, "����������� ��� ��������� ������ �� ����� 100 �", "����������� ", "�����������"));
            context.TestParts.Add(CreateTestPart(1, seq++, "������ �� �", "������ �� �", "������������ ��� ��������� ������ �� ����� 100 �"));
            context.TestParts.Add(CreateTestPart(1, seq++, "�����������", "�����������", "����������� ������ ��� ������� ��� ������� ����������"));
            context.TestParts.Add(CreateTestPart(2, seq++, "������ � � �������� �����������", "� �����", "������ �� ����"));
            context.TestParts.Add(CreateTestPart(1, seq++, "�������� ������ �������", "�������� ������, �������������� ������ �������� �������", "�������� ������, �������������� �������� ���������"));
            context.TestParts.Add(CreateTestPart(3, seq++, "������", "������", "������ ��������� ����������"));
            context.TestParts.Add(CreateTestPart(1, seq, "�������, ���� �� �������� ���� ��������� ���������", "�������", "�� �������"));
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
			context.Users.Add(CreateUser("������� ���������� �������", "������� ���������� �������"));
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