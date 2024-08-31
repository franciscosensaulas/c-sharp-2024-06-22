using ExemploConstrutores;

var jao = new Funcionario("Jão da Silva");

Console.WriteLine(jao.Nome);
Console.WriteLine(jao.Cpf);
Console.WriteLine(jao.DataNascimento);

var maria = new Funcionario("Maria", "123.450.391-20");

Console.WriteLine(maria.Nome);
Console.WriteLine(maria.Cpf);
Console.WriteLine(maria.DataNascimento);

var jose = new Funcionario("José", "999.450.391-20", new DateTime(1990, 2, 4));

Console.WriteLine(jose.Nome);
Console.WriteLine(jose.Cpf);
Console.WriteLine(jose.DataNascimento);