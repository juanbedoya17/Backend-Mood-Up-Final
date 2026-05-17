using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class RetoService : IReto
    {
        private readonly MoodUpContext _context;

        public RetoService(MoodUpContext context)
        {
            _context = context;
        }
        [HttpGet("emocion/{id}")]
        public async Task<List<Reto>> GetByEmocion(int idEmocion)
        {
            var lista = await _context.Reto
                .Where(r => r.IdEmocion == idEmocion)
                .ToListAsync();
                
            return lista;
        }
    }

}
