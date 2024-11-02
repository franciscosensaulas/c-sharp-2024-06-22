namespace Repositorios.Interfaces;

public interface IRepositorioBase<T>
{
    T Add(T entidade); // Adicionar
    void Update(T entidade); // Atualizar
    void Delete(T entidade); // Apagar
    IList<T> GetAll(); // ObterTodos
    T? GetById(int id); // ObterPorId
}