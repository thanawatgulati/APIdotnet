using System;
using System.Linq;
using APIdotnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APIdotnet.Database
{
    public class DatabaseInit
    {
        public static void INIT(IServiceProvider ServiceProvider)
        {
            var context = new DatabaseContext(ServiceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>());
            // If database does not exist then the database and all its schema are created
            context.Database.EnsureCreated();
            InsertData(context);
        }

        public static void InsertData(DatabaseContext context)
        {
            // ---------- Categories Table ---------
            if (context.Categories.Any())
            {
                return;
            }
            context.Categories.Add(new Category
            {
                Name = "IT",
                Description = "Mac Products"
            });
            context.SaveChanges();
            // ---------- Supplier Table ---------
            context.Suppliers.Add(new Supplier
            {
                Name = "Thanawat Gulati",
                Phone = "0900000000"
            });
            context.SaveChanges();

            // ---------- Product Table ---------
            context.Products.Add(new Product
            {
                Name = "Macbook Pro 2019",
                Price = 345000,
                CategoryID = 1,
                SupplierID = 1
            });
            context.SaveChanges();
        }
    }
}