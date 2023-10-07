﻿using System;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Database=HamburgPizzaDb;User=sa;Password=Toan14032001@;TrustServerCertificate=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
