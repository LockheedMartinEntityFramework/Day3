using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMX_Model_First
{
    public static class ContextWrapper
    {
        private static CustomerContextContainer context = new CustomerContextContainer();
        public static List<Customer> getCustomers() 
        { 
            return context.Customers.ToList<Customer>();
        }

        public static void addCustomer(Customer newCustomer)
        {
            context.Customers.Add(newCustomer);
        }
    }
}
