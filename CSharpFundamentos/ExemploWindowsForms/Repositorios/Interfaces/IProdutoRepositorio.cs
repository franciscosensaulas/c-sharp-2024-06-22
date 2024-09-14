using ExemploWindowsForms.Entidades;

namespace ExemploWindowsForms.Repositorios.Interfaces
{
    internal interface IProdutoRepositorio
    {
        List<Produto> ObterTodos(string pesquisa, int? categoriaId = null);
        int Adicionar(Produto produto);
        Produto? ObterPorId(int id);
        void Apagar(int id);
        bool Existe(int id);
        void Editar(Produto produto);
    }
}
