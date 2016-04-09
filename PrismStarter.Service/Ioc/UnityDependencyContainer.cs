using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStarter.Service.Ioc
{
    public class UnityDependencyContainer : IDependencyContainer
    {
        private static readonly UnityContainer _container;

        static UnityDependencyContainer()
        {
            _container = new UnityContainer();
        }

        public void RegisterType<T1, T2>() where T2 : T1
        {
            _container.RegisterType<T1, T2>(new TransientLifetimeManager());
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
