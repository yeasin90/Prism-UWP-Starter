using PrismStarter.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStarter.Service.Ioc
{
    public class DependencyProvider : IDependencyProvider
    {
        public int DependencyPriority
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void RegisterDependencies(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterType<IAddressService, AddressService>();
        }
    }
}
