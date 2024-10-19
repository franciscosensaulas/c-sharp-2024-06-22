using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Entidades;

namespace Web.Mapeamentos
{
    public class MarcaMapeamento : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("marcas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x => x.Cnpj)
                .HasColumnType("CHAR")
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(x => x.RegistroAtivo)
                .HasColumnType("BIT")
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("TEXT");
        }
    }
}
