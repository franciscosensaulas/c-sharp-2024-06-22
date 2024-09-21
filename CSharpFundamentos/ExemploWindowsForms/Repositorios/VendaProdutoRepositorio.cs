using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Repositorios.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace ExemploWindowsForms.Repositorios
{
    internal class VendaProdutoRepositorio : IVendaProdutoRepositorio
    {
        private readonly Conexao _conexao;

        public VendaProdutoRepositorio()
        {
            _conexao = new Conexao();
        }
        public void AdicionarItem(VendaProduto vendaProduto)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    INSERT INTO vendas_produtos (id_produto, id_venda, quantidade)
                    VALUES (@ID_PRODUTO, @ID_VENDA, @QUANTIDADE);
                    """;
                comando.Parameters.AddWithValue("@ID_PRODUTO", vendaProduto.Produto.Id);
                comando.Parameters.AddWithValue("@ID_VENDA", vendaProduto.Venda.Id);
                comando.Parameters.AddWithValue("@QUANTIDADE", vendaProduto.Quantidade);
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (comando is not null)
                    comando.Connection.Close();
            }
        }

        public void AtualizarItem(VendaProduto vendaProduto)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    UPDATE vendas_produtos 
                    SET quantidade = @QUANTIDADE
                    WHERE id = @ID_VENDA_PRODUTO;
                    """;
                comando.Parameters.AddWithValue("@ID_VENDA_PRODUTO", vendaProduto.Id);
                comando.Parameters.AddWithValue("@QUANTIDADE", vendaProduto.Quantidade);
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (comando is not null)
                    comando.Connection.Close();
            }
        }

        public IList<VendaProduto> ObterTodosPorIdVenda(int idVenda)
        {
            var carrinho = new List<VendaProduto>();
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    SELECT 
                    vp.id,
                    vp.quantidade,
                    vp.id_produto,
                    p.nome,
                    p.preco_unitario,
                    p.quantidade_estoque
                    FROM vendas_produtos AS vp
                    INNER JOIN produtos AS p ON (vp.id_produto = p.id)
                    WHERE vp.id_venda = @ID_VENDA
                    """;
                comando.Parameters.AddWithValue("@ID_VENDA", idVenda);
                var tabela = new DataTable();
                tabela.Load(comando.ExecuteReader());

                foreach (DataRow registro in tabela.Rows)
                {
                    var item = new VendaProduto
                    {
                        Id = Convert.ToInt32(registro["id"]),
                        Quantidade = Convert.ToInt32(registro["quantidade"]),
                        Produto = new Produto
                        {
                            Id = Convert.ToInt32(registro["id_produto"]),
                            Nome = registro["nome"].ToString(),
                            PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]),
                            QuantidadeEstoque = Convert.ToInt16(registro["quantidade_estoque"]),
                        }
                    };
                    carrinho.Add(item);
                }


                comando.ExecuteNonQuery();
            }
            finally
            {
                if (comando is not null)
                    comando.Connection.Close();
            }

            return carrinho;
        }

        public void RemoverItem(int vendaProdutoId)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    DELETE FROM vendas_produtos 
                    WHERE id = @ID_VENDA_PRODUTO;
                    """;
                comando.Parameters.AddWithValue("@ID_VENDA_PRODUTO", vendaProdutoId);
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (comando is not null)
                    comando.Connection.Close();
            }
        }
    }
}
