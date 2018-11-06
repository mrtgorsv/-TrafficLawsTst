using System;
using System.Windows.Forms;
using TrafficLawsTest.Controls;
using TrafficLawsTest.Presenters;
using TrafficLawsTest.Security;
using TrafficLawsTest.Utils.IoC;
using TrafficLawsTest.Views.About;

namespace TrafficLawsTest
{
    public partial class MainWindow : Form
    {
        private readonly IMainPresenter _mainPresenter;
        private readonly ISecurityManager _securityManager;

        public MainWindow(IMainPresenter mainPresenter, ISecurityManager securityManager)
        {
            _mainPresenter = mainPresenter;
            _securityManager = securityManager;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = _mainPresenter.Title;

            AboutApplicationButton.Click += OnAboutApplicationButtonClicked;
            AboutTrafficLawsButton.Click += OnAboutTrafficLawsButtonClicked;
        }

        private void OnAboutTrafficLawsButtonClicked(object sender, EventArgs e)
        {
            var form = new AboutTrafficLawsForm();
            form.ShowDialog(this);
        }

        private void OnAboutApplicationButtonClicked(object sender, EventArgs e)
        {
            var form = new AboutApplicationForm();
            form.ShowDialog(this);
        }

        public void Init()
        {
            if (_securityManager.Authorized)
            {
                UserLabel.Text = _securityManager.CurrentPrincipal.Name;
                EditTestButton.Visible = _securityManager.CheckRole(Roles.Admin);
            }

            ShowStartPanel();

            Show();
        }

        private void OnShowStatistic(object sender, EventArgs e)
        {
            ShowStatisticPanel();
        }

        private void OnStartTest(object sender, EventArgs e)
        {
            ShowTest();
        }

        private void ShowStartPanel()
        {
            var startContent = DiFactory.Resolve<StartUserControl>();
            startContent.StartTest += OnStartTest;
            startContent.ShowStatistic += OnShowStatistic;
            ShowContent(startContent);
        }

        private void ShowTest()
        {
            var test = DiFactory.Resolve<TestUserControl>();
            test.ExitTest += (sndr, args) => { ShowStartPanel(); };
            ShowContent(test);
        }

        private void ShowStatisticPanel()
        {
            var statistic = DiFactory.Resolve<StatisticUserControl>();
            ShowContent(statistic);
        }

        private void ShowContent(Control content)
        {
            ContentPanel.Controls.Clear();
            content.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(content);
        }
    }
}
