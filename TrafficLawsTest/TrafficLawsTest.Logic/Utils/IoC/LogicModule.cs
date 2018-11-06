using Ninject.Modules;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Logic.Services;

namespace TrafficLawsTest.Logic.Utils.IoC
{
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
