using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    public class NullConditionalOperator
    {
        public void Sample()
        {

            var customer = new Customer();


            // Old Version
            if (customer is not null && customer.Orders is not null)
            {
                customer.Orders.Ship();
            }

            // New Version
            customer?.Orders?.Ship();

        }
    }

    public class Customer
    {
        public Customer()
        {
        }

        public Orders Orders { get; internal set; }
    }

    public class Orders
    {
        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
