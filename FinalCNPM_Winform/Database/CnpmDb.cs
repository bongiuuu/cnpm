using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FinalCNPM_Winform.Database
{
    public partial class CnpmDb : DbContext
    {
        public CnpmDb()
               : base("data source=DESKTOP-ABAJU1U\\SQLEXPRESS;Initial Catalog=Store;Integrated Security=True")
        {
        }

        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<DeliveryNote> DeliveryNotes { get; set; }
        public virtual DbSet<DeliveryProduct> DeliveryProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ReceiveNote> ReceiveNotes { get; set; }
        public virtual DbSet<ReceiveProduct> ReceiveProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountant>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<DeliveryProduct>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderProduct>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ReceiveProduct>()
                .Property(e => e.price)
                .HasPrecision(18, 0);
        }
    }
}
