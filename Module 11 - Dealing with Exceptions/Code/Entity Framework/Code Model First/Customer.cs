using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Model_First
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual List<Purchase> Purchases { get; set; }
    }
}
