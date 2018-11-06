using Ninject.Modules;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Security.Services;

namespace TrafficLawsTest.Logic.Utils.IoC
{
    public class LogicModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IUserService>().To<UserService>().InTransientScope();

            Bind<IDomainContext>().To<DomainContext>().InTransientScope();
        }
    }
}
