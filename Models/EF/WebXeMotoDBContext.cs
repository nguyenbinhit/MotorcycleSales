namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebXeMotoDBContext : DbContext
    {
        public WebXeMotoDBContext()
            : base("name=WebXeMotoDBContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CarManufacturer> CarManufacturers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<CylinderCapacity> CylinderCapacities { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StaticPage> StaticPages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CarManufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.CarManufacturer)
                .HasForeignKey(e => e.id_CarManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.id_Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Color)
                .HasForeignKey(e => e.id_Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CylinderCapacity>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.CylinderCapacity)
                .HasForeignKey(e => e.id_CylinderCapacity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.id_Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.id_Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.id_Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.id_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.id_User)
                .WillCascadeOnDelete(false);
        }
    }
}
