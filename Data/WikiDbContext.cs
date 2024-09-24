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

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Topico> Topicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topico>()
                .HasOne(t => t.Modulo) // Cada tópico tem um módulo
                .WithMany(m => m.Topicos) // Um módulo pode ter muitos tópicos
                .HasForeignKey(t => t.ModuloId); // Define a chave estrangeira
        }
    }
}
