using Repositorios.Entidades;
using Servicos.Dtos.Modelo;

namespace Servicos.Builders.Dtos;

public static class ModeloDtoBuilder
{
    public static IList<ModeloDto> ConstruirCom(IList<Modelo> modelos)
    {
        var modeloDtos = new List<ModeloDto>();
        foreach (var modelo in modelos)
            modeloDtos.Add(ConstruirCom(modelo));

        return modeloDtos;
    }

    public static ModeloDto ConstruirCom(Modelo modelo) =>
        new()
        {
            Id = modelo.Id,
            Classificacao = modelo.Classificacao,
            Marca = modelo.Marca.Nome,
            Nome = modelo.Nome,
        };
}