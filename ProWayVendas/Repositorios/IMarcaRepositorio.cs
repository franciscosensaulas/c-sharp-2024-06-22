using Repositorios.Entidades;

namespace Repositorios.Repositorios
{
    internal interface IMarcaRepositorio
    {
        Marca Add(Marca marca); // Adicionar
        void Update(Marca marca); // Atualizar
        void Delete(Marca marca); // Apagar
        List<Marca> GetAll(); // ObterTodos
        Marca? GetById(int id); // ObterPorId
    }
}