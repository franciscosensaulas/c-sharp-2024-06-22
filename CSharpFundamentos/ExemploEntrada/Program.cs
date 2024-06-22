static void ExemploSoliciatacaoTipoString01() {
    // Entrada
    // Solicitar para o usuário o nome do aluno
    Console.Write("Digite o nome do aluno: ");
    string nomeAluno = Console.ReadLine();

    Console.Write("Digite o sobrenome do aluno: ");
    string sobrenome = Console.ReadLine();

    // Processamento
    string nomeCompleto = nomeAluno + " " + sobrenome;

    // Limpa tela
    Console.Clear();
    // Saída
    Console.WriteLine("Nome completo: " + nomeCompleto);
}

static void ExemploSolicitacaoTipoIntDouble01()
{
    Console.Write("Digite o nome do aluno: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o percentual da frequencia: ");
    int frequencia = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite a média: ");
    double media = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Frequencia: " + frequencia);
    Console.WriteLine("Média: " + media);
}

static void ExemploSolicitacaoTipoIntOperacoes()
{
    Console.Write("Número 1: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Número 2: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int soma = numero1 + numero2;
    int subtracao = numero1 - numero2;
    int multiplicacao = numero1 * numero2;
    double divisao = (double) numero1 / numero2;
    Console.WriteLine(
        "Soma: " + soma + 
        "\nSubtração: " + subtracao + 
        "\nMultiplicação: " + multiplicacao + 
        "\nDivisão: " + divisao);
}
/* Ex. 1: Solicitar o nome, peso e altura
 *        Calcular o imc e apresentar o IMC (procurar no Google fórmula do imc)
 * Ex. 2: Solicitar a idade 
 *        Calcular o ano de nascimento e apresentar
 * Ex. 3: Solicitar o ano de nascimento
 *        Calcular a idade e apresentar
 * Ex. 4: Solicitar nota1, nota2, nota3
 *        Calcular a média e apresentar
 * Ex. 5: Solicitar a temperatura em Celsius
 *        Converter para Kelvin e apresentar
 * Ex. 6: Solicitar a temperatura em Celsius
 *        Converter para Fahrenheit e apresentar
 * Ex. 7: Solicitar a largura e altura de um retangulo
 *        Calcular a área e apresentar
 * Ex. 8: Solicitar o valor em reais
 *        Realizar a conversão do valor para dolar, consultar a taxa do dolar no dia de hoje.
 *        Apresentar o valor em dolar convertido
 */

ExemploSolicitacaoTipoIntOperacoes();