namespace Code_Database_First
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Purchase
    {
        public int PurchaseId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal Amount { get; set; }

        public int? Customer_CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
