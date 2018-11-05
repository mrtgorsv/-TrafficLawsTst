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
            throw new System.NotImplementedException();
        }

        public Test Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Test test)
        {
            throw new System.NotImplementedException();
        }
    }
}
