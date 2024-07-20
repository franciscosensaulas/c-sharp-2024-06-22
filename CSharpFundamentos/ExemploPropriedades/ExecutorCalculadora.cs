using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPropriedades
{
    internal class ExecutorCalculadora
    {
        public void Executar()
        {
            Calculadora hp = new Calculadora();
            Console.Write("Número 1:");
            hp.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 2:");
            hp.Numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = hp.Soma();
            Console.WriteLine("Soma: " + soma);

            Calculadora epson = new Calculadora();
            Console.Write("Número 1:");
            epson.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 2:");
            epson.Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 3:");
            epson.Numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Soma: " + epson.Soma());


            Calculadora multilaser = new Calculadora();
            Console.Write("Número 1:");
            multilaser.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 2:");
            multilaser.Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Soma: {multilaser.Soma()}");
        }
    }
}
