using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.DTOs;
using MoodUP_final.Models;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class UsuariosService : IUsuarios
    {
        private readonly MoodUpContext _context;
        
        public UsuariosService (MoodUpContext context)
        {
            _context = context; 
        }
        public async Task<(bool ok, string Message, int IdUsuario)> RegistrarUsuario(UsuarioRegistroDTO registroDto)
        {
            // 1. Verificar si el correo ya existe
            var usuarioExistente = await _context.Usuario // o _context.Usuarios si es plural
            .FirstOrDefaultAsync(u => u.Correo == registroDto.correo);
            
            if (usuarioExistente != null)
                return (false, "El correo ya está registrado. Por favor, use otro correo.", 0);
            string has = BCrypt.Net.BCrypt.HashPassword(registroDto.contrasena);

            var nuevoUsuario = new Usuario
            {
                NombreUsuario = registroDto.nombreUsuario,
                Correo = registroDto.correo,
                Contrasena = has, // Se guarda el has, no la contraseña original
                FechaRegistro = DateTime.Now
            };

            _context.Usuario.Add(nuevoUsuario);
            await _context.SaveChangesAsync();

            return (true, "Ok", nuevoUsuario.IdUsuario);
        }

        public async Task<(bool ok, string Message, int IdUsuario)> Login(UsuarioLoginDTO loginDto)
        {
            var usuario = await _context.Usuario 
                .FirstOrDefaultAsync(u => u.Correo == loginDto.Correo);

            // 401 si el usuario no existe (no dar más detalles por seguridad)
            if (usuario == null)
            {
                return (false, "Usuario no registrado", 0);
            }

            // 2. Verificar la contraseña comparando el texto plano con el hash almacenado
            bool esValido = BCrypt.Net.BCrypt.Verify(loginDto.Contrasena, usuario.Contrasena);

            if (!esValido)
            {
                //  si la contraseña no coincide
                return (false, "Credenciales inválidas.", 0);
            }

            // Autenticación exitosa (200 OK)
            return (true, "Login Correcto, bienvenido de nuevo", usuario.IdUsuario);
        }
    }
}
