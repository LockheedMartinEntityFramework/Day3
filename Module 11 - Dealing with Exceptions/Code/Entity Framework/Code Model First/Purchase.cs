using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Model_First
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
    }
}
