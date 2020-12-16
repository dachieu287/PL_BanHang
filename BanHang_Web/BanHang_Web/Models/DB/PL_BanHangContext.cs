using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BanHang_Web.Models.DB
{
    public partial class PL_BanHangContext : DbContext
    {
        public PL_BanHangContext()
        {
        }

        public PL_BanHangContext(DbContextOptions<PL_BanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }
        public virtual DbSet<ComboDetail> ComboDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("Account");

                entity.Property(e => e.Username).HasMaxLength(250);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.ToTable("BillDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.ComboId)
                    .HasMaxLength(50)
                    .HasColumnName("ComboID");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillBillDetails");

                entity.HasOne(d => d.Combo)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ComboId)
                    .HasConstraintName("FK_ComboBillDetails");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductBillDetails");
            });

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.ToTable("Catalog");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Combo>(entity =>
            {
                entity.ToTable("Combo");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PrevPrice).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");
            });

            modelBuilder.Entity<ComboDetail>(entity =>
            {
                entity.HasKey(e => new { e.ComboId, e.ProductId })
                    .HasName("PK_ComboDetails");

                entity.ToTable("ComboDetail");

                entity.Property(e => e.ComboId)
                    .HasMaxLength(50)
                    .HasColumnName("ComboID");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.HasOne(d => d.Combo)
                    .WithMany(p => p.ComboDetails)
                    .HasForeignKey(d => d.ComboId)
                    .HasConstraintName("FK_ComboComboDetails");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ComboDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComboDetails");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.CatalogId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CatalogID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatalogProduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
