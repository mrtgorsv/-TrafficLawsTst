using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Security;

namespace TrafficLawsTest.Logic.Services
{
    public interface IUserTestService
    {
        void AddUserResult(int reuslt , int testId);
    }

    public class UserTestService : IUserTestService
    {
        private readonly IDomainContext _domainContext;
        private readonly ISecurityManager _securityManager;

        public UserTestService(IDomainContext domainContext, ISecurityManager securityManager)
        {
            _domainContext = domainContext;
            _securityManager = securityManager;
        }

        public void AddUserResult(int reuslt, int testId)
        {
            var newTestResult = _domainContext.UserTests.Create();

            newTestResult.TestId = testId;
            newTestResult.UserId = _securityManager.CurrentPrincipal.Id;

            newTestResult.Result = reuslt;

            _domainContext.UserTests.Add(newTestResult);
            _domainContext.SaveChanges();
        }
    }
}
