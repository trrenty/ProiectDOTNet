using Lab6DOTNET.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6DOTNET.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ToDo>()
    .Property(t => t.Description).IsRequired().HasMaxLength(500);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

        }
    }
}
