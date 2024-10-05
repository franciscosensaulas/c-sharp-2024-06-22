namespace Web.ViewModels
{
    public class VersaoViewModel
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public string NomeMarca { get; set; }
        public int IdModelo { get; set; }
        public string NomeModelo { get; set; }
        public string Nome { get; set; }
        public decimal Cilindrada { get; set; }
        public ModeloMotor Motor { get; set; }
        public ModeloTipo Tipo { get; set; }
    }
    // Código, Marca, Modelo, Nome, Cilindrada, Motor, Tipo, Ação
    public enum ModeloMotor
    {
        Aspirado,
        Turbo,
        BiTurbo,
        SuperCharger
    }

    public enum ModeloTipo
    {
        Suv,
        Sedan,
        Hatch,
        Coupe,
        Conversivel,
        PickUp,
        MiniVan,
        Van,
    }
}
