using Repositorios.Contexto;
using Repositorios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Repositorios
{
    internal class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly VendasContexto _contexto;

        public Marca Add(Marca marca)
        {
            throw new NotImplementedException();
        }

        public void Delete(Marca marca)
        {
            throw new NotImplementedException();
        }

        public List<Marca> GetAll()
        {
            throw new NotImplementedException();
        }

        public Marca? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
