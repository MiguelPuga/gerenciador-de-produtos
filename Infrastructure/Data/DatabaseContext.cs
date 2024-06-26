﻿using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
    { }
    /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
     {
         modelBuilder.Entity<Product>()
             .ComplexProperty(e => e.price);

     } */
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Stock> Stock { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}
