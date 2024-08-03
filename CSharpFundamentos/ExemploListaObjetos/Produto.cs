namespace ExemploListaObjetos
{
    internal class Produto
    {
        public int Id;
        public string Nome;
        public int Quantidade;
        public double Preco;

        public double CalcularTotal()
        {
            return Quantidade * Preco;
        }
    }
}
