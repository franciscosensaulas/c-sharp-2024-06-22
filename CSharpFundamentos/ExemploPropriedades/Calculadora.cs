namespace ExemploPropriedades
{
    internal class Calculadora
    {
        public int Numero1;
        public int Numero2;
        public int? Numero3;

        public int Soma()
        {
            int soma = Numero1 + Numero2;
            // Verificar se o número 3 está definido, ou seja, != null
            if (Numero3 is not null)
            {
                // Necessário utilizar o .Value para obter o que
                // está armazenado dentro de um nullable
                soma = soma + Numero3.Value;
            }
            return soma;
        }

    }
}
