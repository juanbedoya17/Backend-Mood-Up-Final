using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class CalificacionService : ICalificacion
    {
        private readonly MoodUpContext _context;

        public CalificacionService(MoodUpContext context)
        {
            _context = context;
        }
        public CalificacionContenido GetCalificacionUsuario(int idUsuario, int idContenido)
        {
            var item = _context.CalificacionContenido
                .FirstOrDefault(c => c.IdUsuario == idUsuario && c.IdContenido == idContenido);
            return item;
        }

        public Task Guardar(CalificacionContenido contenido)
        {

            return null;
        }
    }
}
