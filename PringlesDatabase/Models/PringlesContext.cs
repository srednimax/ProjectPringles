using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PringlesDatabase.Models
{
    public class PringlesContext :DbContext
    {
        public DbSet<Pringles> Pringleses { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // base.OnConfiguring(optionsBuilder);
           optionsBuilder
               .LogTo(Console.WriteLine, LogLevel.Information)
               .UseSqlServer(MyDBContext.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}