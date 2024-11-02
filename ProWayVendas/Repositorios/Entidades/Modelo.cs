using Repositorios.Enums;

namespace Repositorios.Entidades
{
    public class Modelo : EntidadeBase
    {
        public string Nome { get; set; }
        public ModeloClassificacao Classificacao { get; set; }
        public Marca Marca { get; set; }
    }
}
