using System.Data.SqlClient;

namespace ExemploWindowsForms.BancoDados
{
    internal class Conexao
    {
        private readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Desktop\BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlConnection Conectar()
        {
            // Instanciando um objeto de conexão para podermos executar comandos SQL
            var conexao = new SqlConnection(ConnectionString);
            // Abrindo a conexão com o Banco de Dados
            conexao.Open();

            return conexao;
        }
    }
}
