using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class RetosCompletadosService : IRetosCompletados
    {
        private readonly MoodUpContext _context;

        public RetosCompletadosService(MoodUpContext context)
        {
            _context = context;
        }

        public async Task<List<int>> GetRetosCompletados(int idUsuario)
        {
            var lista = await _context.RetoCompletado
            .Where(r => r.IdUsuario == idUsuario)
            .Select(r => r.IdReto)
            .ToListAsync();

            return lista;
        }

        public async Task MarcarReto(RetoCompletadoDTO model)
        {
            if (model.IdUsuario <= 0)
            {
                throw new ArgumentException("Tiene que estar el IdUsuario");
            }
            if (model.IdReto <= 0)
            {
                throw new ArgumentException("Tiene que estar el IdReto");
            }

            var existe = await _context.RetoCompletado
                .AnyAsync(r => r.IdUsuario == model.IdUsuario && r.IdReto == model.IdReto);

            if (!existe)
            {
                var nuevo = new RetoCompletado
                {
                    IdUsuario = model.IdUsuario,
                    IdReto = model.IdReto,
                    FechaCompletado = DateTime.UtcNow

                };
                await _context.RetoCompletado.AddAsync(nuevo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReto(int idUsuario, int idReto)
        {
            var usuarioExiste = await _context.Usuario.AnyAsync(u => u.IdUsuario == idUsuario);
            if (!usuarioExiste)
            {
                throw new ArgumentException("El usuario no existe.");
            }
            var retoExiste = await _context.Reto.AnyAsync(r => r.IdReto == idReto);
            if (!retoExiste)
            {
                throw new ArgumentException("El reto no existe.");
            }

            var registro = await _context.RetoCompletado
            .FirstOrDefaultAsync(r => r.IdUsuario == idUsuario && r.IdReto == idReto);

            if (registro == null)
                throw new ArgumentException("No se encontró el registro del reto completado para el usuario.");

            _context.RetoCompletado.Remove(registro);
            await _context.SaveChangesAsync();
        }
    }
}