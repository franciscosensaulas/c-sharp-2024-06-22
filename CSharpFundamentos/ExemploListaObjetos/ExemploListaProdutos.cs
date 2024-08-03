using System.Text.Json.Serialization;

namespace ExemploListaObjetos
{
    internal class ExemploListaProdutos
    {
        private int idAtual = 0;
        private List<Produto> Produtos = new List<Produto>();

        // Método sem retorno sem parâmetros
        public void Adicionar()
        {
            var produto = new Produto();

            // Pré incremento i++
            // Pós incremento ++i

            // Definir o id do produto que está sendo cadastrado
            produto.Id = ++idAtual;

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine().Trim();

            Console.Write("Quantidade: ");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço: ");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            Produtos.Add(produto);
        }

        public void ListarTodos()
        {
            if(Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado!\n");
                return;
            }

            Console.WriteLine("Produtos: ");
            for (int i = 0; i < Produtos.Count; i++)
            {
                var produto = Produtos[i];
                Console.WriteLine($"""
                    Id: {produto.Id}
                    Nome: {produto.Nome}
                    Quantidade: {produto.Quantidade}
                    Preco: {produto.Preco}
                    Total: {produto.CalcularTotal()}

                    """);
            }
        }

        public void Apagar() {
            Console.WriteLine("Produtos: ");
            for (int i = 0; i < Produtos.Count; i++)
            {
                var produto = Produtos[i];
                Console.WriteLine($"{produto.Id} {produto.Nome}");
            }

            Console.Write("Digite o código do produto que deseja apagar: ");
            var codigoApagar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Produtos.Count; i++)
            {
                var produto = Produtos[i];
                if (produto.Id == codigoApagar)
                {
                    Produtos.RemoveAt(i);
                    Console.WriteLine($"Produto '{produto.Nome}' apagado com sucesso");
                    return;
                }
            }

            Console.WriteLine("Produto não encontrado");
        }

        public void Editar()
        {
            Console.WriteLine("Produtos: ");
            for (int i = 0; i < Produtos.Count; i++)
            {
                var produto = Produtos[i];
                Console.WriteLine($"{produto.Id} {produto.Nome}");
            }
            Console.Write("Digite o código do produto que deseja editar: ");
            var codigoEditar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Produtos.Count; i++)
            {
                var produto = Produtos[i];
                if (produto.Id == codigoEditar)
                {
                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine().Trim();

                    Console.Write("Quantidade: ");
                    produto.Quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Preço: ");
                    produto.Preco = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Produto '{produto.Nome}' alterado com sucesso");
                    return;
                }
            }
            Console.WriteLine("Produto não encontrado");
            /*
                Ex.1: Criar uma classe chamada Cliente com as seguintes propriedades: 
                    - Id
                    - Nome
                    - Cpf
                Ex. 2: Criar uma classe chamada Agendamento com as seguintes propriedades:
                    - Id
                    - Data e Hora
                    - Descrição
                    - Fornecedor (texto)
            */
        }
    }
}
