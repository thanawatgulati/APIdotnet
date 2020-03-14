using APIdotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace APIdotnet.Database
{
    public class DatabaseContext : DbContext
    {
        // TableName
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        // --------------------------------------------------------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Primary Key
            modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryID);

        }
    }
}