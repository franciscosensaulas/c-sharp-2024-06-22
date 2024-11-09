using Microsoft.Extensions.DependencyInjection;
using Servicos.Interfaces;
using Servicos.Servicos;

namespace Servicos.DependencyInjections
{
    public static class ServicoDependencyInjection
    {
        public static IServiceCollection AddServicos(this IServiceCollection services)
        {
            services.AddScoped<ICorServico, CorServico>();
            services.AddScoped<IMarcaServico, MarcaServico>();
            services.AddScoped<IModeloServico, ModeloServico>();

            return services;
        }
    }
}
