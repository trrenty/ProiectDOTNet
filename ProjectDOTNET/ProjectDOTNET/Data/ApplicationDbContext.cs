using Microsoft.EntityFrameworkCore;
using ProjectDOTNET.Models;

namespace ProjectDOTNET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Equation> Equation { get; set; }
    }
}
