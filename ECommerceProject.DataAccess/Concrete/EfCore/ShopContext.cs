using ECommerceProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceProject.DataAccess.Concrete.EfCore
{
   public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-3VB3SSC\MSSQLSERVERLAST;Database = ECommerce;Integrated Security = true ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategories>().HasKey(p => new { p.CategoryId, p.ProductId });
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductCategories> ProductCategories { get; set; }
    }
}
