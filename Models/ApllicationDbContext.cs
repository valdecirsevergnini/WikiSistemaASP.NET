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
        public DbSet<YourEntity> YourEntities { get; set; }
    }
}
