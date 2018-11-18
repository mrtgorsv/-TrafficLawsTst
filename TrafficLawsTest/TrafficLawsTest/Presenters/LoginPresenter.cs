using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface ILoginPresenrer
    {
        string Title { get; }
        bool TryLogIn(string login);
    }

    /// <summary>
    /// Класс презентер для представления формы входа в приложения
    /// Описывают логику данного представления
    /// </summary>
    public class LoginPresenter : ILoginPresenrer
    {
        /// Класса хранящий информация о текщем пользователе
        private readonly ISecurityManager _securityManager;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public LoginPresenter(ISecurityManager securityManager)
        {
            _securityManager = securityManager;
        }

        /// <summary>
        /// Заголовок формы
        /// </summary>
        public string Title => "Вход";

        /// <summary>
        /// Функция попытки входа в приложения
        /// </summary>
        public bool TryLogIn(string login)
        {
            return _securityManager.TryLogIn(login);
        }
    }
}