using MikaruEmcora.Application.Interfaces;
using MikaruEmcora.Application.Services;
using MikaruEmcora.Core.Repositories;
using MikaruEmcora.Core.Repositories.Base;
using MikaruEmcora.Infraestructure.Data;
using MikaruEmcora.Infraestructure.Repository;
using MikaruEmcora.Infraestructure.Repository.Base;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();






//configuracion de inyeccion de dependencias
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); //todos los constructores que usen irepository, los cambiaran por entidad repository
builder.Services.AddScoped<IMediaRepository, MediaRepository>();

//para bbbdd en memoria (esta la cadena en appsettings development json)
builder.Services.AddDbContext<MikaruEmcoraContext>(c =>
c.UseInMemoryDatabase("MikaruEmcoraConnection"));


builder.Services.AddScoped<IMediaService, MediaService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//si queremos añadir nuevos servicios/repositiorios debemos añadir su par interfaz y clase aqui






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
