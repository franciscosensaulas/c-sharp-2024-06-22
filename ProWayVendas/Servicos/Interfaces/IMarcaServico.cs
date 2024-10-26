using Servicos.Dtos.Cor;
using Servicos.Dtos.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Interfaces
{
    public interface IMarcaServico
    {
        int Cadastrar(MarcaCadastrarDto dto);
        void Editar(MarcaEditarDto dto);
        void Apagar(int id);
        IList<MarcaDto> ObterTodos(string? nome, string? cnpj);
        MarcaDto ObterPorId(int id);
    }
}
