using System.Collections.Generic;

namespace TrafficLawsTest.ViewModels
{
    /// <summary>
    /// Модель представления, описывающая задание теста
    /// </summary>
    public class TestQuestionViewModel
    {
        public byte[] Content { get; set; }
        public int Seq { get; set; }

        public string Name => $"Вопрос #{Seq}";

        public int CorrectAnswer { get; set; }
        public int UserAnswer { get; set; }
        public List<AnswerViewModel> Answers { get; set; }

        public bool IsCorrect => CorrectAnswer.Equals(UserAnswer);
        public string CorrectString => IsCorrect ? "Верно" : "Неверно";
    }

    public class AnswerViewModel
    {
        public int Seq { get; set; }
        public string Text { get; set; }
        public bool Selected { get; set; }
    }

    public class ResultViewModel
    {
       public List<TestQuestionViewModel> Questions { get; set; }
       public int Result { get; set; }
    }
}
