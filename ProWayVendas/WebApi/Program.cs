using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.DependencyInjections;
using Servicos.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRepositorios()
    .AddServicos()
    .AddDataBase(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using(var scopo = app.Services.CreateScope())
{
    var contexto = scopo.ServiceProvider.GetService<VendasContexto>();
    contexto.Database.Migrate();
}

app.Run();