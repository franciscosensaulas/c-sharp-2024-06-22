using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Repositorios;

public class ModeloRepositorio : RepositorioBase<Modelo>, IModeloRepositorio
{
    public ModeloRepositorio(VendasContexto contexto) : base(contexto)
    {
    }

    public override IList<Modelo> GetAll()
    {
        return _dbSet
            .Include(x => x.Marca) // INNER JOIN com a tabela de marcas
            .ToList();
    }
}