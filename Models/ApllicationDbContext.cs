using Microsoft.EntityFrameworkCore;

namespace WikiSistemaASP.NET.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Adicione suas entidades aqui
        public DbSet<Topico> Topicos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Configurações adicionais, se necessário
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
