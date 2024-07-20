using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPropriedades
{
    internal class ExecutorAluno
    {
        public void Executar()
        {
            // Instanciando objeto pedrino da classe Aluno
            Aluno pedrinho = new Aluno();
            // Atribuindo valora para as propriedades
            pedrinho.Nome = "Pedrinho";
            pedrinho.Aprovado = true;
            // Isso não é neccessário pois a idade é nullable, ou seja, começará com null 
            //pedrinho.Idade = null;

            Aluno ana = new Aluno();
            ana.Nome = "Ana";
            ana.Aprovado = true;
            ana.DataMatricula = new DateTime(2024, 01, 29);
            ana.Idade = 28;

            Console.WriteLine("Nome: " + pedrinho.Nome);
            if (pedrinho.Idade != null) 
                Console.WriteLine("Idade: " + pedrinho.Idade);

            // Verificando se o pedrinho está matriculado
            if (pedrinho.DataMatricula is not null)
            {
                // Apresentar a data da matricula e se está aprovado
                Console.WriteLine("Data de Matrícula " + pedrinho.DataMatricula);
                Console.WriteLine("Aprovado: " + pedrinho.Aprovado);
            }
            else
                Console.WriteLine("Aluno(a) não matriculado");


            Console.WriteLine("Nome: " + ana.Nome);
            if (ana.Idade != null)
                Console.WriteLine("Idade: " + ana.Idade);

            // Verificando se o ana está matriculado
            if (ana.DataMatricula is not null)
            {
                // Apresentar a data da matricula e se está aprovado
                Console.WriteLine("Data de Matrícula " + ana.DataMatricula);
                Console.WriteLine("Aprovado: " + ana.Aprovado);
            }
            else
                Console.WriteLine("Aluno(a) não matriculado");


        }
    }
}
