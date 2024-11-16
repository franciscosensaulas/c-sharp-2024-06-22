using Servicos.Dtos.Marca;

namespace Servicos.Interfaces
{
    public interface IMarcaServico
    {
        Task<int> Cadastrar(MarcaCadastrarDto dto);
        Task Editar(MarcaEditarDto dto);
        Task Apagar(int id);
        Task<IList<MarcaDto>> ObterTodos(string? nome = "", string? cnpj = "");
        Task<MarcaDto> ObterPorId(int id);
    }
}
