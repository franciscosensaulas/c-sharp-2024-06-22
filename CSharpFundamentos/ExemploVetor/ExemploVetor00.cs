namespace ExemploVetor
{
    internal class ExemploVetor00
    {
        public void Executar()
        {
            /*
             * string fruta1 = "Laranja";
            double preco1 = 1.50;

            string fruta2 = "Goiaba";
            double preco2 = 2.0;

            string fruta3 = "Banana";
            double preco3 = 1.75;
            */
            string[] frutas = new string[3];
            frutas[0] = "Laranja";
            frutas[1] = "Goiaba";
            frutas[2] = "Banana";

            frutas[1] = "Uva";

            Console.WriteLine($"""
                Frutas: 
                Primeira posição: {frutas[0]}
                Segunda posição: {frutas[1]}
                Terceira posição: {frutas[2]}
                Quantidade de frutas: {frutas.Length}
                """);
        }
    }
}
