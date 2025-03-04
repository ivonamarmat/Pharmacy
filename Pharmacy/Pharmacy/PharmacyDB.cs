using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pharmacy
{
    public partial class PharmacyDB : DbContext
    {
        public PharmacyDB()
            : base("PharmacyDB")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptItem> ReceiptItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Nono> Nonos { get; set; }
        public virtual DbSet<AppSettings> AppSettingss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
               .Property(e => e.Country)
               .HasMaxLength(50);
             

            modelBuilder.Entity<Price>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Price>()
                .Property(e => e.SellingPrice)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ReceiptItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptItems);

            modelBuilder.Entity<User>()
                .Property(e => e.PID)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.PharmacistId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppSettings>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.AppSettings)
                .HasForeignKey(e => e.AppSettingsId)
                .WillCascadeOnDelete(false);
        }
    }
}
