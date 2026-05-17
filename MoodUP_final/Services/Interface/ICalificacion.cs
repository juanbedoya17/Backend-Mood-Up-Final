using MoodUP_final.Models;

namespace MoodUP_final.Services.Interface
{
    public interface ICalificacion
    {

        public CalificacionContenido GetCalificacionUsuario(int idUsuario, int idContenido);
        public Task Guardar(CalificacionContenido contenido);

    }
}
