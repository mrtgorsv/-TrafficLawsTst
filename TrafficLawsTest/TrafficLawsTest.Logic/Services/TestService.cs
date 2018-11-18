using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.Logic.Services
{
    public interface ITestService
    {
        List<TestPart> Get();
        void Update(Test test);
    }

    /// <summary>
    /// Класс сервис для работы к тестами
    /// </summary>
    public class TestService : ITestService
    {
        private readonly IDomainContext _domainContext;
        public TestService(IDomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        /// <summary>
        /// Функция, для получения списка вопросов теста
        /// </summary>
        public List<TestPart> Get()
        {
            return _domainContext.TestParts
                .Include(t => t.Answers)
                .ToList();
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
