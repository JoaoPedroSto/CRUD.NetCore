using IntegradorEC1.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegradorEC1.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Comando> Comando { get; set; }
    }
}