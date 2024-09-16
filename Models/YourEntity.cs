using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class YourEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Adicione outros campos e propriedades conforme necessário
        public string Description { get; set; }

        // Relacionamentos com outras entidades
        // Exemplo para Topico
        public ICollection<Topico> Topicos { get; set; }
        
        // Exemplo para Modulo
        public ICollection<Modulo> Modulos { get; set; }
        
        // Exemplo para Usuario
        public ICollection<Usuario> Usuarios { get; set; }
    }

    // Exemplo das outras entidades para referência

    public class Topico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        // Outras propriedades e relacionamentos
    }

    public class Modulo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Outras propriedades e relacionamentos
    }

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        // Outras propriedades e relacionamentos
    }
}
