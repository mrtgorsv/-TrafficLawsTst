using System.Collections.Generic;
using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.Security;

namespace TrafficLawsTest.Presenters
{
    public interface IEditTestPresenter
    {

        string Name { get; set; }

        byte[] Image { get; set; }

        void SetAnswerValue(int answer, string text);
        string GetAnswerValue(int answer);

        int CorrectAnswer { get; set; }

        void SetSelectedQuestion(int id);

        List<SelectItem> GetAvailableQuestions();

        bool Save();
    }

    /// <summary>
    /// Класс презентер для представления формы редактирования теста
    /// Описывают логику данного представления
    /// </summary>
    public class EditTestPresenter : IEditTestPresenter
    {
        /// Класса хранящий информация о текщем пользователе
        private readonly ISecurityManager _securityManager;
        private readonly ITestService _testService;

        public EditTestPresenter(ISecurityManager securityManager, ITestService testService)
        {
            _securityManager = securityManager;
            _testService = testService;
        }

        public string Name { get; set; }
        public byte[] Image { get; set; }
        public void SetAnswerValue(int answer, string text)
        {
            throw new System.NotImplementedException();
        }

        public string GetAnswerValue(int answer)
        {
            throw new System.NotImplementedException();
        }

        public int CorrectAnswer { get; set; }
        public void SetSelectedQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<SelectItem> GetAvailableQuestions()
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }
    }

    public class SelectItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}