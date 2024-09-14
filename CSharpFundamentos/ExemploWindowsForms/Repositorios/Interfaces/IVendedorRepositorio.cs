using ExemploWindowsForms.Entidades;

namespace ExemploWindowsForms.Repositorios.Interfaces
{
    internal interface IVendedorRepositorio
    {
        List<Vendedor> ObterTodos();
        int Adicionar(Vendedor vendedor);
        Vendedor? Autenticar(string usuario, string senha);
    }
}
