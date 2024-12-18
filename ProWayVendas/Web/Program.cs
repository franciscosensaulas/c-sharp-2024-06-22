using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.DependencyInjections;
using Servicos.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Dependecy Injection
builder.Services
    .AddRepositorios()
    .AddServicos()
    .AddDataBase(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app
    .UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using(var scopo = app.Services.CreateScope())
{
    var contexto = scopo.ServiceProvider.GetService<VendasContexto>();
    contexto.Database.Migrate();
}

app.Run();
