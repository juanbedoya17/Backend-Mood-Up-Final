using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class ContenidoService : IContenido
    {
        private readonly MoodUpContext _context;

        public ContenidoService(MoodUpContext context)
        {
            _context = context;
        }

        public async Task<List<Contenido>> GetContenidos()
        {
            var Contenido = await _context.Contenido.ToListAsync();
            return Contenido;
        }

        public async Task<List<Contenido>> GetByEmocion(int id)
        {
            var lista = await _context.Contenido
                .Where(c => c.IdEmocion == id)
                .ToListAsync();
            return lista;
        }
        
    }
}
