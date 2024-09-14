using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWindowsForms.Repositorios
{
    internal class VendedorRepositorio : IVendedorRepositorio
    {
        private readonly Conexao _conexao;

        public VendedorRepositorio()
        {
            _conexao = new Conexao();
        }

        public int Adicionar(Vendedor vendedor)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                INSERT INTO vendedores (nome, usuario, senha) 
                VALUES (@NOME, @USUARIO, @SENHA); SELECT SCOPE_IDENTITY();
                """;
            comando.Parameters.AddWithValue("@NOME", vendedor.Nome);
            comando.Parameters.AddWithValue("@USUARIO", vendedor.Usuario);
            comando.Parameters.AddWithValue("@SENHA", vendedor.Senha);
            // Executar o comando de insert e obter o id que foi gerado
            var resultado = comando.ExecuteScalar();
            comando.Connection.Close();
            return Convert.ToInt32(resultado);
        }

        public List<Vendedor> ObterTodos()
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """SELECT id, nome, usuario FROM vendedores""";
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var vendeores = new List<Vendedor>();
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                var vendedor = new Vendedor();
                vendedor.Id = Convert.ToInt32(registro["id"]);
                vendedor.Nome = registro["nome"].ToString();
                vendedor.Usuario = registro["usuario"].ToString();

                vendeores.Add(vendedor);
            }
            return vendeores;
        }

        public Vendedor? Autenticar(string usuario, string senha)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                    SELECT id, nome, usuario 
                    FROM vendedores 
                    WHERE usuario = @USUARIO AND senha = @SENHA
                    """;
            comando.Parameters.AddWithValue("@USUARIO", usuario);
            comando.Parameters.AddWithValue("@SENHA", senha);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var vendedor = new Vendedor();
            vendedor.Id = Convert.ToInt32(registro["id"]);
            vendedor.Nome = registro["nome"].ToString();
            vendedor.Usuario = registro["usuario"].ToString();
            return vendedor;
        }
    }
}
