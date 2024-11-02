using Repositorios.Enums;

namespace Servicos.Dtos.Modelo;

public class ModeloCadastrarDto
{
    public int MarcaId { get; set; }
    public required string Nome { get; set; }
    public required ModeloClassificacao Classificacao { get; set; }
}