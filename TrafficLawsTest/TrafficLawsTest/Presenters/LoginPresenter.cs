using System;
using System.IO;
using System.Linq;
using System.Text;
using TrafficLawsTest.Security;
using TrafficLawsTest.Security.Services;

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
        private readonly IUserService _userService;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public LoginPresenter(ISecurityManager securityManager, IUserService userService)
        {
            _securityManager = securityManager;
            _userService = userService;
            LoadExternalUsers();
        }

        private void LoadExternalUsers()
        {
            const string userDataFile = "users_data.txt";
            var file = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, userDataFile, SearchOption.AllDirectories)
                .FirstOrDefault();
            if (file != null)
            {
                _userService.LoadUsers(File.ReadAllLines(file ,Encoding.UTF8));
            }
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