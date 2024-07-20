using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPropriedades
{
    internal class Aluno
    {
        public string Nome;
        public int? Idade;
        public bool Aprovado;
        public Nullable<DateTime> DataMatricula;

        // Nullable quer dizer que esse não existe durante o momento de criação do objeto, ou seja, 
        // começará com null, no caso da idade por padrão começaria com 0, porém como está nullable
        // começará com null.
    }
}
