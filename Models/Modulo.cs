using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WikiSistemaASP.NET.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public ICollection<Topic> Topics { get; set; }
    }
}
