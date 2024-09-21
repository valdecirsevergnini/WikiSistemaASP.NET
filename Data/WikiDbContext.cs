using Microsoft.EntityFrameworkCore;
using WikiSistemaASP.NET.Models;

namespace WikiSistemaASP.NET.Data
{
    // A classe WikiDbContext representa o contexto do banco de dados para a aplicação
    public class WikiDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do contexto
        public WikiDbContext(DbContextOptions<WikiDbContext> options)
            : base(options) // Chama o construtor da classe base DbContext
        {
        }

        // DbSet para a entidade Usuario, representando a tabela de usuários no banco de dados
        public DbSet<Usuario> Usuarios { get; set; }

        // DbSet para a entidade Modulo, representando a tabela de módulos no banco de dados
        public DbSet<Modulo> Modulos { get; set; }

        // DbSet para a entidade Topico, representando a tabela de tópicos no banco de dados
        public DbSet<Topico> Topicos { get; set; }
    }
}
