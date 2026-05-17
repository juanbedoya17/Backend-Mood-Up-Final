using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MoodUP_final.Data;
using MoodUP_final.Services;
using MoodUP_final.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// ====================================================================
// 1. CONFIGURACIÓN DE SERVICIOS
// ====================================================================

// Habilitar CORS para permitir llamadas desde tu frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy
            .AllowAnyOrigin()     // Permite cualquier origen (ideal mientras desarrollas)
            .AllowAnyMethod()
            .AllowAnyHeader());
});

// Conexión con SQL Server
var connectionString = builder.Configuration.GetConnectionString("MoodUpConnection");

builder.Services.AddDbContext<MoodUpContext>(options =>
    options.UseSqlServer(connectionString));

// Activar controladores API
builder.Services.AddControllers();

// Services
builder.Services.AddScoped<ICalificacion, CalificacionService>();
builder.Services.AddScoped<IReto, RetoService>();
builder.Services.AddScoped<IUsuarios, UsuariosService>();
builder.Services.AddScoped<IRetosCompletados, RetosCompletadosService>();
builder.Services.AddScoped<IRegistroEmociones, RegistroEmocionesService>();
builder.Services.AddScoped<IContenido, ContenidoService>();
builder.Services.AddScoped<IConexion, ConexionService>();
builder.Services.AddScoped<IEmociones, EmocionesService>();
builder.Services.AddScoped<EmailService>();

// Swagger (solo para desarrollo)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ====================================================================
// 2. PIPELINE HTTP
// ====================================================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Habilitar redirección HTTPS
app.UseHttpsRedirection();

// ACTIVAR CORS (si no está aquí, NO FUNCIONA)
app.UseCors("AllowFrontend");

app.UseAuthorization();

// Mapear controladores
app.MapControllers();

app.Run();


