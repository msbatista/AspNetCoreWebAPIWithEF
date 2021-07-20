using Microsoft.EntityFrameworkCore;
using Restaurant.Domain.Model;
using Restaurant.Domain.Model.Addresses;
using Restaurant.Domain.Model.Orders;
using Restaurant.Domain.Model.Products;
using Restaurant.Infrastructure.DataAccess.EntityFrameworkConfiguration;

namespace Restaurant.Infrastructure.DataAccess.Context
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
