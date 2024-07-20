using ExemploPropriedades;

class Aluno
{
    public string Nome;
    public int? Idade; // Nullable
    public bool Aprovado;
    public Nullable<DateTime> DataMatricula;
}

public class Program
{
    static void Main(string[] args)
    {

        ExecutorCalculadora executor = new ExecutorCalculadora();
        executor.Executar();

    }

}