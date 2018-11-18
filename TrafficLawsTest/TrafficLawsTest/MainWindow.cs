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
        /// Класса хранящий информация о текщем пользователе
        private readonly ISecurityManager _securityManager;
        public event EventHandler Next;
        public event EventHandler Prev;

        public MainWindow(IMainPresenter mainPresenter, ISecurityManager securityManager)
        {
            _mainPresenter = mainPresenter;
            _securityManager = securityManager;
            InitializeComponent();
        }

        /// <summary>
        /// Переопределение обработчика события загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = _mainPresenter.Title;

            AboutPointSystemButton.Click += OnAboutPointSystemButtonClicked;
            AboutTrafficLawsButton.Click += OnAboutTrafficLawsButtonClicked;
            AboutApplicationMenuButton.Click += OnAboutApplicationMenuButtonClicked;
            AboutAuthorMenuItem.Click += OnAboutAuthorMenuItemClicked;
            ChangeOpacity();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку меню "Об авторе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAboutAuthorMenuItemClicked(object sender, EventArgs e)
        {
            var form = new AboutAuthorForm();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку меню "О приложении"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAboutApplicationMenuButtonClicked(object sender, EventArgs e)
        {
            var form = new AboutApplicationForm();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку меню "Что такое ПДД"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAboutTrafficLawsButtonClicked(object sender, EventArgs e)
        {
            var form = new AboutTrafficLawsForm();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку меню "Оценочная система"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAboutPointSystemButtonClicked(object sender, EventArgs e)
        {
            var form = new AboutPointSystemForm();
            form.ShowDialog(this);
        }

        /// <summary>
        /// ФУнкция установки начальных параметров
        /// </summary>
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

        /// <summary>
        /// ФУнкция отображения формы статистики
        /// </summary>
        private void OnShowStatistic(object sender, EventArgs e)
        {
            ShowStatisticPanel();
        }

        /// <summary>
        /// ФУнкция отображения формы старта теста
        /// </summary>
        private void OnStartTest(object sender, EventArgs e)
        {
            ShowTest();
        }

        /// <summary>
        /// ФУнкция отображения начальной формы
        /// </summary>
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
            test.CompleteTest += (sndr, args) => { ShowStartPanel(); };
            ShowContent(test);
        }

        /// <summary>
        /// ФУнкция установки начальных параметров
        /// </summary>
        private void ShowStatisticPanel()
        {
            var statistic = DiFactory.Resolve<StatisticUserControl>();
            statistic.Back += (sndr, args) => { ShowStartPanel(); };
            ShowContent(statistic);
        }

        private void ShowContent(Control content)
        {
            ContentPanel.Controls.Clear();
            content.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(content);
            ContentPanel.Focus();
        }

        private void ChangeOpacity()
        {
            double opacity = 0.00;
            while (opacity < 1)
            {
                Opacity = opacity;
                opacity += 0.05;
                System.Threading.Thread.Sleep(25);
            }

            Opacity = 1.00;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    AboutApplicationMenuButton.PerformClick();
                    break;
                case Keys.Left:
                    OnPrev();
                    return true;
                case Keys.Right:
                    OnNext();
                    return true;
            }
            return true;
        }

        protected virtual void OnNext()
        {
            Next?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnPrev()
        {
            Prev?.Invoke(this, EventArgs.Empty);
        }
    }
}