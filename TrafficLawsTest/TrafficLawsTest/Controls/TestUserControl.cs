using System;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;
using TrafficLawsTest.Utils;

namespace TrafficLawsTest.Controls
{
    public partial class TestUserControl : UserControl
    {
        private readonly ITestPresenter _testPresenter;

        public event EventHandler ExitTest;

        public TestUserControl(ITestPresenter testPresenter)
        {
            _testPresenter = testPresenter;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _testPresenter.LoadTest();
            UpdateQuestion();
            PrevButton.Click += OnPrevButtonClicked;
            NextButton.Click += OnNextButtonClicked;
            CancelTestButton.Click += OnExitButtonClicked;
        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            OnExitTest();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            _testPresenter.NextQuestion();
            UpdateQuestion();
        }

        private void OnPrevButtonClicked(object sender, EventArgs e)
        {
            _testPresenter.PrevQuestion();
            UpdateQuestion();
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
            FirstAnswer.Text = _testPresenter.GetAnswerText(0);
            SecondAnswer.Text = _testPresenter.GetAnswerText(1);
            ThirdAnswer.Text = _testPresenter.GetAnswerText(2);
            FourAnswer.Text = _testPresenter.GetAnswerText(3);
        }

        private void UpdateImage()
        {
            TestImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TestImageBox.Image = _testPresenter.CurrentQuestion.Content.ToImage();
        }

        protected virtual void OnExitTest()
        {
            ExitTest?.Invoke(this, EventArgs.Empty);
        }
    }
}
