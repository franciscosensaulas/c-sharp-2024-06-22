using Repositorios.Interfaces;
using Servicos.Builders;
using Servicos.Builders.Dtos;
using Servicos.Dtos.Modelo;
using Servicos.Interfaces;

namespace Servicos.Servicos;

public class ModeloServico : IModeloServico
{
    private readonly IModeloRepositorio _repositorio;
    private readonly IMarcaRepositorio _marcaRepositorio;

    public ModeloServico(IModeloRepositorio repositorio, IMarcaRepositorio marcaRepositorio)
    {
        _repositorio = repositorio;
        _marcaRepositorio = marcaRepositorio;
    }

    public int Cadastrar(ModeloCadastrarDto dto)
    {
        var marca = _marcaRepositorio.GetById(dto.MarcaId);

        if (marca is null)
            throw new Exception($"Marca não cadastrada com id {dto.MarcaId}");
        
        var modelo = ModeloBuilder.ConstruirCom(dto, marca);
        _repositorio.Add(modelo);
        return modelo.Id;
    }

    public void Editar(ModeloEditarDto dto)
    {
        throw new NotImplementedException();
    }

    public void Apagar(int id)
    {
        var modelo = _repositorio.GetById(id);
        if (modelo is null)
            throw new Exception("Modelo não encontrado");

        _repositorio.Delete(modelo);
    }

    public IList<ModeloDto> ObterTodos(string? nome, int? marcaId)
    {
        var modelos = _repositorio.GetAll();
        
        return ModeloDtoBuilder.ConstruirCom(modelos);
    }

    public ModeloDto ObterPorId(int id)
    {
        var modelo = _repositorio.GetById(id);
        if (modelo is null)
            throw new Exception("Modelo não encontrado");

        return ModeloDtoBuilder.ConstruirCom(modelo);
    }
}