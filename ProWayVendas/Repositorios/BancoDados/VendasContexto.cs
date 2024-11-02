using Microsoft.EntityFrameworkCore;
using Repositorios.Mapeamentos;

namespace Repositorios.BancoDados
{
    public class VendasContexto : DbContext
    {
        // Instalar o CLI do dotnet ef
        // dotnet tool install --global dotnet-ef

        // Como gerar nova migration
        // dotnet ef migrations add <NomeMigracao>  --project Repositorios  --startup-project Web
        // Ex.: dotnet ef migrations add CriarTabelaCores  --project Repositorios  --startup-project Web

        // Atualizar o banco de dados aplicando as migrations
        // dotnet ef database update --project Repositorios  --startup-project Web

        // Migration: é um snapshot do código referente as tabelas do banco de dados

        public VendasContexto(DbContextOptions options): base(options)
        {
        }

        // Code First: do código será gerado o banco de dados
        // Database First: do banco de dados será gerado o código
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CorMapeamento());
            modelBuilder.ApplyConfiguration(new MarcaMapeamento());
            modelBuilder.ApplyConfiguration(new ModeloMapeamento());
        }
    }
}
