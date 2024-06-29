static void RemoverEspacosComeco()
{
    string texto = "    Abacate é verde    ";
    string textoFinal = texto.TrimStart(); // Remover os espaços do começo da string
    Console.WriteLine("Texto original: '" + texto + "'");
    Console.WriteLine("Texto final:    '" + textoFinal + "'");
}
static void RemoverEspacosFim()
{
    string texto = "    Abacate é verde    ";
    string textoFinal = texto.TrimEnd(); // Remover os espaços do começo da string
    Console.WriteLine("Texto original: '" + texto + "'");
    Console.WriteLine("Texto final:    '" + textoFinal + "'");
}
static void RemoverEspacos()
{
    string texto = "    Abacate é verde    ";
    string textoFinal = texto.Trim(); // Remover os espaços do começo da string
    Console.WriteLine("Texto original: '" + texto + "'");
    Console.WriteLine("Texto final:    '" + textoFinal + "'");
}
static void ObterTamanhoString() {
    string texto = "Meu texto  ";
    int tamanho = texto.Length;
    Console.WriteLine(
        "Texto: " + texto + 
        "\nTamanho: " + tamanho);
}
static void SubstituirTexto() {
    string texto = "Abaate é verrde";
    Console.WriteLine("Texto antes da correção: " + texto);
    texto = texto.Replace("Abaate", "Abacate");
    texto = texto.Replace("verrde", "verde");
    Console.WriteLine("Texto após a correção: " + texto);
}

SubstituirTexto();