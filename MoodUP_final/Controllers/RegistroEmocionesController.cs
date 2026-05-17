using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

[Route("api/[controller]")]
[ApiController]
public class RegistroEmocionesController : ControllerBase
{
    private readonly IRegistroEmociones _registroemocionesService;

    public RegistroEmocionesController(IRegistroEmociones RegistroEmocionesService)
    {
        _registroemocionesService = RegistroEmocionesService;
    }
    // 1. Registrar emoción
    [HttpPost]
    public async Task<IActionResult> RegistrarEmocion([FromBody] RegistroEmocionDTO registroDto)
    {
        try
        {
            var id = await _registroemocionesService.RegistrarEmocion(registroDto);
            return Ok(new
            {
                mensaje = "Emoción registrada exitosamente",
                idRegistro = id
            });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { mensaje = ex.Message });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { mensaje = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error Interno");
        }
    }
    // ==========================================================
    // 2. Obtener historial del usuario
    // ==========================================================
    [HttpGet("historial/{idUsuario}")]
    public async Task<IActionResult> GetHistorial(int idUsuario)
    {
        var historial = await _registroemocionesService.GetHistorial(idUsuario);

        return Ok(historial);
    }
}
