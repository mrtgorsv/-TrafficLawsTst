using System;
using System.Windows.Forms;

namespace TrafficLawsTest.Controls
{
    /// <summary>
    /// Пользовательский элемент начальной формы приложения
    /// </summary>
    public partial class StartUserControl : UserControl
    {

        /// Событие начала теста
        public event EventHandler StartTest;
        /// Событие отображения статистики
        public event EventHandler ShowStatistic;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public StartUserControl()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Переопределение обработчика события загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShowTestStatisticButton.Click += OnShowStatistic;
            StartTestButton.Click += OnStartTest;
        }

        /// <summary>
        /// Функция вызова события начала теста
        /// </summary>
        protected virtual void OnStartTest(object sender, EventArgs eventArgs)
        {
            StartTest?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Функция вызова события отображения статистики
        /// </summary>
        protected virtual void OnShowStatistic(object sender, EventArgs eventArgs)
        {
            ShowStatistic?.Invoke(this, EventArgs.Empty);
        }
    }
}
