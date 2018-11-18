namespace TrafficLawsTest.Presenters
{
    public interface IMainPresenter
    {
        string Title { get; }
    }

    /// <summary>
    /// Класс презентер для представления главной формы приложения
    /// Описывают логику данного представления
    /// </summary>
    public class MainPresenter : IMainPresenter
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainPresenter()
        {
        }

        /// Заголовок главной формы
        public string Title => "Тест ПДД";
    }
}