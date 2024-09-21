using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploWindowsForms.BancoDados;
using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Enums;
using ExemploWindowsForms.Repositorios.Interfaces;

namespace ExemploWindowsForms.Repositorios
{
    internal class VendaRepositorio : IVendaRepositorio
    {
        private readonly Conexao _conexao;

        public VendaRepositorio()
        {
            _conexao = new Conexao();
        }

        public int AbrirVenda(Venda venda)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    INSERT INTO vendas (id_cliente, id_vendedor, data_hora_abertura, status)
                    VALUES (@ID_CLIENTE, @ID_VENDEDOR, @DATA_HORA_ABERTURA, @STATUS); SELECT SCOPE_IDENTITY();
                    """;
                comando.Parameters.AddWithValue("@ID_CLIENTE", venda.Cliente.Id);
                comando.Parameters.AddWithValue("@ID_VENDEDOR", venda.Vendedor.Id);
                comando.Parameters.AddWithValue("@DATA_HORA_ABERTURA", venda.DataHoraAbertura);
                comando.Parameters.AddWithValue("@STATUS", venda.Status);
                return Convert.ToInt32(comando.ExecuteScalar());
            }
            finally
            {
                if (comando is not null)
                    comando.Connection.Close();
            }
        }

        public void CancelarVenda(int id, string motivo)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    UPDATE vendas 
                    SET status = @STATUS, motivo_cancelamento = @MOTIVO
                    WHERE id = @ID;
                    """;
                comando.Parameters.AddWithValue("@STATUS", VendaStatus.Cancelado);
                comando.Parameters.AddWithValue("@MOTIVO", motivo);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
            }
            finally
            {
                comando?.Connection.Close();
            }
        }

        public void FecharVenda(int id)
        {
            var valor = ObterTotalVenda(id);

            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    UPDATE vendas 
                    SET status = @STATUS, data_hora_fechamento = @DATA_HORA_FECHAMENTO, valor = @VALOR
                    WHERE id = @ID;
                    """;
                comando.Parameters.AddWithValue("@STATUS", VendaStatus.Fechado);
                comando.Parameters.AddWithValue("@DATA_HORA_FECHAMENTO", DateTime.Now);
                comando.Parameters.AddWithValue("@VALOR", valor);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
            }
            finally
            {
                comando?.Connection.Close();
            }
        }

        public Venda? ObterAbertaPorIdCliente(int idCliente)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    SELECT 
                    v.id,
                    v.status,
                    v.data_hora_abertura
                    FROM vendas AS v
                    WHERE v.id_cliente = @ID_CLIENTE AND v.status = @STATUS;
                    """;
                comando.Parameters.AddWithValue("@ID_CLIENTE", idCliente);
                comando.Parameters.AddWithValue("@STATUS", VendaStatus.Aberto);
                var tabela = new DataTable();
                tabela.Load(comando.ExecuteReader());
                if (tabela.Rows.Count == 0)
                    return null;

                var registro = tabela.Rows[0];
                return new Venda
                {
                    Id = Convert.ToInt32(registro["id"]),
                    Status = (VendaStatus) registro["status"],
                    DataHoraAbertura = Convert.ToDateTime(registro["data_hora_abertura"]),
                };
            }
            finally
            {
                comando?.Connection.Close();
            }
        }

        public decimal? ObterTotalVenda(int id)
        {
            SqlCommand? comando = null;
            try
            {
                comando = _conexao.Conectar().CreateCommand();
                comando.CommandText = """
                    SELECT 
                    SUM(vp.quantidade * p.preco_unitario)
                    FROM vendas_produtos AS vp
                    INNER JOIN produtos AS p ON (vp.id_produto = p.id)
                    WHERE vp.id_venda = @ID_VENDA;
                    """;
                comando.Parameters.AddWithValue("@ID_VENDA", id);
                var deuCerto = decimal.TryParse(comando.ExecuteScalar()?.ToString(), out decimal total);
                return total;
            }
            finally
            {
                comando?.Connection.Close();
            }
        }
    }
}
