using Microsoft.AspNetCore.Mvc;
using MoodUP_final.Models;

namespace MoodUP_final.Services.Interface
{
    public interface IContenido
    {
        Task<List<Contenido>> GetContenidos();

        Task<List<Contenido>> GetByEmocion(int id);
    }
}
