using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KatanaSample
{
    public class CustomerController : ApiController
    {
        public CustomerController()
        {
        }

        // Gets
        [HttpGet]
        public Customer Get(string customerId)
        {
            return new Customer()
            {
                ID = Int32.Parse(customerId),
                LastName = "Smith",
                FirstName = "Mary",
                HouseNumber = "333",
                Street = "Main Street NE",
                City = "Redmond",
                State = "WA",
                ZipCode = "98053"
            };
        }
    }
}
