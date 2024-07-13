using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetor
{
    internal class ExemploVetor01
    {
        public void Executar()
        {
            int[] numeros = new int[4];
            Console.Write("Digite o número [1/4]: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número [2/4]: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número [3/4]: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número [4/4]: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());

            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            Console.WriteLine("Soma: " + soma);
        }
    }
}
/*
    Exercício 01: Solicitar o nome e sobrenome do 
        usuário armazenando em dois vetores de 4 posições cada
    Exercício 02: Solicitar o nome, categoria, preço e 
        quantidade de 3 produtos armazenando nos vetores
 */