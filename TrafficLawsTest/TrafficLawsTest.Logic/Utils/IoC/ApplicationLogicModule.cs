using Ninject.Modules;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.Logic.Services;

namespace TrafficLawsTest.Logic.Utils.IoC
{
    public class ApplicationLogicModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IUserService>().To<UserService>().InTransientScope();

            Bind<IDomainContext>().To<DomainContext>().InTransientScope();
        }
    }
}
