using MoodUP_final.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;

namespace MoodUP_final.Services
{
    public class EmocionesService : IEmociones
    {
        private readonly MoodUpContext _context;

        public EmocionesService(MoodUpContext context)
        {
            _context = context;
        }

        public async Task<List<Emocion>> GetEmociones()
        {
            var conectar = await _context.Emocion.ToListAsync();
            return conectar;
        }
    }
}
