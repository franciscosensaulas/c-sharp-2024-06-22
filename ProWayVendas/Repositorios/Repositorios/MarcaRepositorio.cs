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

        public async Task<Marca> Add(Marca marca)
        {
            await _dbSet.AddAsync(marca);
            await _contexto.SaveChangesAsync();
            return marca;
        }

        public async Task Delete(Marca marca)
        {
            marca.RegistroAtivo = false;
            _dbSet.Update(marca);
            await _contexto.SaveChangesAsync();
        }

        public async Task<IList<Marca>> GetAll(string? nome, string? cnpj)
        {
            var query = _dbSet.Where(x => x.RegistroAtivo).AsQueryable();

            if (!string.IsNullOrEmpty(nome))
                query = query.Where(x => x.Nome.ToLower().Contains(nome.ToLower()));

            if (!string.IsNullOrEmpty(cnpj))
                query = query.Where(x => x.Cnpj.Contains(cnpj));

            query = query.OrderBy(x => x.Nome);

            return await query.ToListAsync();
        }

        public async Task<Marca?> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Marca marca)
        {
            _dbSet.Update(marca);
            await _contexto.SaveChangesAsync();
        }
    }
}
