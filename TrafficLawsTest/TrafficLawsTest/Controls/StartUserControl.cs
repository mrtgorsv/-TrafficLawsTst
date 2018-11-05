using System;
using System.Windows.Forms;

namespace TrafficLawsTest.Controls
{
    public partial class StartUserControl : UserControl
    {

        public event EventHandler StartTest;
        public event EventHandler ShowStatistic;
        public StartUserControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShowTestStatisticButton.Click += OnShowStatistic;
            StartTestButton.Click += OnStartTest;
        }

        protected virtual void OnStartTest(object sender, EventArgs eventArgs)
        {
            StartTest?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnShowStatistic(object sender, EventArgs eventArgs)
        {
            ShowStatistic?.Invoke(this, EventArgs.Empty);
        }
    }
}
