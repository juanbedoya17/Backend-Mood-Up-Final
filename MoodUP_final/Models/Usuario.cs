using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace MoodUP_final.Models
{
    // === TABLA USUARIO ===
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Required]
        [MaxLength(255)]
        public string Contrasena { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }

    // === TABLA EMOCION ===
    public class Emocion
    {
        [Key]
        public int IdEmocion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Descripcion { get; set; }
    }

    // === TABLA RETO ===
    public class Reto
    {
        [Key]
        public int IdReto { get; set; }

        [ForeignKey("Emocion")]
        public int IdEmocion { get; set; }

        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(300)]
        public string Descripcion { get; set; }

        public Emocion Emocion { get; set; }
    }

    // === TABLA RETO COMPLETADO ===
    public class RetoCompletado
    {
        [Key]
        public int IdRetoCompletado { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("Reto")]
        public int IdReto { get; set; }

        public DateTime FechaCompletado { get; set; } = DateTime.Now;

        [JsonIgnore]
        public Usuario Usuario { get; set; }

        [JsonIgnore]
        public Reto Reto { get; set; }
    }


    // === TABLA REGISTRO EMOCION ===
    [Table("RegistroEmocion")]
    public class RegistroEmocion
    {
        [Key]
        public int IdRegistro { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("Emocion")]
        public int IdEmocion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public Usuario Usuario { get; set; }
        public Emocion Emocion { get; set; }
    }

    // === TABLA CONTENIDO ===
    public class Contenido
    {
        [Key]
        public int IdContenido { get; set; }

        [ForeignKey("Emocion")]
        public int IdEmocion { get; set; }

        [Required]
        [MaxLength(20)]
        public string Tipo { get; set; } // Película o Serie

        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

        [MaxLength(50)]
        public string Plataforma { get; set; }
        [MaxLength(300)]
        public string TrailerUrl { get; set; }


        [MaxLength(255)]
        public string ImagenUrl { get; set; }

        public Emocion Emocion { get; set; }
    }


    public class CalificacionContenido
    {
        [Key]
        public int IdCalificacion { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("Contenido")]
        public int IdContenido { get; set; }

        public int Puntuacion { get; set; }
        public DateTime FechaCalificacion { get; set; } = DateTime.Now;

        public Usuario Usuario { get; set; }
        public Contenido Contenido { get; set; }
    }


    public class Favorito
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("Contenido")]
        public int IdContenido { get; set; }

        public Usuario Usuario { get; set; }
        public Contenido Contenido { get; set; }
    }




}
