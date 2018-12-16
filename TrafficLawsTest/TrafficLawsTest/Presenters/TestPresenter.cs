using System.Collections.Generic;
using System.Linq;
using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.ViewModels;

namespace TrafficLawsTest.Presenters
{
    /// <summary>
    /// Класс презентер для представления теста ПДД
    /// Описывают логику данного представления
    /// </summary>
    public interface ITestPresenter
    {
        void LoadTest(int? testId = null);
        TestQuestionViewModel CurrentQuestion { get; set; }
        void NextQuestion();
        void PrevQuestion();

        bool IsLast { get; }
        bool IsFirst { get; }
        bool TestComplete { get; }
        string GetAnswerText(int index);
        string[] SaveResult();
    }

    /// <summary>
    /// Класс презентер содержащий логику формы теста
    /// </summary>
    public class TestPresenter : ITestPresenter
    {
        private readonly IUserTestService _userTestService;
        private readonly ITestService _testService;

        // Список вопросов текущего теста
        private List<TestQuestionViewModel> _questions;

        // Текущий вопрос теста
        private TestQuestionViewModel _currentQuestion;

        /// <summary>
        /// Конструктор презентера
        /// </summary>
        /// <param name="userTestService"></param>
        /// <param name="testService"></param>
        public TestPresenter(IUserTestService userTestService, ITestService testService)
        {
            _userTestService = userTestService;
            _testService = testService;
        }

        // Текущий вопрос теста
        public TestQuestionViewModel CurrentQuestion
        {
            get { return _currentQuestion; }
            set { _currentQuestion = value; }
        }

        // Свойство-флаг, указывающий, что вопрос первый
        public bool IsFirst => _questions?.IndexOf(_currentQuestion) == 0;

        // Свойство-флаг, указывающее, что все вопросы выбраны
        public bool TestComplete
        {
            get { return _questions.All(q => q.UserAnswer != 0); }
        }

        // Свойство-флаг, указывающий, что вопрос последний
        public bool IsLast => _questions?.IndexOf(_currentQuestion) + 1 == _questions?.Count;

        /// <summary>
        /// Метод возвращающий текст ответа на вопрос
        /// </summary>
        /// <param name="index"> Индекс ответа</param>
        /// <returns></returns>
        public string GetAnswerText(int index)
        {
            // Если вопрос не выбран или такого номера ответа нет в списке ответов, то возвращаем null
            if (_currentQuestion == null || _currentQuestion.Answers.Count <= index)
            {
                return null;
            }
            return _currentQuestion.Answers[index].Text;
        }

        /// <summary>
        /// Метод перехода к следующему вопросу
        /// </summary>
        public void NextQuestion()
        {
            if (_currentQuestion == null) return;
            // если вопрос последний , то переходить некуда
            if (IsLast)
            {
                return;
            }

            var next = _questions.IndexOf(_currentQuestion) + 1;
            _currentQuestion = _questions[next];
        }

        /// <summary>
        /// Метод перехода к предыдущему вопросу
        /// </summary>
        public void PrevQuestion()
        {
            if (_currentQuestion == null) return;
            // если вопрос первый , то переходить некуда
            if (IsFirst)
            {
                return;
            }

            var next = _questions.IndexOf(_currentQuestion) - 1;
            _currentQuestion = _questions[next];
        }


        /// <summary>
        /// Метод для загрузки списка вопросов текущего теста
        /// </summary>
        /// <remarks>
        /// На данный момент тест один
        /// </remarks>
        /// <param name="testId">Идентификатор теста</param>
        public void LoadTest(int? testId = null)
        {
            // Загрузка данных из бд
            var testParts = _testService.Get();

            // Преобразование моделей базы данных в модели представления
            _questions = testParts.Select(tp => new TestQuestionViewModel()
            {
                Seq = testParts.IndexOf(tp) + 1,
                Content = tp.Image,
                CorrectAnswer = tp.CorrectAnswer,
                Answers = tp.Answers.Select(ta => new AnswerViewModel()
                {
                    Seq = ta.AnswerNumber,
                    Text = ta.Text
                }).ToList()
            }).ToList();

            // Текущим вопросом устанавливается первый из загруженного списка
            _currentQuestion = _questions.FirstOrDefault();
        }

        /// <summary>
        /// Метод сохраняющий результат теста в базе данных
        /// </summary>
        /// <returns>Возвращает коллекцию строк, содержащих информации о том, верно ли ответил пользователь на каждый из вопросов</returns>
        public string[] SaveResult()
        {
            // число правильных ответок
            var result = _questions.Count(q => q.IsCorrect);

            // сохранение результата в базе данных
            _userTestService.AddUserResult(result , _questions.Count);

            // преобразование вопросов в строку, информирующую о том верно ли ответил пользователь на них
            var resultList = _questions.Select(q => $"{q.Name} - {q.CorrectString}").ToList();
            // Добавление результирующей строки по всем вопросам
            resultList.Add($"Всего правильных ответов: {result} из { _questions.Count}");
            return resultList.ToArray();
        }
    }
}