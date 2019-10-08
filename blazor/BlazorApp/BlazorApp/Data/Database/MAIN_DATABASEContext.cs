using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp.Data.Database
{
    public partial class MAIN_DATABASEContext : DbContext
    {
        public MAIN_DATABASEContext()
        {
        }

        //public MAIN_DATABASEContext(DbContextOptions<MAIN_DATABASEContext> options)
        //    : base(options)
        //{
        //}

        public MAIN_DATABASEContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("products");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("insertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("productName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.ToTable("sales");

                entity.Property(e => e.SalesId).HasColumnName("salesId");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("insertDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.UserIdBuyer).HasColumnName("userIdBuyer");

                entity.Property(e => e.UserIdSeller).HasColumnName("userIdSeller");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}