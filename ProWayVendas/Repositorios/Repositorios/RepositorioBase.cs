using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Repositorios;

public class RepositorioBase<T> : IRepositorioBase<T> where T: EntidadeBase
{
    private readonly VendasContexto _contexto;
    protected readonly DbSet<T> _dbSet;

    public RepositorioBase(VendasContexto contexto)
    {
        _contexto = contexto;
        _dbSet = _contexto.Set<T>();
    }

    public T Add(T entidade)
    {
        _dbSet.Add(entidade);
        _contexto.SaveChanges();
        return entidade;
    }

    public void Update(T entidade)
    {
        _dbSet.Update(entidade);
        _contexto.SaveChanges();
    }

    public void Delete(T entidade)
    {
        entidade.RegistroAtivo = false;
        _dbSet.Update(entidade);
        _contexto.SaveChanges();
    }

    public virtual IList<T> GetAll() => 
        _dbSet.ToList();

    public T? GetById(int id) => 
        _dbSet.FirstOrDefault(x => x.Id == id);
}