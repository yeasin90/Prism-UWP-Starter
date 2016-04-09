using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStarter.Service.Ioc
{
    public interface IDependencyContainer
    {
        void RegisterType<T1, T2>() where T2 : T1;
        object Resolve(Type type);
    }
}
