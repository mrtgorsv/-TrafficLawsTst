using System.Collections.Generic;
using System.Linq;
using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.ViewModels;

namespace TrafficLawsTest.Presenters
{
    public interface ITestPresenter
    {
        void LoadTest(int? testId = null);
        TestQuestionViewModel CurrentQuestion { get; set; }
        void NextQuestion();
        void PrevQuestion();

        bool IsLast { get; }
        bool IsFirst { get; }
        string GetAnswerText(int index);
    }

    public class TestPresenter : ITestPresenter
    {
        private readonly IUserTestService _userTestService;
        private readonly ITestService _testService;

        private List<TestQuestionViewModel> _questions;

        private TestQuestionViewModel _currentQuestion;

        public TestPresenter(IUserTestService userTestService, ITestService testService)
        {
            _userTestService = userTestService;
            _testService = testService;
        }

        public TestQuestionViewModel CurrentQuestion
        {
            get { return _currentQuestion; }
            set { _currentQuestion = value; }
        }

        public bool IsFirst => _questions?.IndexOf(_currentQuestion) == 0;
        public bool IsLast => _questions?.IndexOf(_currentQuestion) + 1 == _questions?.Count;

        public string GetAnswerText(int index)
        {
            return _currentQuestion?.Answers[index]?.Text;
        }

        public void NextQuestion()
        {
            if (_currentQuestion == null) return;
            if (IsLast)
            {
                return;
            }

            var next = _questions.IndexOf(_currentQuestion) + 1;
            _currentQuestion = _questions[next];
        }

        public void PrevQuestion()
        {
            if (_currentQuestion == null) return;
            if (IsFirst)
            {
                return;
            }

            var next = _questions.IndexOf(_currentQuestion) - 1;
            _currentQuestion = _questions[next];
        }


        public void LoadTest(int? testId = null)
        {
            var testParts = _testService.Get();


            _questions = testParts.Select(tp => new TestQuestionViewModel()
            {
                Seq = tp.Seq,
                Content = tp.Image,
                Answers = tp.Answers.Select(ta => new AnswerViewModel()
                {
                    Seq = ta.AnswerNumber,
                    Text = ta.Text
                }).ToList()
            }).ToList();

            _currentQuestion = _questions.FirstOrDefault();
        }


        public void SaveResult()
        {
            var result = _questions.Count(q => q.CorrectAnswer.Equals(q.UserAnswer));
            _userTestService.AddUserResult(result);
        }
    }
}