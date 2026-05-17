using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoodUP_final.DTOs
{
    public class RegistroEmocionDTO
    {
        [Required]
        [JsonPropertyName("idUsuario")]
        public int IdUsuario { get; set; }

        [Required]
        [JsonPropertyName("idEmocion")]
        public int IdEmocion { get; set; }
    }
}
