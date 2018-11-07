using System;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Security;

namespace TrafficLawsTest.Logic.Services
{
    public interface IUserTestService
    {
        void AddUserResult(int reuslt, int total);
        string[] GetResults();
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

        public void AddUserResult(int reuslt, int total)
        {
            var newTestResult = _domainContext.UserTests.Create();

            newTestResult.UserId = _securityManager.CurrentPrincipal.Id;

            newTestResult.Total = total;
            newTestResult.Result = reuslt;
            newTestResult.DateStamp = DateTime.Now;

            _domainContext.UserTests.Add(newTestResult);
            _domainContext.SaveChanges();
        }

        public string[] GetResults()
        {
            var userId = _securityManager.CurrentPrincipal.Id;
            return _domainContext.UserTests
                .Where(ut => ut.UserId.Equals(userId))
                .OrderByDescending(ut => ut.DateStamp)
                .ToArray()
                .Select(ut => $"{ut.DateStamp:G} - Результат: {ut.Result} из {ut.Total}")
                .ToArray();
        }
    }
}
