using ExampleWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebApp.Context
{
    public class DbEntities : DbContext
    {
        public DbEntities(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>()
                .ToTable("Category", "offers");
        }

        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
