using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspneCtcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    c.EnableAnnotations(); // This is where we enable annotations for Swagger
    // You can also add XML documentation if needed:
    // c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "YourApi.xml"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("Angular", builder => 
        builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("Angular");

using(var scopo = app.Services.CreateScope())
{
    var contexto = scopo.ServiceProvider.GetService<VendasContexto>();
    contexto.Database.Migrate();
}

app.Run();