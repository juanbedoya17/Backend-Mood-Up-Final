using Microsoft.AspNetCore.Mvc;
using MoodUP_final.Data;
using MoodUP_final.Services.Interface;

namespace MoodUP_final.Services
{
    public class ConexionService : IConexion
    {
        private readonly MoodUpContext _context;

        public ConexionService (MoodUpContext context)
        {
            _context = context;
        }

       public bool ProbarConexion()
        {
            var conexion = _context.Database.CanConnect();
            return conexion;
        }
    }
}
