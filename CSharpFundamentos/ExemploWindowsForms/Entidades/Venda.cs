using ExemploWindowsForms.Enums;

namespace ExemploWindowsForms.Entidades
{
    internal class Venda
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public Vendedor? Vendedor { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public DateTime? DataHoraFechamento { get; set; }
        public VendaStatus  Status { get; set; }
        public string? MotivoCancelamento { get; set; }
        public decimal? Valor { get; set; }

        public IList<VendaProduto> Carrinho { get; set; }
    }
}
