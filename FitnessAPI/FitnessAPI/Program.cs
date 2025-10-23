using FitnessAPI.Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

////////////AREA DE SERVICIOS!!!

builder.Services.AddControllers();

//configurar connectionString
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection"));



var app = builder.Build();

////////////AREA DE MIDDLWARES !!!

app.MapControllers();




app.Run();
