using Repositorios.Entidades;
using Repositorios.Interfaces;
using Servicos.Dtos.Cor;
using Servicos.Interfaces;

namespace Servicos.Servicos
{
    public class CorServico : ICorServico
    {
        private readonly ICorRepositorio _repositorio;

        public CorServico(ICorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Apagar(int id)
        {
            // Consultando a cor filtrando por id
            var cor = _repositorio.GetById(id);
            // Caso não encontrar a cor retornar 404 (not found)
            if (cor is null)
                throw new Exception("Cor não encontrada");

            _repositorio.Delete(cor);
        }

        public int Cadastrar(CorCadastrarDto dto)
        {
            var cor = new Cor
            {
                Nome = dto.Nome,
            };
            _repositorio.Add(cor);
            return cor.Id;
        }

        public void Editar(CorEditarDto dto)
        {
            var cor = _repositorio.GetById(dto.Id);
            if (cor is null)
                throw new Exception("Cor não encontrada");

            cor.Nome = dto.Nome;

            _repositorio.Update(cor);
        }

        public CorDto ObterPorId(int id)
        {
            var cor = _repositorio.GetById(id);
            if (cor is null)
                throw new Exception("Cor não encontrada");

            return new CorDto
            {
                Id = cor.Id,
                Nome = cor.Nome,
            };
        }

        public IList<CorDto> ObterTodos()
        {
            // Consultar todas as cores
            var cores = _repositorio.GetAll();

            var dtos = new List<CorDto>();
            foreach (var cor in cores)
            {
                var dto = new CorDto
                {
                    Id = cor.Id,
                    Nome = cor.Nome,
                };
                dtos.Add(dto);
            }
            return dtos;
        }
    }
}
