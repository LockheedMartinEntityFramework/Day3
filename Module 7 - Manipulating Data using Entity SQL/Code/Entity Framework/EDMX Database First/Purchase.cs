//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDMX_Database_First
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Purchase
    {
        public int PurchaseId { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
