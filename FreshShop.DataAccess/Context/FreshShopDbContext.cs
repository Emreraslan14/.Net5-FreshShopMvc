using FreshShop.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace FreshShop.DataAccess.Context
{
    public class FreshShopDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS ; database=FreshShopDb ; trusted_connection = true");
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
