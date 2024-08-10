using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDadoAdoNet
{
    internal class CategoriaRepositorio
    {
        public string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\francisco.sens\\source\\repos\\c-sharp-2024-06-22\\CSharpFundamentos\\ExemploBancoDadoAdoNet\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

        // CRUD
        //    Ação     COMANDO SQL
        // ✔ Create   INSERT (cria um registro em uma tabela)
        // ✔ Read     SELECT (consulta registro(s) em uma tabela)
        // ✔ Update   UPDATE (alterar registro(s) em uma tabela)
        // ✔ Delete   DELETE (apagar registro(s) em uma tabela)

        // Método sem retorno com dois parâmetros (nome do tipo string e descrição do tipo string)
        public void Adicionar(string nome, string descricao)
        {
            // Instanciando um objeto de conexão para podermos executar comandos SQL
            SqlConnection conexao = new SqlConnection();
            // Definindo o caminho do nosso banco de dados
            conexao.ConnectionString = ConnectionString;
            // Abrindo a conexão com o Banco de Dados
            conexao.Open();

            // Criando um comando para podermos definir qual o comando de SQL que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado (neste caso será um insert (criar um registro na tabela de categorias))
            comando.CommandText = $"""
                INSERT INTO categorias (nome, descricao) VALUES 
                    (@NOME, @DESCRICAO)
                """;
            // Substituir o @NOME do comando por nome
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@DESCRICAO", descricao);

            // Executar o comando definido
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();

            Console.WriteLine("Categoria cadastrada com sucesso");
        }

        // Método ObterTodos sem retorno e sem parâmetros
        public void ObterTodos()
        {
            // Instanciando um objeto de conexão para podermos executar comandos SQL
            SqlConnection conexao = new SqlConnection();
            // Definindo o caminho do nosso banco de dados
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\francisco.sens\\source\\repos\\c-sharp-2024-06-22\\CSharpFundamentos\\ExemploBancoDadoAdoNet\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrindo a conexão com o Banco de Dados
            conexao.Open();

            // Criando um comando para podermos definir qual o comando de SQL que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado (
            // neste caso será um select(que consultará todos os registros da tabela de categorias))
            comando.CommandText = "SELECT id, nome, descricao FROM categorias";
            // Criando uma tabela em memória
            DataTable tabelaEmMemoria = new DataTable();
            // Executando a consulta na tabela de categorias, carregando os registros na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Percorrer todos os registros da tabela de categorias
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obter da tabela em memória o registro percorrido
                DataRow registro = tabelaEmMemoria.Rows[i];
                // Obter a coluna do id do registro percorrido
                int id = Convert.ToInt32(registro["id"]);
                // Obter a coluna da string do registro percorrido
                string nome = registro["nome"].ToString();
                // Obter a coluna da descrição do registro percorrido
                string descricao = registro["descricao"].ToString();
                Console.WriteLine($"""
                    Id: {id}
                    Nome: {nome}
                    Descrição: {descricao}

                    """);
            }
        }

        public void Apagar(int id)
        {
            // Instanciando um objeto de conexão para podermos executar comandos SQL
            SqlConnection conexao = new SqlConnection();
            // Definindo o caminho do nosso banco de dados
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\francisco.sens\\source\\repos\\c-sharp-2024-06-22\\CSharpFundamentos\\ExemploBancoDadoAdoNet\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrindo a conexão com o Banco de Dados
            conexao.Open();

            // Criando um comando para podermos definir qual o comando de SQL que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado (
            // neste caso será um delete(que apagará a categoria desejada))
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            // Substituir o @ID por o real valor do id, prevenindo SQL Injection
            comando.Parameters.AddWithValue("@ID", id);
            // Executar o comando de delete
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public void Alterar(int id, string nome, string descricao)
        {
            // Instanciando um objeto de conexão para podermos executar comandos SQL
            SqlConnection conexao = new SqlConnection();
            // Definindo o caminho do nosso banco de dados
            conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\francisco.sens\\source\\repos\\c-sharp-2024-06-22\\CSharpFundamentos\\ExemploBancoDadoAdoNet\\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            // Abrindo a conexão com o Banco de Dados
            conexao.Open();

            // Criando um comando para podermos definir qual o comando de SQL que será executado
            SqlCommand comando = conexao.CreateCommand();
            // Definir o comando que será executado (
            // neste caso será um update(que alterará categoria desejada))
            comando.CommandText = $"""
                UPDATE categorias SET 
                    nome = @NOME,
                    descricao = @DESCRICAO
                WHERE id = @ID
                """;
            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@DESCRICAO", descricao);
            comando.Parameters.AddWithValue("@ID", id);

            // Executar o comando de update
            comando.ExecuteNonQuery();
            // Fechar a conexão
            conexao.Close();
        }
    }
}
