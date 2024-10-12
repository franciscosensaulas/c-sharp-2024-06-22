using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Entidades;

namespace Web.Mapeamentos
{
    public class CorMapeamento : IEntityTypeConfiguration<Cor>
    {
        public void Configure(EntityTypeBuilder<Cor> builder)
        {
            // Definir qual será o nome da tabela no banco de dados
            builder.ToTable("cores");

            // Definir que a chave primária será a propriedade Id da classe Cor
            builder.HasKey(cor => cor.Id);

            builder.Property(cor => cor.Nome)
                .IsRequired() // Aqui é definido que a coluna é NOT NULL, ou seja, requerida
                .HasMaxLength(45);
        }
    }
}
