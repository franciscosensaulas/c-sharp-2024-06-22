using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.Interfaces;
using Repositorios.Repositorios;
using Servicos.Interfaces;
using Servicos.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


// Dependecy Injection
builder.Services.AddScoped<ICorServico, CorServico>();
builder.Services.AddScoped<ICorRepositorio, CorRepositorio>();
builder.Services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();
builder.Services.AddScoped<IMarcaServico, MarcaServico>();
builder.Services.AddScoped<IModeloRepositorio, ModeloRepositorio>();
builder.Services.AddScoped<IModeloServico, ModeloServico>();

// Adicionar o VendasContexto que � classe que tem a heran�a de DbContext,
// que permitir� manipular o nosso banco de dados
builder.Services.AddDbContext<VendasContexto>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); 

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
