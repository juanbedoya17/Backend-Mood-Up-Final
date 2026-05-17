// Añadir antes de builder.Build()
var frontendPolicy = "_allowFrontend";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: frontendPolicy, policy =>
    {
        policy.WithOrigins("http://localhost:5218", "http://192.168.0.12:5218") // ajustar orígenes del frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

var app = builder.Build();
app.UseCors(frontendPolicy);