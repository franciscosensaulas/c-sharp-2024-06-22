using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using System.Data;

namespace ExemploWindowsForms.Repositorios
{
    internal class CategoriaRepositorio
    {
        public void Adicionar(Categoria categoria)
        {
            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();

            // Definir o comando de insert que será executado na tabela de categorias
            comando.CommandText = "INSERT INTO categorias (nome) VALUES (@NOME)";
            // Substituir o @NOME com o nome que o usuário digitou no campo
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);

            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public void Editar(Categoria categoria)
        {
            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();

            // Definir o comando de update que será executado na tabela de categorias
            comando.CommandText = "UPDATE categorias SET nome = @NOME WHERE id = @ID";
            // Substituir o @NOME com o nome que o usuário digitou no campo
            comando.Parameters.AddWithValue("@NOME", categoria.Nome);
            comando.Parameters.AddWithValue("@ID", categoria.Id);

            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public void Apagar(int id)
        {
            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();
            // Definir o comando de delete que será executado na tabela de categorias
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            // Substituir o @NOME com o nome que o usuário selecionou
            comando.Parameters.AddWithValue("@ID", id);
            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public List<Categoria> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            // Consultar os registros das categorias ordenadas por nome
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome";
            // Cria uma tabela em memória (que armazenará os dados da consulta)
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta (SELECT) armazenando estes registros na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
            // Lista que armazenará todas as categorias do banco de dados
            var categorias = new List<Categoria>();
            // Percorrer cada um dos registros consultados da tabela de categorias,criando uma lista de objetos
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                // Instanciar um objeto de categoria
                var categoria = new Categoria();
                // Preencher as propriedades do objeto de categoria com os dados do registro (veio da consulta)
                categoria.Id = Convert.ToInt32(registro["id"]);
                categoria.Nome = registro["nome"].ToString();
                // Adicionar a categoria na lista de categorias
                categorias.Add(categoria);
            }
            // Retornar a lista de categorias
            return categorias;
        }

        public Categoria? ObterPorId(int id) 
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome FROM categorias WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            conexao.Close();

            // Verificar se não encontrou registros
            if (tabelaEmMemoria.Rows.Count < 0)
                // Retorna null pois não encontrou registros
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var categoria = new Categoria();
            categoria.Id = id;
            categoria.Nome = registro["nome"].ToString();
            return categoria;
        }
    }
}
