using Ninject.Modules;
using TrafficLawsTest.Controls;
using TrafficLawsTest.Presenters;
using TrafficLawsTest.Security;
using TrafficLawsTest.Views;

namespace TrafficLawsTest.Utils.IoC
{
    public class ApplicationUIModule: NinjectModule
    {
        public override void Load()
        {

            Bind<LoginForm>().ToSelf();
            Bind<MainWindow>().ToSelf();

            Bind<TestUserControl>().ToSelf();
            Bind<StatisticUserControl>().ToSelf();
            Bind<StartUserControl>().ToSelf();

            Bind<ISecurityManager>().To<SecurityManager>().InSingletonScope();

            Bind<ILoginPresenrer>().To<LoginPresenter>().InTransientScope();
            Bind<IMainPresenter>().To<MainPresenter>().InTransientScope();

        }
    }
}
