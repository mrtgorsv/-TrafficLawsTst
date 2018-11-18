using System;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;

namespace TrafficLawsTest.Views
{
    public partial class LoginForm : Form
    {
        private readonly ILoginPresenrer _loginPresenrer;

        public event EventHandler Logined;

        public LoginForm(ILoginPresenrer loginPresenrer)
        {
            _loginPresenrer = loginPresenrer;
            InitializeComponent();
        }

        /// <summary>
        /// Переопределение обработчика события загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoginButton.Click += OnLogin;
            Text = _loginPresenrer.Title;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            if (_loginPresenrer.TryLogIn(LoginTextBox.Text))
            {
                OnLogined();
            }
        }

        protected virtual void OnLogined()
        {
            Logined?.Invoke(this, EventArgs.Empty);
        }
    }
}
