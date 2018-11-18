using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface IStatisticPresenter
    {
        string[] GetResults();
        string Title { get; }
    }

    /// <summary>
    /// Класс презентер для представления статистики пользователя
    /// Описывают логику данного представления
    /// </summary>
    public class StatisticPresenter : IStatisticPresenter
    {
        private readonly IUserTestService _userTestService;
        /// Класса хранящий информация о текщем пользователе
        private readonly ISecurityManager _securityManager;


        public StatisticPresenter(IUserTestService userTestService, ISecurityManager securityManager)
        {
            _userTestService = userTestService;
            _securityManager = securityManager;
        }

        /// <summary>
        /// Функуия возвращающая результаты тестов текущего пользователя 
        /// </summary>
        /// <returns></returns>
        public string[] GetResults()
        {
            return _userTestService.GetResults();
        }

        // Заголовок формы
        public string Title => $"Предыдущие тестирования пользователя '{_securityManager?.CurrentPrincipal?.Name}'";
    }
}