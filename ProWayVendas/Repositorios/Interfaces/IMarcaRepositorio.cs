using Repositorios.Entidades;

namespace Repositorios.Interfaces
{
    public interface IMarcaRepositorio
    {
        Task<Marca> Add(Marca marca); // Adicionar
        Task Update(Marca marca); // Atualizar
        Task Delete(Marca marca); // Apagar
        Task<IList<Marca>> GetAll(string? nome, string? cnpj); // ObterTodos
        Task<Marca?> GetById(int id); // ObterPorId
    }
}