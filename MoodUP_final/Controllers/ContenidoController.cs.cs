using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.Services;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContenidoController : ControllerBase
    {
        private readonly IContenido _contenidoService;

        public ContenidoController(IContenido ContenidoService)
        {
            _contenidoService = ContenidoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contenido>>> GetContenidos()
        {
            var lista = await _contenidoService.GetContenidos();
            return Ok(lista);
        }

        [HttpGet("emocion/{id}")]
        public async Task<ActionResult<IEnumerable<Contenido>>> GetByEmocion(int id)
        {
            var lista = await _contenidoService.GetByEmocion(id);
            return Ok(lista);
            
            
        }
    }
}
