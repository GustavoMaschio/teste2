using System.ComponentModel.DataAnnotations;

namespace _50Blessings.Models
{
    public class Arma
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo nome deve ter entre 2 e 100 caracteres.")]
        public string nome { get; set; }

    }
}

