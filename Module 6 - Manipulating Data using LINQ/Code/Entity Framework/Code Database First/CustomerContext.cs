namespace Code_Database_First
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("name=CustomerContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Purchases)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customer_CustomerId);
        }
    }
}
