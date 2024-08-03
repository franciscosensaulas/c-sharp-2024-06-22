namespace ExemploListaTiposPrimitivos
{
    internal class Exemplos
    {

        public void Exemplo00()
        {
            // Tipos primitivos: string, int, double, bool, char
            List<string> nomes = new List<string>();
            nomes.Add("Franchisco");
            nomes.Add("Igor");
            nomes.Add("Breno");
            nomes.Add("Caetano");
            nomes.Add("Lucas");
            nomes.Add("Yuri");
            nomes.Add("Taynara");
            nomes.Add("André");

            string primeiroNome = nomes[0];

            // Verificar se a lista contém o nome Francisco, nesse caso será false
            bool contemFrancisco = nomes.Contains("Francisco");

            // Obter o indice da lista refente ao Yuri, posição 5
            // Caso não existir o elemento, é retornado -1
            int indiceYuri = nomes.IndexOf("Yuri");

            // Remover um item da lista, no caso o Caetano
            bool removeuComSucesso = nomes.Remove("Caetano");

            // Obter a quantidade de elementos da lista
            int quantidadeElementosLista = nomes.Count;

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine($"""
                Contém Francisco: {contemFrancisco}
                Indice Yuri: {indiceYuri}
                Quantidade Elementos da lista: {quantidadeElementosLista}
                """);

        }
    }
}
