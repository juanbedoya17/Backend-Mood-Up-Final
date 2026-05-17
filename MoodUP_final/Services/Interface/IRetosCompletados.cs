using Microsoft.AspNetCore.Mvc;
using MoodUP_final.DTOs;
using MoodUP_final.Models;

namespace MoodUP_final.Services.Interface
{
    public interface IRetosCompletados
    {
        Task<List<int>> GetRetosCompletados(int idUsuario);

        Task MarcarReto(RetoCompletadoDTO model);

        Task DeleteReto(int idUsuario, int idReto);
    }
}
