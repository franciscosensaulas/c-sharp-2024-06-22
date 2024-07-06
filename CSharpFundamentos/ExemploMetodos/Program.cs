// Método que contém void, é um método sem retorno, ou seja, que executará uma ação 
static void Exemplo01()
{
    // Criando uma variável chamada nome armazendo o retorno do método SolicitarNome
    string nome = SolicitarNome();
    string sobrenome = SolicitarSobrenome();
    // Criando uma variável chamada nomeCompleto, armazenando o retorno do método ConcatearNomeCompleto,
    // que foi passado o parâmetro nome e o parâmetro sobrenome.
    string nomeCompleto = ConcantenarNomeCompleto(nome, sobrenome);
    Console.WriteLine("Nome completo: " + nomeCompleto);
}

/*
    Método que retorne uma string ou qualquer outra coisa, é um método com retorno, ou seja, 
    que executará uma ação e retornará algo daquele tipo específicado
 */
static string SolicitarNome()
{
    Console.Write("Solicitar nome: ");
    string nomeUsuario = Console.ReadLine();
    return nomeUsuario;
}

static string SolicitarSobrenome()
{
    Console.Write("Solicitar sobrenome: ");
    string sobrenomeUsuario = Console.ReadLine();
    return sobrenomeUsuario;
}

// Esse método recebe dois parâmetros: nomeAluno  sobrenomeAluno
// É um método que retorna uma string que recebe dois parâmetros, sendo o primeiro uma string
// e o segundo outra string
static string ConcantenarNomeCompleto(string nomeAluno, string sobrenomeAluno)
{
    string nomeCompleto = nomeAluno + " " + sobrenomeAluno;
    return nomeCompleto;
}


static void Exemplo02()
{
    double soma = Somar(9, 8.5);
    Console.WriteLine("Soma: " + soma);
}

static double Somar(double numero1, double numero2)
{
    return numero1 + numero2;
}

Exemplo02();