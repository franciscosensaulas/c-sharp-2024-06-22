using Repositorios.Entidades;

namespace Repositorios.Interfaces
{
    public interface ICorRepositorio
    {
        Cor Add(Cor cor); // Adicionar
        void Update(Cor cor); // Atualizar
        void Delete(Cor cor); // Apagar
        IList<Cor> GetAll(); // ObterTodos
        Cor? GetById(int id); // ObterPorId
    }
}
