using System.Data.Entity;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.Logic.Services
{
    public interface ITestService
    {
        Test Get();
        Test Get(int id);
        void Update(Test test);
    }

    public class TestService : ITestService
    {
        private readonly IDomainContext _domainContext;
        public TestService(IDomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        public Test Get()
        {
            return _domainContext.Tests
                .Include(t => t.TestParts)
                .Include(t => t.TestParts.Select(tp => tp.Answers))
                .FirstOrDefault();
        }

        public Test Get(int id)
        {
            return _domainContext.Tests
                .Include(t => t.TestParts)
                .Include(t => t.TestParts.Select(tp => tp.Answers))
                .FirstOrDefault(t =>t.Id == id);
        }

        public void Update(Test test)
        {
            _domainContext.Entry(test).State = EntityState.Modified;
            _domainContext.SaveChanges();
        }
    }
}
