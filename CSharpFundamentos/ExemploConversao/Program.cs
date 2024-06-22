// Convertendo o texto "2" para o tipo int(inteiro)
int numero = Convert.ToInt32("2");

// Convertendo o texto "32.4" para o tipo double(real)
double valor = Convert.ToDouble("32,4");
// Converter o texto "false" para o tipo bool (boolean -> lógico)
bool vendido = Convert.ToBoolean("false");

Console.WriteLine("Número: " + numero);
Console.WriteLine("Valor: " + valor);
Console.WriteLine("Resultado: " + numero * valor);
Console.WriteLine("Vendido: " + vendido);

