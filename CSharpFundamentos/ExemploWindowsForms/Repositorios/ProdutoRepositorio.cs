using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWindowsForms.Repositorios
{
    internal class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly Conexao _conexao;

        public ProdutoRepositorio()
        {
            _conexao = new Conexao();
        }

        public List<Produto> ObterTodos(string pesquisa, int? categoriaId)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                SELECT
                    produtos.id AS 'id',
                    produtos.nome AS 'nome',
                    categorias.nome AS 'categoria',
                    categorias.id AS 'categoriaId',
                    produtos.preco_unitario,
                    produtos.quantidade_estoque,
                    produtos.habilitado_venda
                    FROM produtos
                    INNER JOIN categorias ON (produtos.categoria_id = categorias.id)
                    WHERE produtos.nome LIKE @NOME
                """;
            comando.Parameters.AddWithValue("@NOME", $"%{pesquisa}%");

            if (categoriaId is not null)
            {
                comando.CommandText += " AND produtos.categoria_id = @CATEGORIA_ID";
                comando.Parameters.AddWithValue("@CATEGORIA_ID", categoriaId);
            }

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            var produtos = new List<Produto>();
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.QuantidadeEstoque = Convert.ToInt16(registro["quantidade_estoque"]);
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
                produto.HabilitadoVenda = Convert.ToBoolean(registro["habilitado_venda"]);

                var categoria = new Categoria();
                categoria.Id = Convert.ToInt32(registro["categoriaId"]);
                categoria.Nome = registro["categoria"].ToString();
                produto.Categoria = categoria;

                produtos.Add(produto);
            }
            return produtos;
        }


        public void Apagar(int id)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Editar(Produto produto)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                UPDATE produtos SET 
                    nome = @NOME, 
                    categoria_id = @CATEGORIA_ID, 
                    preco_unitario = @PRECO_UNITARIO, 
                    habilitado_venda = @HABILITADO_VENDA, 
                    quantidade_estoque = @QUANTIDADE_ESTOQUE
                WHERE id = @ID
            """;

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA_ID", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@HABILITADO_VENDA", produto.HabilitadoVenda);
            comando.Parameters.AddWithValue("@QUANTIDADE_ESTOQUE", produto.QuantidadeEstoque);
            comando.Parameters.AddWithValue("@ID", produto.Id);
            // Executar o comando de insert e obter o id que foi gerado
            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }

        public bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public int Adicionar(Produto produto)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                INSERT INTO produtos (
                    nome, categoria_id, preco_unitario, habilitado_venda, quantidade_estoque
                ) VALUES (
                    @NOME, @CATEGORIA_ID, @PRECO_UNITARIO, @HABILITADO_VENDA, @QUANTIDADE_ESTOQUE
                ); SELECT SCOPE_IDENTITY();
                """;

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA_ID", produto.Categoria.Id);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@HABILITADO_VENDA", produto.HabilitadoVenda);
            comando.Parameters.AddWithValue("@QUANTIDADE_ESTOQUE", produto.QuantidadeEstoque);
            // Executar o comando de insert e obter o id que foi gerado
            var resultado = comando.ExecuteScalar();
            comando.Connection.Close();
            return Convert.ToInt32(resultado);
        }

        public Produto? ObterPorId(int id)
        {
            var comando = _conexao.Conectar().CreateCommand();
            comando.CommandText = """
                SELECT
                    produtos.id AS 'id',
                    produtos.nome AS 'nome',
                    categorias.nome AS 'categoria',
                    categorias.id AS 'categoriaId',
                    produtos.preco_unitario,
                    produtos.quantidade_estoque,
                    produtos.habilitado_venda
                    FROM produtos
                    INNER JOIN categorias ON (produtos.categoria_id = categorias.id)
                    WHERE produtos.id = @ID
                """;
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var produto = new Produto();
            produto.Id = Convert.ToInt32(registro["id"]);
            produto.Nome = registro["nome"].ToString();
            produto.QuantidadeEstoque = Convert.ToInt16(registro["quantidade_estoque"]);
            produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);
            produto.HabilitadoVenda = Convert.ToBoolean(registro["habilitado_venda"]);

            var categoria = new Categoria();
            categoria.Id = Convert.ToInt32(registro["categoriaId"]);
            categoria.Nome = registro["categoria"].ToString();
            produto.Categoria = categoria;

            return produto;
        }
    }
}
