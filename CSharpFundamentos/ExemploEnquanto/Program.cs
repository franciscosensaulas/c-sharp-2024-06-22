static void ExemploEnquanto01()
{
    // Apresentar o texto "olá mundo" 5 vezes
    int indice = 0;

    // Repertir enquanto o indice for menor que 5
    // enquanto (indice < 5) faca
    while (indice < 5)
    {
        Console.WriteLine("olá mundo");
        // Indice recebe indice + 1, ou seja,
        // na primeira vez será 0 + 1, que armazenará 1
        // na segunda vez será 1 + 1, que armazenará 2
        // assim por diante
        indice = indice + 1;
    }
}










static void ExemploEnquanto02()
{
    // Solicitar o nome e sobrenome de 3 pessoas
    int indice = 0;
    while (indice <= 2)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine("Nome completo: " + nomeCompleto);
        indice = indice + 1;
    }
}















static void ExemploEnquanto03()
{
    // Perguntar o nome, quantidade, preço unitário de 3 produtos, 
    // apresentando o total de cada um deles
    int indice = 0;
    double total = 0;
    Console.Write("Digite a quantidade desejada: ");
    int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
    while (indice < quantidadeDesejada)
    {
        Console.Write("Digite o produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a quantidade: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o preço unitário: ");
        double precoUnitario = Convert.ToDouble(Console.ReadLine());

        double totalProduto = quantidade * precoUnitario;
        Console.WriteLine("Total do produto: R$ " + totalProduto + "\n\n");
        // Acumular o valor total dos produtos, ou seja, quanto o cliente pagará
        total = total + totalProduto;
        indice = indice + 1;
    }
    Console.WriteLine("Total: R$ " + total);
}


static void ExemploEnquanto04()
{
    // Solicitar o
    //      nome do filme, min 2, máx 50
    // categoria e calcular o preço
    // Ação: 6,50
    // Comédia: 5,00
    // Ficção: 7,00
    // Terror: 4,50
    string desejaContinuar = "";
    double totalFilmes = 0;
    while (desejaContinuar != "não")
    {
        Console.Write("Digite o nome do filme: ");
        string nome = Console.ReadLine().Trim();
        while (nome.Length < 2 || nome.Length > 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome deve conter no mínimo 2 caracteres e no máximo 50.");
            Console.ResetColor();

            Console.Write("Digite o nome do filme: ");
            nome = Console.ReadLine().Trim();
        }

        Console.Write("Digite a categoria: ");
        string categoria = Console.ReadLine().Trim();
        while (categoria.ToLower() != "ação" &&
            categoria.ToLower() != "terror" &&
            categoria.ToLower() != "ficção" &&
            categoria.ToLower() != "comédia")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Categoria indisponível. Categorias possíveis: [Ação, Comédia, Ficção e Terror].");
            Console.ResetColor();

            Console.Write("Digite a categoria: ");
            categoria = Console.ReadLine().Trim();
        }


        bool quantidadeValida = false;
        int quantidadeDias = 0;
        while (quantidadeValida == false)
        {
            try
            {
                Console.Write("Digite a quantidade de dias para locação: ");
                quantidadeDias = Convert.ToInt32(Console.ReadLine());

                if ((quantidadeDias >= 1) && (quantidadeDias <= 5))
                {
                    quantidadeValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quantidade de dias para locação mínima é 1 dia e máxima 5 dias.");
                    Console.ResetColor();
                }
            }
            catch(FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quantidade de dias para locação deve ser um número inteiro válido.");
                Console.ResetColor();
            }
        }
        // Ação: 6,50
        // Comédia: 5,00
        // Ficção: 7,00
        // Terror: 4,50
        double preco = 0;
        if(categoria.ToLower() == "ação")
        {
            preco = 6.50;
        }
        else if (categoria.ToLower() == "comédia")
        {
            preco = 5;
        }
        else if (categoria.ToLower() == "ficção")
        {
            preco = 7;
        }
        else if (categoria.ToLower() == "terror")
        {
            preco = 4.50;
        }
        double precoAluguel = preco * quantidadeDias;
        Console.WriteLine("Preço: " + precoAluguel);

        totalFilmes = totalFilmes + precoAluguel;

        Console.Write("Deseja continuar? [sim/não]: ");
        desejaContinuar = Console.ReadLine().ToLower().Trim();
        Console.Clear();

        // ToLower() => transformar o texto em caixa baixa
        // Trim => Irá remover espaços do começo e do fim " a " => "a", " a b " => "a b"
    }

    Console.WriteLine("Total: " + totalFilmes);
}
// https://dontpad.com/franciscosensaulas
/**
 * Ex. 1: Solicitar o nome de 4 pacientes
 * Ex. 2: Solicitar o nome, peso e altura de 3 atletas, calculando e apresentando seu imc
 * Ex. 3: Solicitar o nome, sobrenome, nota 1, nota 2 e nota 3 de 5 alunos. Calcular a média e apresentar
 * Ex. 4: Solicitar o nome, sobrenome e apresentar o nome completo
 *          Nome deve conter no máximo 15 caracteres
 *          Sobrenome deve conter no mínimo 2 caracteres e no máximo 70
 * Ex. 5: Solicitar 10 números, apresentar a soma deles.
 *          Utilizar try catch na solicitação
 */



ExemploEnquanto04();
