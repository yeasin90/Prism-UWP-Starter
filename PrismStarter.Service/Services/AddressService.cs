using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismStarter.Service.Domain;

namespace PrismStarter.Service.Services
{
    public class AddressService : IAddressService
    {
        public Address GetAddress()
        {
            return new Address()
            {
                FirstName = "Yeasin",
                LastName = "Abedin"
            };
        }

        public List<Address> GetAll()
        {
            return new List<Address>()
            {
                new Address { FirstName = "Lionel", LastName="Messi" },
                new Address { FirstName="Cristiano", LastName="Ronaldo" },
                new Address { FirstName="David", LastName="Beckham" }
            };
        }
    }
}
