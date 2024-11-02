using Repositorios.Entidades;
using Repositorios.Interfaces;
using Servicos.Dtos.Marca;
using Servicos.Interfaces;

namespace Servicos.Servicos
{
    public class MarcaServico : IMarcaServico
    {
        private readonly IMarcaRepositorio _repositorio;

        public MarcaServico(IMarcaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Apagar(int id)
        {
            // Consultando a marca filtrando por id
            var marca = _repositorio.GetById(id);
            // Caso não encontrar a marca retornar 404 (not found)
            if (marca is null)
                throw new Exception("Marca não encontrada");

            _repositorio.Delete(marca);
        }

        public int Cadastrar(MarcaCadastrarDto dto)
        {
            var marca = new Marca
            {
                Nome = dto.Nome,
                Cnpj = dto.Cnpj,
                Descricao = dto.Descricao,
            };
            _repositorio.Add(marca);
            return marca.Id;
        }

        public void Editar(MarcaEditarDto dto)
        {
            var marca = _repositorio.GetById(dto.Id);
            if (marca is null)
                throw new Exception("Marca não encontrada");

            marca.Nome = dto.Nome;
            marca.Descricao = dto.Descricao;
            marca.Cnpj = dto.Cnpj;

            _repositorio.Update(marca);
        }

        public MarcaDto ObterPorId(int id)
        {
            var marca = _repositorio.GetById(id);
            if (marca is null)
                throw new Exception("Marca não encontrada");

            return new MarcaDto
            {
                Id = marca.Id,
                Nome = marca.Nome,
                Cnpj = marca.Cnpj,
                Descricao = marca.Descricao,
            };
        }

        public IList<MarcaDto> ObterTodos(string? nome, string? cnpj)
        {
            // Consultar todas as marcaes
            var marcaes = _repositorio.GetAll(nome, cnpj);

            var dtos = new List<MarcaDto>();
            foreach (var marca in marcaes)
            {
                var dto = new MarcaDto
                {
                    Id = marca.Id,
                    Nome = marca.Nome,
                    Cnpj = marca.Cnpj,
                };
                dtos.Add(dto);
            }
            return dtos;
        }
    }
}
