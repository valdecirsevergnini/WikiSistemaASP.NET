using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    // A classe Topico representa um tópico dentro do sistema Wiki
    public class Topico
    {
        // Identificador único do tópico
        public int Id { get; set; }

        // Título do tópico, obrigatório e com limite de 200 caracteres
        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(200, ErrorMessage = "O título não pode exceder 200 caracteres.")]
        public string Titulo { get; set; } = string.Empty; // Inicializa como string vazia

        // Conteúdo do tópico, pode ser em Markdown ou HTML
        public string Conteudo { get; set; } = string.Empty; // Inicializa como string vazia

        // URL para imagens associadas ao tópico
        public string? ImageUrl { get; set; } // URL para imagens

        // URL para vídeos associados ao tópico
        public string? VideoUrl { get; set; } // URL para vídeos

        // ID do módulo ao qual o tópico pertence, obrigatório
        [Required(ErrorMessage = "O ID do módulo é obrigatório.")]
        public int ModuloId { get; set; }

        // Relacionamento com a classe Modulo, representando o módulo do tópico
        public Modulo Modulo { get; set; } = null!; // Adiciona o operador de afirmação
    }
}

