using ExemploWindowsForms.Entidades;

namespace ExemploWindowsForms.Repositorios.Interfaces
{
    internal interface IVendaProdutoRepositorio
    {
        void AdicionarItem(VendaProduto vendaProduto);
        void RemoverItem(int vendaProdutoId);
        void AtualizarItem(VendaProduto vendaProduto);
        IList<VendaProduto> ObterTodosPorIdVenda(int idVenda);
    }
}
