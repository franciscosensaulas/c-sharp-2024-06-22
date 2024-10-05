namespace Web.ViewModels
{
    public enum ModeloClassificacao
    {
        Motocicleta,
        Carro,
        Caminhao,
        Utilitario
    }

    public class ModeloViewModel
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public string NomeMarca { get; set; }
        public string Nome { get; set; }
        public ModeloClassificacao Classificacao { get; set; }
    }
}
