using Repositorios.Enums;

namespace Servicos.Dtos.Modelo;

public class ModeloDto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required ModeloClassificacao Classificacao { get; set; }
    public required string Marca { get; set; }
}