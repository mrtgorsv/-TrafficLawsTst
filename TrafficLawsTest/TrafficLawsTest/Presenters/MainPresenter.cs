using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface IMainPresenter
    {
        string Title { get; }
        bool TryLogIn(string login, string password);
    }

    public class MainPresenter : IMainPresenter
    {
        private readonly ISecurityManager _securityManager;

        public MainPresenter(ISecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

        public string Title => "Тест ПДД";

        public bool TryLogIn(string login, string password)
        {
            return _securityManager.TryLogIn(login, password);
        }
    }
}