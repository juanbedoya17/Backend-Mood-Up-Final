using Microsoft.AspNetCore.Mvc;
using MoodUP_final.DTOs;
using MoodUP_final.Models;

namespace MoodUP_final.Services.Interface
{
    public interface IUsuarios
    {
        // Lo que recibe el service de registro de usuario
        Task <(bool ok, string Message, int IdUsuario)> 
            RegistrarUsuario(UsuarioRegistroDTO registroDto);

        // Lo que recibe el service de login
        Task<(bool ok, string Message, int IdUsuario)> 
            Login(UsuarioLoginDTO loginDto);
    }
}
