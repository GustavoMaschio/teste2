using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _50Blessings.Models
{
    public class Assassino
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 e 100 caracteres.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 e 100 caracteres.")]
        public string MascaraNome { get; set; }
        [JsonIgnore]
        public Mascara Nome { get; set; }
    }
}
