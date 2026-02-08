using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectPractice_.NET.Modules;
using System.Collections.Generic;

namespace ProjectPractice.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public DbSet<User>? Users => Set<User>();
        public DbSet<Category>? Categories => Set<Category>();
        public DbSet<Product>? Products => Set<Product>();
        public DbSet<Order>? Orders => Set<Order>();
        public DbSet<Review>? Reviews => Set<Review>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
