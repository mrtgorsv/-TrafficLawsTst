using Ninject.Modules;
using TrafficLawsTest.Security.Services;

namespace TrafficLawsTest.Security.Utils.IoC
{
    public class SecurityModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>().InTransientScope();
            Bind<ISecurityManager>().To<SecurityManager>().InSingletonScope();
        }
    }
}
