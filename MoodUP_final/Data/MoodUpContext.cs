using Microsoft.EntityFrameworkCore;
using MoodUP_final.Models;

namespace MoodUP_final.Data
{
    public class MoodUpContext : DbContext
    {
        public MoodUpContext(DbContextOptions<MoodUpContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Emocion> Emocion { get; set; }
        public DbSet<Reto> Reto { get; set; }
        public DbSet<RetoCompletado> RetoCompletado { get; set; }
        public DbSet<RegistroEmocion> RegistroEmocion { get; set; }
        public DbSet<Contenido> Contenido { get; set; }
        public DbSet<CalificacionContenido> CalificacionContenido { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }


    }
}
