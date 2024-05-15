using COMP003B.Final.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Final.Data
{
    public class OnlineStoreHubContext : DbContext
    {

        public OnlineStoreHubContext(DbContextOptions<OnlineStoreHubContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories{get; set;}
        public DbSet<Customer> Customers{get; set;}
        public DbSet<Order> Orders{get; set;}
        public DbSet<Orderproduct> Orderproducts{get; set;}
        public DbSet<Product> Products{get; set;}
        public DbSet<Seller> Sellers{get; set;}


    }
}
