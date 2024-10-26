using Servicos.Dtos.Cor;

namespace Servicos.Interfaces
{
    public interface ICorServico
    {
        int Cadastrar(CorCadastrarDto dto);
        void Editar(CorEditarDto dto);
        void Apagar(int id);
        IList<CorDto> ObterTodos();
        CorDto ObterPorId(int id);
    }
}
