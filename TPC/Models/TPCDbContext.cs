namespace TPC.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TPCDbContext : DbContext
    {
        public TPCDbContext()
            : base("TPCDbContext")
        {
        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<POSPayment> POSPayments { get; set; }
        public DbSet<CardTransferPayment> CardTransferPayments { get; set; }
        public DbSet<OnlinePayment> OnlinePayments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<POSPayment>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("POSPayment");
            });
            modelBuilder.Entity<CardTransferPayment>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CardTransferPayment");
            });
            modelBuilder.Entity<OnlinePayment>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("OnlinePayment");
            });
        }

    }

}