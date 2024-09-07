using ExemploWindowsForms.Entidades;

namespace ExemploWindowsForms.Repositorios
{
    internal interface IProdutoRepositorio
    {
        List<Produto> ObterTodos(string pesquisa, int? categoriaId);
        int Adicionar(Produto produto);
        Produto? ObterPorId(int id);
        void Apagar(int id);
        bool Existe(int id);
        void Editar(Produto produto);
    }
}
