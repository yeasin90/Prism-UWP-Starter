using PrismStarter.Service.Ioc;

namespace Neptune.Service.Utility
{
    public class DependencyUtility
    {
        private static IDependencyContainer _container;

        static DependencyUtility()
        {
            _container = new UnityDependencyContainer();

            IDependencyProvider provider = new DependencyProvider(); 
            provider.RegisterDependencies(_container);
        }

        public static IDependencyContainer DependencyContainer
        {
            get
            {
                return _container;
            }
        }
    }
}
