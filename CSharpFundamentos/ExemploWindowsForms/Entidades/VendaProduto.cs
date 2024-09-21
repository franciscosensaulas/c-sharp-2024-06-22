namespace ExemploWindowsForms.Entidades
{
    internal class VendaProduto
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }
        public int Quantidade { get; set; }
    }
}
