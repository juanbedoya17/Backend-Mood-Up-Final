using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services;
using MoodUP_final.Services.Interface;

[Route("api/[controller]")]
[ApiController]
public class RetosCompletadosController : ControllerBase
{
    private readonly IRetosCompletados _retoscompletadosService;

    // Constructor actualizado: inyecta el servicio y el contexto
    public RetosCompletadosController(IRetosCompletados RetosCompletadosService)
    {
        
        _retoscompletadosService = RetosCompletadosService;
    }

    [HttpGet("usuario/{idUsuario}")]
    public async Task<IActionResult> GetRetosCompletados(int idUsuario)
    {
        // Usar la instancia inyectada del servicio (no el nombre del tipo)
        var lista = await _retoscompletadosService.GetRetosCompletados(idUsuario);

        return Ok(lista);
    }

    [HttpPost]
    public async Task<IActionResult> MarcarReto([FromBody] RetoCompletadoDTO model)
    {
        try
        {
            await _retoscompletadosService.MarcarReto(model);
            return Ok(new
            {
                mensaje = "Reto marcado como completado"
            });
        }
        catch (ArgumentException ex)
        {
           return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error Interno");
        }

    }
        [HttpDelete("usuario/{idUsuario}/reto/{idReto}")]
    public async Task<IActionResult> DeleteReto(int idUsuario, int idReto)
    {
        try {
            await _retoscompletadosService.DeleteReto(idUsuario, idReto);
            return Ok(new
            {
                mensaje = "Reto Desmarcado"
            });
        }
        catch (ArgumentException ex)
        {
           return BadRequest(new { mensaje = ex.Message });
        }
        catch (Exception)
        {
            return StatusCode(500, new { mensaje = "Error Interno" });
        }
    }
}
