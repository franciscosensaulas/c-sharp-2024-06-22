using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using System.Data;

namespace ExemploWindowsForms.Repositorios
{
    internal class ClienteRepositorio
    {
        public void Adicionar(Cliente cliente)
        {
            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();

            // Definir o comando de insert que será executado na tabela de clientes
            comando.CommandText = """
                INSERT INTO clientes (nome, cpf, email, uf, cidade, logradouro, bairro, cep, numero, complemento, descricao) 
                VALUES (@NOME, @CPF, @EMAIL, @UF, @CIDADE, @LOGRADOURO, @BAIRRO, @CEP, @NUMERO, @COMPLEMENTO, @DESCRICAO)
                """;
            // Substituir o @NOME com o nome que o usuário digitou no campo
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@EMAIL", cliente.Email);
            comando.Parameters.AddWithValue("@UF", cliente.Uf);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
            comando.Parameters.AddWithValue("@DESCRICAO", cliente.Descricao);

            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public void Editar(Cliente cliente)
        {
            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();

            // Definir o comando de update que será executado na tabela de clientes
            comando.CommandText = """
                    UPDATE clientes SET 
                        nome = @NOME,
                        cpf = @CPF,
                        email = @EMAIL,
                        uf = @UF,
                        logradouro = @LOGRADOURO,
                        cidade = @CIDADE,
                        bairro = @BAIRRO,
                        cep = @CEP,
                        numero = @NUMERO,
                        complemento = @COMPLEMENTO,
                        descricao = @DESCRICAO
                    WHERE id = @ID
                    """;
            // Substituir o @NOME com o nome que o usuário digitou no campo
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@EMAIL", cliente.Email);
            comando.Parameters.AddWithValue("@UF", cliente.Uf);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
            comando.Parameters.AddWithValue("@DESCRICAO", cliente.Descricao);
            comando.Parameters.AddWithValue("@ID", cliente.Id);

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
            // Definir o comando de delete que será executado na tabela de clientes
            comando.CommandText = "DELETE FROM clientes WHERE id = @ID";
            // Substituir o @NOME com o nome que o usuário selecionou
            comando.Parameters.AddWithValue("@ID", id);
            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
        }

        public List<Cliente> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            // Consultar os registros das clientes ordenadas por nome
            comando.CommandText = """
                SELECT 
                id, nome, cpf, email, uf, cidade, bairro, logradouro, cep, numero, complemento, descricao 
                FROM clientes 
                ORDER BY nome
                """;
            // Cria uma tabela em memória (que armazenará os dados da consulta)
            var tabelaEmMemoria = new DataTable();
            // Executar a consulta (SELECT) armazenando estes registros na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());
            // Fechar a conexão com o banco de dados
            comando.Connection.Close();
            // Lista que armazenará todas as clientes do banco de dados
            var clientes = new List<Cliente>();
            // Percorrer cada um dos registros consultados da tabela de clientes,criando uma lista de objetos
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                // Instanciar um objeto de cliente
                var cliente = new Cliente();
                // Preencher as propriedades do objeto de cliente com os dados do registro (veio da consulta)
                cliente.Id = Convert.ToInt32(registro["id"]);
                cliente.Nome = registro["nome"].ToString();
                cliente.Cpf = registro["cpf"].ToString();
                cliente.Email = registro["email"].ToString();
                cliente.Uf = registro["uf"].ToString();
                cliente.Cidade = registro["cidade"].ToString();
                cliente.Bairro = registro["bairro"].ToString();
                cliente.Logradouro = registro["logradouro"].ToString();
                cliente.Cep = registro["cep"].ToString();
                cliente.Numero = registro["numero"].ToString();
                cliente.Complemento = registro["complemento"].ToString();
                cliente.Descricao = registro["descricao"].ToString();
                // Adicionar a cliente na lista de clientes
                clientes.Add(cliente);
            }
            // Retornar a lista de clientes
            return clientes;
        }

        public Cliente? ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = """
                SELECT 
                id, nome, cpf, email, uf, cidade, bairro, logradouro, cep, numero, complemento, descricao 
                FROM clientes 
                WHERE id = @ID
                """;
            comando.Parameters.AddWithValue("@ID", id);
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            conexao.Close();

            // Verificar se não encontrou registros
            if (tabelaEmMemoria.Rows.Count < 0)
                // Retorna null pois não encontrou registros
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = registro["nome"].ToString();
            cliente.Cpf = registro["cpf"].ToString();
            cliente.Email = registro["email"].ToString();
            cliente.Uf = registro["uf"].ToString();
            cliente.Cidade = registro["cidade"].ToString();
            cliente.Bairro = registro["bairro"].ToString();
            cliente.Logradouro = registro["logradouro"].ToString();
            cliente.Cep = registro["cep"].ToString();
            cliente.Numero = registro["numero"].ToString();
            cliente.Complemento = registro["complemento"].ToString();
            cliente.Descricao = registro["descricao"].ToString();
            return cliente;
        }
    }
}
