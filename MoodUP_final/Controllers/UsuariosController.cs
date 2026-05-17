using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services;
using MoodUP_final.Services.Interface;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IUsuarios _usuariosService;
    private readonly EmailService _emailService;

    public UsuariosController(IUsuarios usuariosService, EmailService emailService)
    {
        _usuariosService = usuariosService;
        _emailService = emailService;
    }

    // ==========================================================
    // ENDPOINT 1: REGISTRO DE USUARIO (POST: /api/Usuarios/registro)
    // ==========================================================
    [HttpPost("registro")]
    public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioRegistroDTO registroDto)
    {
        var Resultado = await _usuariosService.RegistrarUsuario(registroDto);

        if (!Resultado.ok)
        {
            return BadRequest(Resultado.Message);
        }
        
        var mensaje = $@"
<h2>🎉 Bienvenido a MoodUp</h2>
<p>Hola <strong>{registroDto.nombreUsuario}</strong>,</p>
<p>Tu cuenta fue creada exitosamente 🚀</p>
<p>Ya puedes iniciar sesión en la app.</p>
<br/>
<small>Equipo MoodUp 💙</small>
";

       try {
            await _emailService.EnviarCorreo(registroDto.correo, "¡Bienvenido a MoodUp! 🎉", mensaje);
        }
        catch (Exception ex)
        {
            // Manejo de errores al enviar el correo
            Console.WriteLine($"Error al enviar el correo: {ex.Message}");
        }

            // Respuesta exitosa (Código 201 Created)
            return StatusCode(201, Resultado);
    }

    // ==========================================================
    // ENDPOINT 2: INICIO DE SESIÓN (POST: /api/Usuarios/login)
    // ==========================================================
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UsuarioLoginDTO loginDto)
    {
        var Resultado = await _usuariosService.Login(loginDto);

        if (!Resultado.ok)
        {
            return BadRequest(new
            {
                ok = false,
                message = Resultado.Message
            });
        }

        // Respuesta exitosa (Código 201 Created)
        return Ok(new
        {
            ok = true,
            message = Resultado.Message,
            idUsuario = Resultado.IdUsuario
        });
    }
}