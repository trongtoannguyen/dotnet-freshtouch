using System;
using System.Collections.Generic;
using EfCoreGetStarted.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreGetStarted.Data;

public partial class HamburgPizzaDbContext : DbContext
{
    public HamburgPizzaDbContext()
    {
    }

    public HamburgPizzaDbContext(DbContextOptions<HamburgPizzaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
