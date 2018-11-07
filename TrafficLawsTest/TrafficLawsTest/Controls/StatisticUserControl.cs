using System;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;

namespace TrafficLawsTest.Controls
{
    public partial class StatisticUserControl : UserControl
    {

        private readonly IStatisticPresenter _statisticPresenter;
        public event EventHandler Back;

        public StatisticUserControl(IStatisticPresenter statisticPresenter)
        {
            _statisticPresenter = statisticPresenter;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BackButton.Click += OnBackButtonClicked;
            TestStatisticListBox.DataSource = _statisticPresenter.GetResults();
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            OnBack();
        }

        protected virtual void OnBack()
        {
            Back?.Invoke(this, EventArgs.Empty);
        }
    }
}
