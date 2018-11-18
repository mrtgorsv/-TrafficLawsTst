using System;
using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Security;

namespace TrafficLawsTest.Logic.Services
{
    /// <summary>
    /// Интерфейс сервиса работы с тестами пользователей
    /// </summary>
    public interface IUserTestService
    {
        void AddUserResult(int reuslt, int total);
        string[] GetResults();
    }

    /// <summary>
    /// Класс сервис для работы с результатами тестов пользователей
    /// </summary>
    public class UserTestService : IUserTestService
    {
        private readonly IDomainContext _domainContext;
        /// Класса хранящий информация о текщем пользователе
        private readonly ISecurityManager _securityManager;

        public UserTestService(IDomainContext domainContext, ISecurityManager securityManager)
        {
            _domainContext = domainContext;
            _securityManager = securityManager;
        }

        /// <summary>
        /// Функция, добавляющая запись о тестирования пользователя
        /// </summary>
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

        /// <summary>
        /// Функция, возвращающая результаты тестирования пользователя
        /// </summary>
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
