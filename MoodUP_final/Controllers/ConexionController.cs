using Microsoft.AspNetCore.Mvc;
using MoodUP_final.Data;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConexionController : ControllerBase
    {
        private readonly IConexion _conexionService;

        public ConexionController(IConexion ConexionService)
        {
            _conexionService = ConexionService;
        }

        [HttpGet("probar")]
        public IActionResult ProbarConexion()
        {
            try
            {
                bool ok = _conexionService.ProbarConexion();
                return ok
                    ? Ok("✅ Conexión exitosa con la base de datos MoodUp 🎉")
                    : StatusCode(500, "❌ No se pudo conectar a la base de datos MoodUp. Verifica tu configuración. 😕");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"❌ Error al probar la conexión: {ex.Message}");
            }
        }
    }
}

