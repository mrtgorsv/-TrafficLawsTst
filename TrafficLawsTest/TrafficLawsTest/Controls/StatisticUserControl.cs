using System;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;

namespace TrafficLawsTest.Controls
{
    /// <summary>
    /// Пользовательский элемент формы статистики
    /// </summary>
    public partial class StatisticUserControl : UserControl
    {
        // Презентер формы
        private readonly IStatisticPresenter _statisticPresenter;
        /// Событие нажатия кнопки назад
        public event EventHandler Back;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="statisticPresenter"></param>
        public StatisticUserControl(IStatisticPresenter statisticPresenter)
        {
            _statisticPresenter = statisticPresenter;
            InitializeComponent();
        }

        /// <summary>
        /// Переопределение обработчика события загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BackButton.Click += OnBackButtonClicked;
            TestStatisticListBox.DataSource = _statisticPresenter.GetResults();
            StatisticLabel.Text = _statisticPresenter.Title;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки назад
        /// </summary>
        /// <param name="e"></param>
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
