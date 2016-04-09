using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStarter.Service.Ioc
{
    public interface IDependencyProvider
    {
        int DependencyPriority { get; }
        void RegisterDependencies(IDependencyContainer dependencyContainer);
    }
}
