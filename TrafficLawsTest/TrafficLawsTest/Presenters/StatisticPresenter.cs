using TrafficLawsTest.Logic.Services;

namespace TrafficLawsTest.Presenters
{
    public interface IStatisticPresenter
    {
        string[] GetResults();
    }

    public class StatisticPresenter : IStatisticPresenter
    {
        private readonly IUserTestService _userTestService;


        public StatisticPresenter(IUserTestService userTestService)
        {
            _userTestService = userTestService;
        }

        public string[] GetResults()
        {
            return _userTestService.GetResults();
        }
    }
}