using ExemploWindowsForms.Entidades;

namespace ExemploWindowsForms.Repositorios.Interfaces
{
    internal interface IVendaRepositorio
    {
        int AbrirVenda(Venda venda);
        void FecharVenda(int id);
        void CancelarVenda(int id, string motivo);
        Venda? ObterAbertaPorIdCliente(int idCliente);
        decimal? ObterTotalVenda(int id);
    }
}