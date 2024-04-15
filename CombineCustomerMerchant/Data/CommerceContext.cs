using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CombineCustomerMerchant.Data;

public partial class CommerceContext : DbContext
{
    public CommerceContext()
    {

    }

    public CommerceContext(DbContextOptions<CommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Merchant> Merchants { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:CombineCustomerMerchantContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     /*   modelBuilder.Entity<Customer>()
            .Property(c => c.CustomerId)
            .ValueGeneratedOnAdd();*/

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Table");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PinCode).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.EMail).HasMaxLength(100);
            entity.Property(e => e.Latitude).HasColumnName("Latitude");
            entity.Property(e => e.Longitude).HasColumnName("Longitude");

        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6ED14944F8A");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Moq)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("MOQ");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

           entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.MapPosition).HasMaxLength(50);
            entity.Property(e => e.PinCode).HasMaxLength(30);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.EMail).HasMaxLength(100);
        });


        modelBuilder.Entity<Merchant>(entity =>
        {
            entity.HasKey(e => e.MerChantId).HasName("PK_MerchantID");

            entity.ToTable("Merchant");

            entity.Property(e => e.MerChantId).HasColumnName("MerchantID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.MapPosition).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PinCode).HasMaxLength(50);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.EMail).HasMaxLength(100);
            entity.Property(e => e.GSTNO).HasMaxLength(100);
            entity.Property(e => e.AAdhaarNo).HasMaxLength(50);

        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
