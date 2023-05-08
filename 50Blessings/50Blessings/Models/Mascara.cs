using System.ComponentModel.DataAnnotations;

namespace _50Blessings.Models
{
    public class Mascara
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 e 100 caracteres.")]
        public string nome { get; set; }

    }
}

