namespace TPH.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TPHDbContext : DbContext
    {
        public TPHDbContext()
            : base("TPHDbContext")
        {
        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<POSPayment> POSPayments { get; set; }
        public DbSet<CardTransferPayment> CardTransferPayments { get; set; }
        public DbSet<OnlinePayment> OnlinePayments { get; set; }
    }
}