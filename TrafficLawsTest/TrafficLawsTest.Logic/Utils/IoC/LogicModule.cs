using Ninject.Modules;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Logic.Services;

namespace TrafficLawsTest.Logic.Utils.IoC
{
    /// <summary>
    /// Модуль для мапинга интерфейсов и реализации сервисов
    /// </summary>
    public class LogicModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestService>().To<TestService>().InTransientScope();
            Bind<IUserTestService>().To<UserTestService>().InTransientScope();
            Bind<IDomainContext>().To<DomainContext>().InTransientScope();
        }
    }
}
