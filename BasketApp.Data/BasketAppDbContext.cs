using BasketApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BasketApp.Data
{
    public partial class BasketAppDbContext : DbContext
    {
        public BasketAppDbContext()
        {
        }

        public BasketAppDbContext(DbContextOptions<BasketAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBasket> TbBaskets { get; set; }
        public virtual DbSet<TbCustomer> TbCustomers { get; set; }
        public virtual DbSet<TbOption> TbOptions { get; set; }
        public virtual DbSet<TbOptionGroup> TbOptionGroups { get; set; }
        public virtual DbSet<TbProduct> TbProducts { get; set; }
        public virtual DbSet<TbProductOption> TbProductOptions { get; set; }
        public virtual DbSet<TbProductVariant> TbProductVariants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TbBasket>(entity =>
            {
                entity.ToTable("TB_Basket");

                entity.Property(e => e.Count).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TbCustomer>(entity =>
            {
                entity.ToTable("TB_Customer");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbOption>(entity =>
            {
                entity.ToTable("TB_Option");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbOptionGroup>(entity =>
            {
                entity.ToTable("TB_OptionGroup");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbProduct>(entity =>
            {
                entity.ToTable("TB_Product");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TbProductOption>(entity =>
            {
                entity.ToTable("TB_ProductOption");
            });

            modelBuilder.Entity<TbProductVariant>(entity =>
            {
                entity.ToTable("TB_ProductVariant");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
