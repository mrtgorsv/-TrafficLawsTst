using Ninject;
using TrafficLawsTest.Logic.Utils.IoC;

namespace TrafficLawsTest.Utils.IoC
{
    public static class DiFactory
    {
        private static IKernel _kernel;

        public static T Resolve<T>()
        {
            EnsureKernelCreated();
            return _kernel.Get<T>();
        }

        private static void EnsureKernelCreated()
        {
            if (_kernel == null)
            {
                _kernel = new StandardKernel(new ApplicationLogicModule(), new ApplicationUIModule());
            }
        }
    }
}