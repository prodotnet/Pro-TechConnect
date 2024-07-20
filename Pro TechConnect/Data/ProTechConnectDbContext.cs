using Microsoft.EntityFrameworkCore;
using Pro_TechConnect.Models;

namespace Pro_TechConnect.Data
{
    public class ProTechConnectDbContext:DbContext
    {
        public ProTechConnectDbContext(DbContextOptions<ProTechConnectDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
