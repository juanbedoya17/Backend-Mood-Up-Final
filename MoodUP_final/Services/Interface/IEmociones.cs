using Microsoft.AspNetCore.Mvc;
using MoodUP_final.DTOs;
using MoodUP_final.Models;


namespace MoodUP_final.Services.Interface
{
    public interface IEmociones
    {
        Task<List<Emocion>> GetEmociones();
    }
}
