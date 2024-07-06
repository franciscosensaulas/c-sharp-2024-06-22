static void ExemploFor01()
{
    /*
     * Solicitar o nome e sobrenome de 3 pessoas
     * int indice = 0;
     * while (indice <= 2)
     * 
     * For é um comando utilizado para percorrer um ponto até outro, ou seja, de um número até outro
     * for(inicialização da variável; condição para repetição; incremento)
     */
    for (int indice = 0; indice <= 2; indice = indice + 1)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o sobrenome: ");
        string sobrenome = Console.ReadLine();

        string nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine("Nome completo: " + nomeCompleto);
        // indice = indice + 1;
    }
}

// https://dontpad.com/franciscosensaulas/c#
static void ExemploFor02()
{
    /*
        * 00:00:00
        * 00:00:01
        * 00:00:02
        * ........
        * 00:00:59
        * 00:01:00
        * 00:01:01
        * ........
        * 00:59:59
        * 01:00:00
        * 01:00:01
        * ........
        * 23:59:59
        * 00:00:00
        */
    for (int hora = 0; hora < 24; hora = hora + 1)
    {
        for (int minuto = 0; minuto < 60; minuto = minuto + 1)
        {
            for (int segundo = 0; segundo <= 59; segundo = segundo + 1)
            {
                string horaFormatada = string.Format("{0:D2}", hora);
                string minutoFormatada = string.Format("{0:D2}", minuto);
                string segundoFormatada = string.Format("{0:D3}", segundo);
                Console.WriteLine(horaFormatada + ":" + minutoFormatada + ":" + segundoFormatada);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}

static void ExemploFor03()
{
    for (int indice = 10; indice >= 0; indice = indice - 1)
    {
        Console.WriteLine(indice);
        Thread.Sleep(300); // Pausa de 1s
        Console.Clear();
    }
    DateTime dataHoraAtual = DateTime.Now;
    int anoAtual = dataHoraAtual.Year + 1;
    Console.WriteLine(string.Format("Feliz ano novo! Ótimo {0}", anoAtual));
}

static void ExemploFor04()
{
    /*
     Solicitar números de acordo com a quantidade desejada do usuário e apresentar:
        - ✔ Média dos números
        - ✔ Soma dos números
        - ✔ Maior número
        - ✔ Menor número
        - ✔ Quantidade números negativos
        - ✔ Quantidade números positivos
        - ✔ Quantidade números pares
        - ✔ Quantidade números ímpares
        - Menor número par
     */
    Console.Write("Digite a quantidade de números que deseja cadastrar: ");
    int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());
    int soma = 0;
    int maiorNumero = 0;
    int menorNumero = 999999999; // int.MaxValue;
    int quantidadeNumeroNegativos = 0;
    int quantidadeNumeroPositivos = 0;
    int quantidadeNumerosPares = 0;
    int quantidadeNumerosImpares = 0;
    int menorNumeroPar = 999999999;
    for (int indice = 0; indice < quantidadeDesejada; indice = indice + 1)
    {
        Console.Write("Digite o número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > maiorNumero)
        {
            maiorNumero = numero;
        }

        if (numero < menorNumero)
        {
            menorNumero = numero;
        }
        if (numero < 0)
        {
            quantidadeNumeroNegativos = quantidadeNumeroNegativos + 1;
        }
        if (numero > 0)
        {
            quantidadeNumeroPositivos = quantidadeNumeroPositivos + 1;
        }

        if (numero != 0)
        {
            if (numero % 2 == 0)
            {
                quantidadeNumerosPares = quantidadeNumerosPares + 1;
            }
            else
            {
                quantidadeNumerosImpares = quantidadeNumerosImpares + 1;
            }
        }

        if (numero < menorNumeroPar && numero % 2 == 0 && numero != 0)
        {
            menorNumeroPar = numero;
        }


        // Soma recebe ela mesma + o número digitado pelo usuário, ou seja, no final
        // teremos a soma de todos os números digitados
        soma = soma + numero;
    }

    double media = soma / (double)quantidadeDesejada;

    Console.WriteLine(
        "Soma: " + soma +
        "\nMédia: " + media +
        "\nMaior Número: " + maiorNumero +
        "\nMenor Número: " + menorNumero +
        "\nQuantidade Números negativos: " + quantidadeNumeroNegativos +
        "\nQuantidade Números positivos: " + quantidadeNumeroPositivos +
        "\nQuantidade Números pares: " + quantidadeNumerosPares +
        "\nQuantidade Números ímpares: " + quantidadeNumerosImpares +
        "\nMenor número par: " + menorNumeroPar
    );
}


// https://dontpad.com/franciscosensaulas/c#
static void ExemploFor05()
{
    /*
        Nome do aluno
        Nota Aluno 1
        Nota Aluno 2
        Nota Aluno 3
        Média do Aluno
     */
    for (int i = 0; i < 3; i = i + 1)
    {
        string nome = SolicitarNomeAluno();
        double nota1 = SolicitarNota("Nota 1");
        double nota2 = SolicitarNota("Nota 2");
        double nota3 = SolicitarNota("Nota 3");
        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("Aluno : " + nome + " recebeu a média: " + media);
    }
}

static string SolicitarNomeAluno()
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();
    while (nome.Length < 3 || nome.Length > 50)
    {
        Console.WriteLine("Nome deve conter no mínimo 3 caracteres e no máximo 50.");
        Console.Write("Nome: ");
        nome = Console.ReadLine().Trim();
    }
    return nome;
}

static double SolicitarNota(string notaTexto)
{
    double nota = 0;
    bool notaValida = false;
    while (notaValida == false)
    {
        try
        {
            Console.Write(notaTexto + ": ");
            nota = Convert.ToDouble(Console.ReadLine().Trim());
            if (nota >= 0 && nota <= 10)
            {
                notaValida = true;
            }
            else
            {
                Console.WriteLine(notaTexto + " deve ser maior/igual a 0 até 10");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(notaTexto + " deve conter um número real");
        }
    }
    return nota;
}

ExemploFor05();
