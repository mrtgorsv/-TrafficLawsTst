using System.Linq;
using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.Security;
using TrafficLawsTest.ViewModels;

namespace TrafficLawsTest.Presenters
{
    public interface ITestPresenter
    {
        void LoadTestId(int? testId = null);
        TestQuestionViewModel CurrentQuestion { get; set; }
        void NextQuestion();
        void PrevQuestion();

        bool IsLast { get; }
        bool IsFirst { get; }
    }

    public class TestPresenter : ITestPresenter
    {
        private readonly ISecurityManager _securityManager;

        private readonly ITestService _testService;

        private TestViewModel _test;

        private TestQuestionViewModel _currentQuestion;

        public TestPresenter(ISecurityManager securityManager, ITestService testService)
        {
            _securityManager = securityManager;
            _testService = testService;
        }

        public TestQuestionViewModel CurrentQuestion
        {
            get { return _currentQuestion; }
            set { _currentQuestion = value; }
        }

        public bool IsLast => _test?.Questions?.IndexOf(_currentQuestion) == 0;
        public bool IsFirst => _test?.Questions?.IndexOf(_currentQuestion) + 1 == _test?.Questions?.Count;

        public void NextQuestion()
        {
            if (_currentQuestion == null) return;
            if (IsLast)
            {
                return;
            }
            var next = _test.Questions.IndexOf(_currentQuestion) + 1;
            _currentQuestion = _test.Questions[next];
        }

        public void PrevQuestion()
        {
            if (_currentQuestion == null) return;
            if (IsFirst)
            {
                return;
            }
            var next = _test.Questions.IndexOf(_currentQuestion) - 1;
            _currentQuestion = _test.Questions[next];
        }


        public void LoadTestId(int? testId = null)
        {
            var test = testId.HasValue
                ? _testService.Get(testId.Value)
                : _testService.Get();

            _test = new TestViewModel
            {
                Questions = test.TestParts.Select(tp => new TestQuestionViewModel()
                {
                    Seq = tp.Seq,
                    Content = tp.Image,
                    Answers = tp.Answers.Select(ta => new AnswerViewModel()
                    {
                        Seq = ta.AnswerNumber,
                        Text = ta.Text,
                        IsCorrect = tp.CorrectAnswer.Equals(ta.AnswerNumber)
                    }).ToList()
                }).ToList()
            };

            _currentQuestion = _test.Questions.FirstOrDefault();
        }
    }
}