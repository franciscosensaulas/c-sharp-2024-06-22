using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Dtos.Marca
{
    public class MarcaCadastrarDto
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string? Descricao { get; set; }
    }
}
