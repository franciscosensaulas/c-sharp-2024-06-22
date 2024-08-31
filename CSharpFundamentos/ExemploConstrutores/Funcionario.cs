using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        // Construtor é um código que é exeuctado quando é
        // utilizado 'new NomeClasse', tem como objetivo garantir o funcionamento
        // correto da classe com os dados mínimos necessários
        public Funcionario(string nome)
        {
            Nome = nome;
        }

        // Construtor é um método que é executado no new
        // Overload: Ter a capacidade de ter dois métodos o mesmo nome, porém com
        // parâmetros diferentes
        public Funcionario(string nome, string cpf) : this(nome)
        {
            Cpf = cpf;
        }


        public Funcionario(string nome, string cpf, DateTime dataNascimento) : this(nome, cpf)
        {
            DataNascimento = dataNascimento;
        }
    }
}
