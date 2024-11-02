using System.ComponentModel;

namespace Repositorios.Enums
{
    public enum ModeloClassificacao
    {
        [Description("Moto")]
        Motocicleta,
        [Description("Carro")]
        Carro,
        [Description("Caminhão")]
        Caminhao,
        [Description("Utilitário")]
        Utilitario
    }
}
