using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class Modulo 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(200, ErrorMessage = "O nome não pode exceder 200 caracteres.")]
        public string Name { get; set; } = null!;

        [StringLength(1000, ErrorMessage = "A descrição não pode exceder 1000 caracteres.")]
        public string Description { get; set; } = null!; 

        public ICollection<Topico> Topicos { get; set; } = new List<Topico>(); // Inicializa a coleção para evitar referência nula
    }
}
