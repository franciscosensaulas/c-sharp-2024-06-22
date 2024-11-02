using Servicos.Dtos.Marca;

namespace Servicos.Interfaces
{
    public interface IMarcaServico
    {
        int Cadastrar(MarcaCadastrarDto dto);
        void Editar(MarcaEditarDto dto);
        void Apagar(int id);
        IList<MarcaDto> ObterTodos(string? nome, string? cnpj);
        MarcaDto ObterPorId(int id);
    }
}
