using EfCoreGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreGetStarted.Data;

public class HamburgPizzaContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=HamburgPizzaDb;User=sa;Password=Toan14032001@;TrustServerCertificate=True;Encrypt=false");
    }
}
