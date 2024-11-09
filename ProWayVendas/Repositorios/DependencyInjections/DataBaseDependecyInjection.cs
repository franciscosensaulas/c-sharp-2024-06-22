using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorios.BancoDados;

namespace Repositorios.DependencyInjections
{
    public static  class DataBaseDependecyInjection
    {
        public static IServiceCollection AddDataBase(
            this IServiceCollection services,
            IConfigurationManager configuration)
        {
            // Adicionar o VendasContexto que � classe que tem a heran�a de DbContext,
            // que permitir� manipular o nosso banco de dados
            services.AddDbContext<VendasContexto>(options => options.UseSqlServer(
                configuration.GetConnectionString("SqlServer")));
            return services;

        }
    }
}
