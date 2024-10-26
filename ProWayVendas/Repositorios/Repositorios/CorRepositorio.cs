using Microsoft.EntityFrameworkCore;
using Repositorios.BancoDados;
using Repositorios.Entidades;
using Repositorios.Interfaces;

namespace Repositorios.Repositorios
{
    public class CorRepositorio : ICorRepositorio
    {
        private readonly VendasContexto _contexto;
        private readonly DbSet<Cor> _dbSet;

        public CorRepositorio(VendasContexto contexto)
        {
            _contexto = contexto;
            _dbSet = _contexto.Set<Cor>();
        }

        public Cor Add(Cor cor)
        {
            // Adicionando na tabela de cores a cor que foi instanciada
            _dbSet.Add(cor);
            // Concretizando o insert na base de dados
            // INSERT INTO cores (nome) VALUES ('Cinza');  Comando de exemplo
            _contexto.SaveChanges();
            return cor;
        }

        public void Delete(Cor cor)
        {
            // Remover a cor da lista de cores
            _dbSet.Remove(cor);
            // Concretizar o delete na tabela de cores
            // DELETE FROM cores WHERE id = 1;  Comando de exemplo
            _contexto.SaveChanges();
        }

        public IList<Cor> GetAll()
        {
            return _dbSet.ToList();
        }

        public Cor? GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Cor cor)
        {
            // Definindo o nome do objeto da cor que foi consultada na tabela de cores
            _dbSet.Update(cor);
            // Concretizando o atualização dos dados da cor
            // UPDATE cores SET nome = 'Cinza' WHERE id = 1; Comando de exemplo
            _contexto.SaveChanges();
        }
    }
}
