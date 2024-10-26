using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Repositorios
{
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly VendasContexto _contexto;
        private readonly DbSet<Marca> _dbSet;

        public MarcaRepositorio(VendasContexto contexto)
        {
            _contexto = contexto;
            _dbSet = _contexto.Set<Marca>();
        }

        public Marca Add(Marca marca)
        {
            _dbSet.Add(marca);
            _contexto.SaveChanges();
            return marca;
        }

        public void Delete(Marca marca)
        {
            marca.RegistroAtivo = false;
            _dbSet.Update(marca);
            _contexto.SaveChanges();
        }

        public IList<Marca> GetAll(string? nome, string? cnpj)
        {
            var query = _dbSet.Where(x => x.RegistroAtivo).AsQueryable();

            if (!string.IsNullOrEmpty(nome))
                query = query.Where(x => x.Nome.ToLower().Contains(nome.ToLower()));

            if (!string.IsNullOrEmpty(cnpj))
                query = query.Where(x => x.Cnpj.Contains(cnpj));

            query = query.OrderBy(x => x.Nome);

            return query.ToList();
        }

        public Marca? GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Marca marca)
        {
            _dbSet.Update(marca);
            _contexto.SaveChanges();
        }
    }
}
