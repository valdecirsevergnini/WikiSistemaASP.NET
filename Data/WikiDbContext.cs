using Microsoft.EntityFrameworkCore;
using WikiSistemaASP.NET.Models;

namespace WikiSistemaASP.NET.Data
{
    public class WikiDbContext : DbContext
    {
        public WikiDbContext(DbContextOptions<WikiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Topico> Topico { get; set; }
    }
}
