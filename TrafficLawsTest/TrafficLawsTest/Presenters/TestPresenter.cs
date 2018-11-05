using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface ITestPresenter
    {
    }

    public class TestPresenter : ITestPresenter
    {
        private readonly ISecurityManager _securityManager;

        public TestPresenter(ISecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

    }
}