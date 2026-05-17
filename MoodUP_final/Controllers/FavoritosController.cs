//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using MoodUP_final.Data;
//using MoodUP_final.Models;
//using MoodUP_final.DBO;

//[Route("api/[controller]")]
//[ApiController]
//public class FavoritosController : ControllerBase
//{
//    private readonly MoodUpContext _context;

//    public FavoritosController(MoodUpContext context)
//    {
//        _context = context;
//    }

//    // GET: api/Favoritos/usuario/1
//    [HttpGet("usuario/{idUsuario}")]
//    public async Task<IActionResult> GetFavoritos(int idUsuario)
//    {
//        var lista = await _context.Favoritos
//            .Where(f => f.IdUsuario == idUsuario)
//            .Include(f => f.Contenido)
//            .Select(f => new
//            {
//                idFavorito = f.Id,
//                idContenido = f.IdContenido,
//                titulo = f.Contenido.Titulo,
//                descripcion = f.Contenido.Descripcion,
//                imagenUrl = f.Contenido.ImagenUrl,
//                trailerUrl = f.Contenido.TrailerUrl,
//                tipo = f.Contenido.Tipo,
//                plataforma = f.Contenido.Plataforma
//            })
//            .ToListAsync();

//        return Ok(lista);
//    }

//    // POST: api/Favoritos
//    [HttpPost]
//    public async Task<IActionResult> AgregarFavorito([FromBody] FavoritoDTO model)
//    {
//        var existe = await _context.Favoritos
//            .AnyAsync(f => f.IdUsuario == model.IdUsuario && f.IdContenido == model.IdContenido);

//        if (!existe)
//        {
//            _context.Favoritos.Add(new Favorito
//            {
//                IdUsuario = model.IdUsuario,
//                IdContenido = model.IdContenido
//            });

//            await _context.SaveChangesAsync();
//        }

//        return Ok(new { mensaje = "Contenido agregado a favoritos" });
//    }

//    // DELETE: api/Favoritos/usuario/1/contenido/2
//    [HttpDelete("usuario/{idUsuario}/contenido/{idContenido}")]
//    public async Task<IActionResult> EliminarFavorito(int idUsuario, int idContenido)
//    {
//        var registro = await _context.Favoritos
//            .FirstOrDefaultAsync(f => f.IdUsuario == idUsuario && f.IdContenido == idContenido);

//        if (registro == null)
//            return NotFound();

//        _context.Favoritos.Remove(registro);
//        await _context.SaveChangesAsync();

//        return Ok(new { mensaje = "Contenido eliminado de favoritos" });
//    }
//}
