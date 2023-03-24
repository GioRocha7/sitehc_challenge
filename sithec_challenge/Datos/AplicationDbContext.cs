using Microsoft.EntityFrameworkCore;
using sithec_challenge.Models;

namespace sithec_challenge.Datos
{
    public class AplicationDbContext:DbContext 
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Humano> humanos { get; set; }
    }
}
