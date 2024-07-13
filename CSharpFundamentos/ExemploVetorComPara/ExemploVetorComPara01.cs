using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComPara
{
    internal class ExemploVetorComPara01
    {
        public void Executar()
        {
            int[] numeros = new int[5];

            // For para percorrer cada uma das posições perguntando para o usuário
            for (int i = 0; i < numeros.Length; i = i + 1)
            {
                Console.Write($"Digite o número [{i + 1}/{numeros.Length}]: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Percorrer cada uma das posições somando os números
            int soma = 0;
            for(int i = 0; i < numeros.Length; i = i + 1)
            {
                // Obter o número em uma posição específica do vetor
                int numero = numeros[i];
                soma = soma + numero;
            }

            // Percorrer cada uma das posições descobrindo o menor valor
            int menorNumero = int.MaxValue;
            for(int i = 0; i < numeros.Length; i = i + 1)
            {
                int numero = numeros[i];
                if(numero < menorNumero)
                {
                    menorNumero = numero;
                }
            }

            Console.WriteLine($"""
                Soma: {soma}
                Menor número: {menorNumero}
                """);
        }
    }
}
