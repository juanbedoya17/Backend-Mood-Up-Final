using Microsoft.AspNetCore.Mvc;
using MoodUP_final.Data;
using MoodUP_final.Models;
using MoodUP_final.DTOs;

namespace MoodUP_final.Services.Interface
{
    public interface IRegistroEmociones
    {
        Task<int> RegistrarEmocion(RegistroEmocionDTO registroDto);
        Task<IEnumerable<object>> GetHistorial(int idUsuario);
    }
}
