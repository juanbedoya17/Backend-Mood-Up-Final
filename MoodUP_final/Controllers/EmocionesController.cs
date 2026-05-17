// EmocionesController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

[Route("api/[controller]")]
[ApiController]
public class EmocionesController : ControllerBase
{
    private readonly IEmociones _emocionesService;

    public EmocionesController(IEmociones EmocionesService)
    {
        _emocionesService = EmocionesService;
    }

    // Endpoint de prueba: GET /api/Emociones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Emocion>>> GetEmociones()
    {
        var conectar = await _emocionesService.GetEmociones();
        return Ok(conectar);
    }
}
