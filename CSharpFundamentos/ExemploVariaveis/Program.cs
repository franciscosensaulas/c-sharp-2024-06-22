string carro = "Celta"; // string é utilizado para armazenar texto
int km = 170654; // int é utilizado para armazenar inteiros
double preco = 15.00; // double é utilizado para armazenar números reais
bool batido = true; // bool é o mesmo que boolean, ou seja, um tipo lógico. Armazena true ou false

Console.WriteLine("Carro: " + carro);
Console.Write("Km: " + km);
Console.WriteLine("\nPreço: " + preco);
Console.WriteLine("Batido: " + batido);

// Entradas
string nome = "Adroaldo";
int idade = 30;
int horasTrabalhadas = 100;
double valorHora = 15.71;
// Alterando o valor hora pois o Adroaldo recebeu um aumento de 1 centavo
valorHora = 15.72;
// Processamento
double salarioBruto = horasTrabalhadas * valorHora;
// Saídas
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Salário bruto: " + salarioBruto);


// Exercício com os seguintes dados:
// Nome do aluno 1
// Nota Trigonometria do aluno 1
// Nota Equacoes do aluno 1
// Nota Inequacoes do aluno 1
// Calcular a média de matemática do aluno 1

// Nome do aluno 2
// Nota Trigonometria do aluno 2
// Nota Equacoes do aluno 2
// Nota Inequacoes do aluno 2
// Calcular a média de matemática do aluno 2

// Apresentar os nomes dos alunos e suas médias
int notaTrigonometria = 9;
int notaEquacoes = 4;
int soma = (notaTrigonometria + notaEquacoes);
double media = soma / 2.0;
Console.WriteLine(soma);
Console.WriteLine(media);

/*
 * 
 * int + int => int
int - int => int
int * int => int
int / int => int 6 / 2 => 3 7 / 2 => 3

double + double => double
double - double => double
double * double => double 
double / double => double

double + int => double
double - int => double
double * int => double
double / int => double

int + double => double
int - double => double
int * double => double
int / double => double
 */ 