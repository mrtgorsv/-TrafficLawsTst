using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;
using TrafficLawsTest.Utils;

namespace TrafficLawsTest.Controls
{
    public partial class TestUserControl : UserControl
    {
        private readonly ITestPresenter _testPresenter;


        private readonly List<RadioButton> _answerButtons;

        public event EventHandler CompleteTest;

        public TestUserControl(ITestPresenter testPresenter)
        {
            _testPresenter = testPresenter;
            InitializeComponent();

            _answerButtons = new List<RadioButton>()
            {
                FirstAnswer,
                SecondAnswer,
                ThirdAnswer,
                FourAnswer
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _testPresenter.LoadTest();
            UpdateQuestion();
            PrevButton.Click += OnPrevButtonClicked;
            NextButton.Click += OnNextButtonClicked;
            CompleteTestButton.Click += OnCompleteButtonClicked;
        }

        private void OnCompleteButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            ShowResultForm(_testPresenter.SaveResult());
            OnCompleteTest();
        }

        private void ShowResultForm(string[] result)
        {
            var resultForm = new ResultForm();
            resultForm.SetResult(result);
            resultForm.ShowDialog(this);
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            _testPresenter.NextQuestion();
            UpdateQuestion();
        }

        private void OnPrevButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            _testPresenter.PrevQuestion();
            UpdateQuestion();
        }

        private void SaveSelection()
        {
            var checkedButton = _answerButtons
                .FirstOrDefault(r => r.Checked);

            _testPresenter.CurrentQuestion.UserAnswer = Convert.ToInt32(checkedButton?.Tag);
        }

        private void RefreshView()
        {
            PrevButton.Enabled = !_testPresenter.IsFirst;
            NextButton.Enabled = !_testPresenter.IsLast;
        }

        private void UpdateQuestion()
        {
            UpdateImage();
            SetAnswers();
            RefreshView();
        }

        private void SetAnswers()
        {
            FirstAnswer.Checked = false;
            SecondAnswer.Checked = false;
            ThirdAnswer.Checked = false;
            FourAnswer.Checked = false;

            FirstAnswer.Text = _testPresenter.GetAnswerText(0);;
            SecondAnswer.Text = _testPresenter.GetAnswerText(1);
            ThirdAnswer.Text = _testPresenter.GetAnswerText(2);
            FourAnswer.Text = _testPresenter.GetAnswerText(3);

            var answerButton = _answerButtons
                .FirstOrDefault(r => Convert.ToInt32(r.Tag).Equals(_testPresenter.CurrentQuestion.UserAnswer));
            if (answerButton != null)
            {
                answerButton.Checked = true;
            }
        }


        private void UpdateImage()
        {
            TestImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TestImageBox.Image = _testPresenter.CurrentQuestion.Content.ToImage();
        }

        protected virtual void OnCompleteTest()
        {
            CompleteTest?.Invoke(this, EventArgs.Empty);
        }
    }
}
