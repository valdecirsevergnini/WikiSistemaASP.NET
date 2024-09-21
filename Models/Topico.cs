using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class Topico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(200, ErrorMessage = "O título não pode exceder 200 caracteres.")]
        public string Title { get; set; }

        public string Content { get; set; } // Pode ser texto em Markdown ou HTML

        public string ImageUrl { get; set; } // URL para imagens associadas ao tópico

        public string VideoUrl { get; set; } // URL para vídeos associados ao tópico

        [Required(ErrorMessage = "O ID do módulo é obrigatório.")]
        public int ModuloId { get; set; }
        public Modulo Modulo { get; set; } // Relacionamento com a classe Modulo
    }
}

