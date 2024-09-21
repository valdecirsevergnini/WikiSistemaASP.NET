using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    // A classe Usuario representa um usuário do sistema
    public class Usuario
    {
        // Propriedade Id para identificar o usuário de forma única
        public int Id { get; set; }

        // Propriedade Username: Nome de usuário que deve ser único
        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome de usuário não pode exceder 100 caracteres.")]
        public string? Username { get; set; } // Tornada anulável

        // Propriedade PasswordHash: Armazena o hash da senha do usuário
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha não pode exceder 100 caracteres.")]
        public string? PasswordHash { get; set; } // Tornada anulável

        // Propriedade IsAdmin: Indica se o usuário possui privilégios de administrador
        [Required(ErrorMessage = "A informação sobre o administrador é obrigatória.")]
        public bool IsAdmin { get; set; } // Define se o usuário é administrador
    }
}


