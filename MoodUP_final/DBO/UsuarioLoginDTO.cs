using System.Text.Json.Serialization;
// ...
public class UsuarioLoginDTO
{
    [JsonPropertyName("email")]
    public string Correo { get; set; }

    [JsonPropertyName("password")]
    public string Contrasena { get; set; }
}
