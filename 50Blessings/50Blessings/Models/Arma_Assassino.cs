using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _50Blessings.Models
{
    public class Arma_Assassino
    {
        [Key]
        public int idArma { get; set; }
        [JsonIgnore]
        public Arma id{ get; set; }

        [Key]
        public int NomeAssassino { get; set; }
        [JsonIgnore]
        public Assassino nome { get; set; }

    }
}