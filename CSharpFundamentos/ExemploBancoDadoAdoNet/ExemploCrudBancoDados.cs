using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDadoAdoNet
{
    internal class ExemploCrudBancoDados
    {
        public void Adicionar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\francisco.sens\\Desktop\\c-sharp-2024-06-22\\c-sharp-2024-06-22\\CSharpFundamentos\\ExemploBancoDadoAdoNet\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = """
                INSERT INTO categorias (nome, descricao) VALUES 
                    ('Ação', 'Filme que contenha carros')
                """;
            comando.ExecuteNonQuery();

            conexao.Close();

            Console.WriteLine("Categoria cadastrada com sucesso");
        }
    }
}
