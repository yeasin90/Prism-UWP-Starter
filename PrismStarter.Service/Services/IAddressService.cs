using PrismStarter.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismStarter.Service.Services
{
    public interface IAddressService
    {
        Address GetAddress();
        List<Address> GetAll();
    }
}
