using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrafficLawsTest.Presenters;
using TrafficLawsTest.Utils;
using TrafficLawsTest.Views;

namespace TrafficLawsTest.Controls
{
    /// <summary>
    /// Пользовательский элемент формы теста 
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        // Презентер формы
        private readonly ITestPresenter _testPresenter;

        // Варианты ответов задания
        private readonly List<RadioButton> _answerButtons;

        // Событие завершения теста
        public event EventHandler CompleteTest;

        // Конструктор класса
        public TestUserControl(ITestPresenter testPresenter)
        {
            _testPresenter = testPresenter;
            InitializeComponent();

            // Группировки кнопок с вариантами ответов
            _answerButtons = new List<RadioButton>()
            {
                FirstAnswer,
                SecondAnswer,
                ThirdAnswer,
                FourAnswer
            };
        }

        public MainWindow MainForm => Parent?.Parent as MainWindow;

        /// <summary>
        /// Переопределение обработчика события загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _testPresenter.LoadTest();
            UpdateQuestion();
            PrevButton.Click += OnPrevButtonClicked;
            NextButton.Click += OnNextButtonClicked;
            CompleteTestButton.Click += OnCompleteButtonClicked;
            MainForm.Next += OnNextButtonClicked;
            MainForm.Prev += OnPrevButtonClicked;
        }

        /// <summary>
        /// Обработчик события выбора варианта ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAnswerChanged(object sender, EventArgs e)
        {
            SaveSelection();
            RefreshView();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки завершения теста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCompleteButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            ShowResultForm(_testPresenter.SaveResult());
            OnCompleteTest();
        }

        /// <summary>
        /// Функция отображения результата тестирования
        /// </summary>
        private void ShowResultForm(string[] result)
        {
            var resultForm = new ResultForm();
            resultForm.SetResult(result);
            resultForm.ShowDialog(this);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки перехода к следующему вопросу
        /// </summary>
        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            _testPresenter.NextQuestion();
            UpdateQuestion();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки перехода к предыдущему вопросу
        /// </summary>
        private void OnPrevButtonClicked(object sender, EventArgs e)
        {
            SaveSelection();
            _testPresenter.PrevQuestion();
            UpdateQuestion();
        }

        /// <summary>
        /// Функция сохранения текущего выбора пользователя
        /// </summary>
        private void SaveSelection()
        {
            var checkedButton = _answerButtons
                .FirstOrDefault(r => r.Checked);

            _testPresenter.CurrentQuestion.UserAnswer = Convert.ToInt32(checkedButton?.Tag);
        }

        /// <summary>
        /// Функция обновления состояния представления
        /// </summary>
        private void RefreshView()
        {
            // Кнопка "Назад" недоступна , если вопрос первый в списке
            PrevButton.Visible = !_testPresenter.IsFirst;
            // Кнопка "Вперед" недоступна , если вопрос последний в списке
            NextButton.Visible = !_testPresenter.IsLast;
            // Кнопка завершения видима, если указаны ответы на все вопросы
            CompleteTestButton.Visible = _testPresenter.TestComplete;
        }

        /// <summary>
        /// Функция обновления информации о текущем вопросе
        /// </summary>
        private void UpdateQuestion()
        {
            // Вызов метода обновления изображения теста
            UpdateImage();
            // Метод, задающий варианты ответов для текущего теста
            SetAnswers();
            // Установка текущего номера вопроса.
            QuestionOrderLabel.Text = _testPresenter.CurrentQuestion?.Name;
            // Вызов метода обновления состояния формы
            RefreshView();
        }

        /// <summary>
        /// Функция установки вариантов ответа текущего вопроса
        /// </summary>
        private void SetAnswers()
        {
            // Отписываемся от обработчика события изменения выбора
            FirstAnswer.CheckedChanged -= OnAnswerChanged;
            SecondAnswer.CheckedChanged -= OnAnswerChanged;
            ThirdAnswer.CheckedChanged -= OnAnswerChanged;
            FourAnswer.CheckedChanged -= OnAnswerChanged;

            // Сбрасываем все значения 
            FirstAnswer.Checked = false;
            SecondAnswer.Checked = false;
            ThirdAnswer.Checked = false;
            FourAnswer.Checked = false;

            // Установка значений вариантов ответа теста
            SetText(FirstAnswer, "a)",  _testPresenter.GetAnswerText(0));
            SetText(SecondAnswer, "б)" , _testPresenter.GetAnswerText(1));
            SetText(ThirdAnswer, "в)" , _testPresenter.GetAnswerText(2));
            SetText(FourAnswer, "г)" , _testPresenter.GetAnswerText(3));

            // Устанавливаем выбранное ранее значения пользователем
            var answerButton = _answerButtons
                .FirstOrDefault(r => Convert.ToInt32(r.Tag).Equals(_testPresenter.CurrentQuestion.UserAnswer));
            if (answerButton != null)
            {
                answerButton.Checked = true;
            }

            // Подписываемся на событие изменения выбора
            FirstAnswer.CheckedChanged += OnAnswerChanged;
            SecondAnswer.CheckedChanged += OnAnswerChanged;
            ThirdAnswer.CheckedChanged += OnAnswerChanged;
            FourAnswer.CheckedChanged += OnAnswerChanged;
        }

        /// <summary>
        /// Метод устанавливающий текст кнопки с вариантом ответа вопроса теста
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="prefix"></param>
        /// <param name="text"></param>
        private void SetText(RadioButton answer, string prefix , string text)
        {
            answer.Text = $"{prefix} {text}";
            answer.Visible = !string.IsNullOrWhiteSpace(text);
        }


        /// <summary>
        /// Функция отображения изображения текущего вопроса
        /// </summary>
        private void UpdateImage()
        {
            TestImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TestImageBox.Image = _testPresenter.CurrentQuestion.Content.ToImage();
        }

        /// <summary>
        /// Функция вызова события завершения теста
        /// </summary>
        protected virtual void OnCompleteTest()
        {
            CompleteTest?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Метод для обработки события нажатия клавиш пользователем
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    PrevButton.PerformClick();
                    return true;
                case Keys.Right:
                    NextButton.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}