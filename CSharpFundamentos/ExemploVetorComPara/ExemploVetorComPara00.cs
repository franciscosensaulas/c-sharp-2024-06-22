using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetorComPara
{
    internal class ExemploVetorComPara00
    {
        public void Executar()
        {
            string[] frutas = new string[3];

            // For utilizado para percorrer cada uma das posições do vetor
            for (int i = 0; i < frutas.Length; i = i + 1)
            {
                Console.Write("Fruta: ");
                frutas[i] = Console.ReadLine();
            }

            for (int i = 0; i < frutas.Length; i = i + 1)
            {
                Console.WriteLine("Fruta: " + frutas[i]);
            }
        }
    }
}
// https://dontpad.com/franciscosensaulas/c#
// Ex. 1: Solicitar o nome do remédio e seu preço, armazenando em dois vetores

// Ex. 2: Solicitar 20 números, apresentando:
// Quantidade de pares
// Quantidade de ímpares
// Quantidade de negativos
// Soma dos números
