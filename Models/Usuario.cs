using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }  // Armazena o hash da senha

        [Required]
        public bool IsAdmin { get; set; }  // Determina se o usuário é administrador
    }
}
