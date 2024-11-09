using Microsoft.Extensions.DependencyInjection;
using Repositorios.Interfaces;
using Repositorios.Repositorios;

namespace Repositorios.DependencyInjections
{
    public static class RepositorioDependencyInjection
    {
        public static IServiceCollection AddRepositorios(this IServiceCollection services)
        {
            services.AddScoped<ICorRepositorio, CorRepositorio>();
            services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();
            services.AddScoped<IModeloRepositorio, ModeloRepositorio>();

            return services;
        }
    }
}
