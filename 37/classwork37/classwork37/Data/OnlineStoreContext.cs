using classwork37.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace classwork37.Data
{
    class OnlineStoreContext: DbContext
    {
        private string _connectionString =
            @"Data Source=desktop-5gcn8t1\sqlexpress;" +
            "Initial Catalog=OnlineStoreEFCore;" +
            "Integrated Security=true;";

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Product>().ToTable("Product")
                .HasIndex(x => x.Price)
                .HasName("IX_Product_Price");

            modelBuilder
                .Entity<Product>()
                .HasKey(x => x.Id)
                .HasName("PK_Product");
            modelBuilder
                .Entity<Product>()
                .HasAlternateKey(x => x.Name)
                .HasName("UQ_Product_Name");

            modelBuilder
                .Entity<Product>().Property(x => x.Name).HasColumnType("VARCHAR(100)");
        }
    }
}
