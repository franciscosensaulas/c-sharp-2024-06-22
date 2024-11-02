using Servicos.Dtos.Modelo;

namespace Servicos.Interfaces;

public interface IModeloServico
{
    int Cadastrar(ModeloCadastrarDto dto);
    void Editar(ModeloEditarDto dto);
    void Apagar(int id);
    IList<ModeloDto> ObterTodos(string? nome, int? marcaId);
    ModeloDto ObterPorId(int id);
}