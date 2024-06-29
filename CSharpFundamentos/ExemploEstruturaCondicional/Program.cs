static void ExemploIf01()
{
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    // se o número for igual a 0
    if (numero == 0)
    {
        Console.WriteLine("Zero");
    }
    // senão se o número for igual a 1
    else if (numero == 1)
    {
        Console.WriteLine("Um");
    }
    // senão se o número for igual a 2
    else if (numero == 2)
    {
        Console.WriteLine("Dois");
    }
    // senão se o número for igual a 3
    else if (numero == 3)
    {
        Console.WriteLine("Três");
    }
    // senão
    else
    {
        Console.WriteLine("Outro número");
    }
}


static void ExemploIfOperadoresRelacionais()
{
    int numero = 10;
    // Operadores relacionais
    // Igual            ==
    // Menor            <
    // Menor ou Igual   <=
    // Maior            >
    // Maior ou Igual   >= 
    // Diferente        !=

    // Verificar se o número é o menor que 100
    if (numero < 100)
    {
        Console.WriteLine("Número menor que 100");
    }
    // Verificar se o número é positivo
    if (numero > 0)
    {
        Console.WriteLine("Número positivo");
    }
    // Verificar se o número é maior ou igual a 8001
    if (numero >= 8001)
    {
        Console.WriteLine("Vulgo goku");
    }
}

static void ExemploIfNumeroPar()
{
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine("Número é par");
    }
    else
    {
        Console.WriteLine("Número não é par");
    }
}


static void ExemploIfNumeroImpar()
{
    Console.WriteLine("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 != 0)
    {
        Console.WriteLine("Número é ímpar");
    }
    else
    {
        Console.WriteLine("Número não é ímpar");
    }
}

static void ExemploIfColaborador()
{
    Console.Write("Digite o seu nome: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o seu cargo: ");
    string cargo = Console.ReadLine();
    // Estagiário: 1300
    // Junior: 3000,98
    // Pleno: 5000,00
    // Senior: 8000,00
    // Especialista I: 10000,00
    double salario = 0;
    if (cargo == "Estagiário")
    {
        salario = 1300;
    }
    else if (cargo == "Junior")
    {
        salario = 3000.98;
    }
    Console.WriteLine("Salário: " + salario);
}
// Ex. 1: Solicitar um número apresentando:
//        Se é positivo, negativo, neutro
//        Se é par ou ímpar
//        Se é superior a 10k
//        Se é inferior a -30
// Ex. 2: Solicitar a nota1, nota2, nota3
//        Calcular a média
//        Apresentar se o aluno está reprovado ou aprovado.

static void ExemploOperadorLogicoE()
{   // Aplicar desconto de 5% para produtos entre 2590 e 10000
    // Aplicar desconto de 10% para produtos entre 10000.01 e 200000
    // Aplicar desconto de 25% para produtos acima de 20000
    Console.Write("Digite o preço do produto: ");
    double valorProduto = Convert.ToDouble(Console.ReadLine()); // 9584,72
    int percentualDesconto = 0;

    if ((valorProduto >= 2_590) && (valorProduto <= 10_000))
    {
        percentualDesconto = 5;
    }
    else if ((valorProduto >= 10_000.01) && (valorProduto <= 20_000))
    {
        percentualDesconto = 10;
    }
    else if (valorProduto > 20_000)
    {
        percentualDesconto = 25;
    }

    double valorDesconto = 0;
    if (percentualDesconto > 0)
    {
        // 50000      100 
        // x          25
        // (50000 * 25) / 100 => valor do desconto => 12500
        valorDesconto = (valorProduto * percentualDesconto) / 100;
    }

    double valorTotal = valorProduto - valorDesconto;
    Console.WriteLine("Valor desconto: " + valorDesconto);
    Console.WriteLine("Valor total: " + valorTotal);
}

static void ExemploOperadorLogicoOu()
{
    Console.Write("Digite a categoria");
    string categoria = Console.ReadLine();
    double preco = 0;
    // se (categoria = "Ação") ou (categoria = "Suspense") entao
    if ((categoria == "Ação") || (categoria == "Suspense"))
    {
        preco = 4.75;
    }
    else
    {
        preco = 8.75;
    }
    Console.WriteLine("Preço do filme: " + preco);
}

ExemploOperadorLogicoE();