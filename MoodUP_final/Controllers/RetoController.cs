using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RetosController : ControllerBase
    {
        private readonly IReto _retoService;

        public RetosController(IReto RetoService)
        {
            _retoService = RetoService;
        }

        [HttpGet("emocion/{id}")]
        public async Task<ActionResult<IEnumerable<Reto>>> GetByEmocion(int id)
        {
            var lista = await _retoService.GetByEmocion(id);

            if (lista.Count == 0)
                return NotFound();

            return Ok(lista);
        }
    }

}

