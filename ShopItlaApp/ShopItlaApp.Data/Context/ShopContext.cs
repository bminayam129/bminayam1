

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShopItlaApp.Data.Entities;

namespace ShopItlaApp.Data.Context
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }


        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet <Employees> Employees { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
