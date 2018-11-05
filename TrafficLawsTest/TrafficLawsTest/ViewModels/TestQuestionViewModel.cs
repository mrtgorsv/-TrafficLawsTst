using System.Collections.Generic;

namespace TrafficLawsTest.ViewModels
{
    public class TestQuestionViewModel
    {
        public byte[] Content { get; set; }
    }
    public class AnswerViewModel
    {
        public int Seq { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public bool Selected { get; set; }

    }
    public class ResultViewModel
    {
       public List<TestQuestionViewModel> Questions { get; set; }

    }
}
