using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorios.Entidades;

namespace Repositorios.Mapeamentos
{
    public class ModeloMapeamento : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("modelos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Classificacao)
                .IsRequired();

            builder.HasOne(x => x.Marca)
                .WithMany(x => x.Modelos)
                .IsRequired();

            builder.Property(x => x.RegistroAtivo)
                .HasColumnType("BIT")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.CriadoEm)
                .HasColumnType("DATETIME2")
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(x => x.AtualizadoEm)
                .HasColumnType("DATETIME2");
        }
    }
}
