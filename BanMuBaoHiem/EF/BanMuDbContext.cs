namespace BanMuBaoHiem.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BanMuDbContext : DbContext
    {
        public BanMuDbContext()
            : base("name=BanMuDbContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Salary>()
                .Property(e => e.salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StockIn>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);
        }
    }
}
