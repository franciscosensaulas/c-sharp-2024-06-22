using Repositorios.Entidades;

namespace Repositorios.Interfaces
{
    public interface IMarcaRepositorio
    {
        Marca Add(Marca marca); // Adicionar
        void Update(Marca marca); // Atualizar
        void Delete(Marca marca); // Apagar
        IList<Marca> GetAll(string? nome, string? cnpj); // ObterTodos
        Marca? GetById(int id); // ObterPorId
    }
}