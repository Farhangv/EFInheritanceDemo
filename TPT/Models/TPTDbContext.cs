namespace TPT.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TPTDbContext : DbContext
    {
        public TPTDbContext()
            : base("TPTDbContext")
        {
        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<POSPayment> POSPayments { get; set; }
        public DbSet<CardTransferPayment> CardTransferPayments { get; set; }
        public DbSet<OnlinePayment> OnlinePayments { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<POSPayment>().ToTable("POSPayment", "Payments");
            modelBuilder.Entity<OnlinePayment>().ToTable("OnlinePayment", "Payments");
            modelBuilder.Entity<CardTransferPayment>().ToTable("CardTransferPayment", "Payments");

        }
    }

}