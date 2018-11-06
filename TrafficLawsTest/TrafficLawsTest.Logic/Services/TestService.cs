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

    public class TestService : ITestService
    {
        private readonly IDomainContext _domainContext;
        public TestService(IDomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        public List<TestPart> Get()
        {
            return _domainContext.TestParts
                .Include(t => t.Answers)
                .ToList();
        }

        public void Update(Test test)
        {
            _domainContext.Entry(test).State = EntityState.Modified;
            _domainContext.SaveChanges();
        }
    }
}
