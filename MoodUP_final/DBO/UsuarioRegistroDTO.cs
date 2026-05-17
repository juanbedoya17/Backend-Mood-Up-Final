using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoodUP_final.DTOs
{
    public class UsuarioRegistroDTO
    {
        [Required]
        [JsonPropertyName("username")] // Le dice a C# que mapee 'username' de JS aquí
        public string nombreUsuario { get; set; }

        [Required]
        [EmailAddress]
        [JsonPropertyName("email")] // Mapea 'email' de JS aquí
        public string correo { get; set; }

        [Required]
        [JsonPropertyName("password")] // Mapea 'password' de JS aquí
        public string contrasena { get; set; }
    }
}