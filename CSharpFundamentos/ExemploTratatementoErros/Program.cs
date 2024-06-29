static void TratamentoErroConversao()
{
    try
    {
        Console.Write("Número 1: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Número 1 escolhido: " + numero1);
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERRO: Não foi possível converter o número 1");
        Console.ResetColor();
    }
    Console.WriteLine("Obrigado por utilizar nosso software");
}

static void TratamentoErroDivisao()
{
    // Tentar executar o código que está dentro das chaves, caso ocorrer
    // erros vai para o devido catch
    try
    {
        Console.Write("Digite o número 1: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int resultado = numero1 / numero2;
        Console.WriteLine("Resultado: " + resultado);
    }
    // Capturar o erro de divisão por 0
    catch (DivideByZeroException e)
    {
        Console.WriteLine("Não foi possível realizar a divisão, pois o número 2 é 0");
    }
    // Capturar o erro de valor convertido não de acordo com o devido tipo
    catch (FormatException e)
    {
        Console.WriteLine("Não foi possível realizar a conversão do número informado");
    }
    catch (Exception e)
    {
        Console.WriteLine("Ocorreu um erro inesperado");
    }
    // Finally será executado independentemente se deu erro ou não
    finally
    {
        Console.WriteLine("Obrigado por utilizar");
    }
}
TratamentoErroDivisao();