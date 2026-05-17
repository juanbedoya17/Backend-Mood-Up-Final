//using Microsoft.AspNetCore.Mvc;
//using MoodUP_final.Data;
//using MoodUP_final.Models;
//using MoodUP_final.Services;
//using MoodUP_final.Services.Interface;
//using System.Linq;
//using System.Threading.Tasks;

//[Route("api/[controller]")]
//[ApiController]
//public class CalificacionContenidoController : ControllerBase
//{
//    private readonly MoodUpContext _context;
//    private readonly ICalificacion _clasificacion;

//    public CalificacionContenidoController(MoodUpContext context, ICalificacion clasificacion)
//    {
//        _context = context;
//        _clasificacion = clasificacion;
//    }

//    // ============================
//    // OBTENER CALIFICACIÓN
//    // ============================
//    [HttpGet("usuario/{idUsuario}/contenido/{idContenido}")]
//    public IActionResult GetCalificacionUsuario(int idUsuario, int idContenido)
//    {
//        //var item = _context.CalificacionContenido
//        //    .FirstOrDefault(c => c.IdUsuario == idUsuario && c.IdContenido == idContenido);
//        var item = this._clasificacion.GetCalificacionUsuario(idUsuario, idContenido);

//        return Ok(new { puntuacion = item?.Puntuacion ?? 0 });
//    }

//    // ============================
//    // GUARDAR / ACTUALIZAR
//    // ============================
//    [HttpPost]
//    public IActionResult Guardar([FromBody] CalificacionContenido model)
//    {
//        var item = _context.CalificacionContenido
//            .FirstOrDefault(c => c.IdUsuario == model.IdUsuario && c.IdContenido == model.IdContenido);

//        if (item == null)
//        {
//            _context.CalificacionContenido.Add(model);
//        }
//        else
//        {
//            item.Puntuacion = model.Puntuacion;
//            _context.CalificacionContenido.Update(item);
//        }

//        _context.SaveChanges();
//        return Ok();
//    }

//    // ============================
//    // BORRAR CALIFICACIÓN
//    // ============================
//    [HttpDelete("borrar")]
//    public IActionResult Borrar([FromQuery] int usuarioId, [FromQuery] int contenidoId)
//    {
//        var item = _context.CalificacionContenido
//            .FirstOrDefault(c => c.IdUsuario == usuarioId && c.IdContenido == contenidoId);

//        if (item == null) return NotFound();

//        _context.CalificacionContenido.Remove(item);
//        _context.SaveChanges();

//        return Ok();
//    }
//}
