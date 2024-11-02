using Repositorios.Entidades;
using Servicos.Dtos.Modelo;

namespace Servicos.Builders;

public static class ModeloBuilder
{
    public static Modelo ConstruirCom(ModeloCadastrarDto dto, Marca marca)
    {
        return new Modelo
        {
            Nome = dto.Nome,
            Classificacao = dto.Classificacao,
            Marca = marca
        };
    }
}