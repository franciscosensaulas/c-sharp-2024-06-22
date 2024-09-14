using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Repositorios;
using ExemploWindowsForms.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsForms.Forms
{
    public partial class VendaForm : Form
    {
        public static Vendedor Vendedor;
        private readonly ClienteRepositorio _clienteRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        //private readonly IVendaRepositorio _vendaRepositorio;


        public VendaForm()
        {
            _clienteRepositorio = new ClienteRepositorio();
            _produtoRepositorio = new ProdutoRepositorio();
            InitializeComponent();
        }

        private void VendaForm_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            var clientes = _clienteRepositorio.ObterTodos();
            foreach (var cliente in clientes)
                comboBoxClientes.Items.Add(cliente);
        }

        private void CarregarProdutos()
        {
            var produtos = _produtoRepositorio.ObterTodos(string.Empty);
            foreach (var produto in produtos)
                comboBoxProdutos.Items.Add(produto);
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cliente = (Cliente?) comboBoxClientes.SelectedItem;

            if (cliente is null)
                return;

            comboBoxClientes.Enabled = false;
            labelCliente.Enabled = false;
            CarregarProdutos();
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            comboBoxProdutos.Enabled = true;
            labelProduto.Enabled = true;
            labelPrecoUnitario.Enabled = true;
            labelPrecoParcial.Enabled = true;
            labelQuantidade.Enabled = true;
            numericUpDownQuantidade.Enabled = true;
            labelPrecoUnitarioTexto.Enabled = true;
            labelPrecoParcialTexto.Enabled = true;
            buttonAdicionar.Enabled = true;
            labelStatus.Enabled = true;
            labelStatusTexto.Enabled = true;
            labelDataHoraAbertura.Enabled = true;
            labelDataHoraAberturaTexto.Enabled = true;
            labelDataHoraFechamento.Enabled = true;
            labelDataHoraFechamentoTexto.Enabled = true;
            dataGridViewCarrinho.Enabled = true;
            labelTexto.Enabled = true;
            labelTotalTexto.Enabled = true;
            buttonFecharPedido.Enabled = true;
            buttonCancelarPedido.Enabled = true;
        }
    }
}
