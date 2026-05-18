using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.DTOs;
using MoodUP_final.Services.Interface;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MoodUP_final.Services
{
    public class RegistroEmocionesService : IRegistroEmociones
    {
        private readonly MoodUpContext _context;

        public RegistroEmocionesService(MoodUpContext context)
        {
            _context = context;
        }
        public async Task<int> RegistrarEmocion(RegistroEmocionDTO registroDto) // Registra la nueva emocion del usuario en la base de datos y devuelve el id del nuevo registro
        {

            if (registroDto.IdUsuario <= 0)
            {
                throw new ArgumentException("No puede estar vacio el IdUsuario");
            }

            if (registroDto.IdEmocion <= 0)
            {
                throw new ArgumentException("No puede estar vacio el IdEmocion");
            }

            var usuarioexiste = await _context.Usuario.FindAsync(registroDto.IdUsuario);

            if (usuarioexiste == null)
            {
                throw new KeyNotFoundException("El usuario no existe");
            }

            var emocionexiste = await _context.Emocion.FindAsync(registroDto.IdEmocion);

            if (emocionexiste == null)
            {
                throw new KeyNotFoundException("La emocion no existe");
            }
            
            var nuevoRegistro = new RegistroEmocion
            {
                IdUsuario = registroDto.IdUsuario,
                IdEmocion = registroDto.IdEmocion,
                FechaRegistro = DateTime.UtcNow

            };

            _context.RegistroEmocion.Add(nuevoRegistro);
            await _context.SaveChangesAsync();

            return nuevoRegistro.IdRegistro;
        }

        public async Task<IEnumerable<object>> GetHistorial(int idUsuario) // toma el historial de la base de datos del usuario y la muestra
        {
            var historial = await _context.RegistroEmocion
                .Where(r => r.IdUsuario == idUsuario)
                .Include(r => r.Emocion)
                .OrderByDescending(r => r.FechaRegistro)
                .Select(r => new
                {
                    nombreEmocion = r.Emocion.Nombre,
                    fecha = r.FechaRegistro
                })
                .ToListAsync();

            return historial;
        }
    }
}
