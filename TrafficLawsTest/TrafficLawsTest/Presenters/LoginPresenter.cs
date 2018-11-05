using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface ILoginPresenrer
    {
        string Title { get; }
        bool TryLogIn(string login, string password);
    }

    public class LoginPresenter : ILoginPresenrer
    {
        private readonly ISecurityManager _securityManager;

        public LoginPresenter(ISecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

        public string Title => "Вход";

        public bool TryLogIn(string login, string password)
        {
            return _securityManager.TryLogIn(login, password);
        }
    }
}