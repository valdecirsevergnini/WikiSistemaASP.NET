using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome de usuário não pode exceder 100 caracteres.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, ErrorMessage = "A senha não pode exceder 100 caracteres.")]
        public string PasswordHash { get; set; } // Armazena o hash da senha

        [Required(ErrorMessage = "A informação sobre o administrador é obrigatória.")]
        public bool IsAdmin { get; set; } // Determina se o usuário é administrador
    }
}


