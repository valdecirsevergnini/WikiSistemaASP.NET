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

        public DbSet<User> Users { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
