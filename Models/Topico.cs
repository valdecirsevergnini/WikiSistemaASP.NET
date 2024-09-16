using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class Topic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string Content { get; set; }  // Pode ser texto em Markdown ou HTML

        public string ImageUrl { get; set; }  // URL para imagens associadas ao tópico

        public string VideoUrl { get; set; }  // URL para vídeos associados ao tópico

        public int ModuleId { get; set; }
        public Module Module { get; set; }
    }
}
