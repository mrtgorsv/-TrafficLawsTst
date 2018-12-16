using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.Logic.Services
{
    public interface ITestService
    {
        List<TestPart> Get(int count = 20);
        void Update(Test test);
    }

    /// <summary>
    /// Класс сервис для работы к тестами
    /// </summary>
    public class TestService : ITestService
    {
        private static Random _rnd = new Random();
        private readonly IDomainContext _domainContext;
        public TestService(IDomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        /// <summary>
        /// Функция, для получения списка вопросов теста
        /// </summary>
        public List<TestPart> Get(int count = 20)
        {
            var testParts = _domainContext.TestParts
                .Include(t => t.Answers)
                .ToList();
            int takedCount = 0;
            List<TestPart> result = new List<TestPart>();
            while (takedCount < 20)
            {
                var next = _rnd.Next(testParts.Count);
                if (result.Contains(testParts[next])) continue;
                result.Add(testParts[next]);
                takedCount++;
            }

            return result;
        }

        /// <summary>
        /// Функция, для обновления теста
        /// </summary>
        public void Update(Test test)
        {
            _domainContext.Entry(test).State = EntityState.Modified;
            _domainContext.SaveChanges();
        }
    }
}
