using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Enums;
using ExemploWindowsForms.Helpers;
using ExemploWindowsForms.Repositorios;
using ExemploWindowsForms.Repositorios.Interfaces;
using Microsoft.VisualBasic;

namespace ExemploWindowsForms.Forms
{
    public partial class VendaForm : Form
    {
        public static Vendedor Vendedor;
        private Venda? venda;
        private readonly ClienteRepositorio _clienteRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IVendaRepositorio _vendaRepositorio;
        private readonly IVendaProdutoRepositorio _vendaProdutoRepositorio;
        //private readonly IVendaRepositorio _vendaRepositorio;


        public VendaForm()
        {
            _clienteRepositorio = new ClienteRepositorio();
            _produtoRepositorio = new ProdutoRepositorio();
            _vendaRepositorio = new VendaRepositorio();
            _vendaProdutoRepositorio = new VendaProdutoRepositorio();
            InitializeComponent();
        }

        private void VendaForm_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            labelDataHoraAberturaTexto.Text = "";
            labelDataHoraFechamentoTexto.Text = "";
            labelStatusTexto.Text = "";
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
            var cliente = (Cliente?)comboBoxClientes.SelectedItem;

            if (cliente is null)
                return;

            venda = _vendaRepositorio.ObterAbertaPorIdCliente(cliente.Id);
            if (venda is null)
                CriarVenda(cliente);

            PreencherCamposComVendaExistente();

            CarregarProdutos();
            AlternarCampos();
        }

        private void CriarVenda(Cliente cliente)
        {
            venda = new Venda
            {
                Status = VendaStatus.Aberto,
                DataHoraAbertura = DateTime.Now,
                Vendedor = Vendedor,
                Cliente = cliente
            };
            var idVendaAberta = _vendaRepositorio.AbrirVenda(venda);
            venda.Id = idVendaAberta;
        }

        private void PreencherCamposComVendaExistente()
        {
            labelDataHoraAberturaTexto.Text = venda?.DataHoraAbertura.ToString();
            labelDataHoraFechamentoTexto.Text = string.Empty;
            labelStatusTexto.Text = Enum.GetName(typeof(VendaStatus), venda?.Status);

            PopularCarrinho();
            AtualizarTotalPedido();
        }

        private void AtualizarTotalPedido()
        {
            var total = _vendaRepositorio.ObterTotalVenda(venda.Id);
            labelTotalTexto.Text = total.GetValueOrDefault().FormatarMoeda();
        }

        private void AlternarCampos()
        {
            comboBoxClientes.Enabled = !comboBoxClientes.Enabled;
            comboBoxProdutos.Enabled = !comboBoxProdutos.Enabled;
            labelProduto.Enabled = !labelProduto.Enabled;
            labelPrecoUnitario.Enabled = !labelPrecoUnitario.Enabled;
            labelPrecoParcial.Enabled = !labelPrecoParcial.Enabled;
            labelQuantidade.Enabled = !labelQuantidade.Enabled;
            numericUpDownQuantidade.Enabled = !numericUpDownQuantidade.Enabled;
            labelPrecoUnitarioTexto.Enabled = !labelPrecoUnitarioTexto.Enabled;
            labelPrecoParcialTexto.Enabled = !labelPrecoParcialTexto.Enabled;
            buttonAdicionar.Enabled = !buttonAdicionar.Enabled;
            labelStatus.Enabled = !labelStatus.Enabled;
            labelStatusTexto.Enabled = !labelStatusTexto.Enabled;
            labelDataHoraAbertura.Enabled = !labelDataHoraAbertura.Enabled;
            labelDataHoraAberturaTexto.Enabled = !labelDataHoraAberturaTexto.Enabled;
            labelDataHoraFechamento.Enabled = !labelDataHoraFechamento.Enabled;
            labelDataHoraFechamentoTexto.Enabled = !labelDataHoraFechamentoTexto.Enabled;
            dataGridViewCarrinho.Enabled = !dataGridViewCarrinho.Enabled;
            labelTexto.Enabled = !labelTexto.Enabled;
            labelTotalTexto.Enabled = !labelTotalTexto.Enabled;
            buttonFecharPedido.Enabled = !buttonFecharPedido.Enabled;
            buttonCancelarPedido.Enabled = !buttonCancelarPedido.Enabled;
        }

        private void buttonCancelarPedido_Click(object sender, EventArgs e)
        {
            var motivo = Interaction.InputBox("Digite o motivo do cancelamento", "Cancelar venda");
            if (motivo == "")
                return;

            _vendaRepositorio.CancelarVenda(venda.Id, motivo);
        }

        private void comboBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotalParcialProduto();
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotalParcialProduto();
        }

        private void CalcularTotalParcialProduto()
        {
            var produtoSelecionado = (Produto?)comboBoxProdutos.SelectedItem;
            if (produtoSelecionado is null)
                return;

            var precoParcial = produtoSelecionado.PrecoUnitario * numericUpDownQuantidade.Value;

            labelPrecoUnitarioTexto.Text = produtoSelecionado.PrecoUnitario.FormatarMoeda();
            labelPrecoParcialTexto.Text = precoParcial.FormatarMoeda();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = (Produto?)comboBoxProdutos.SelectedItem;
            if (produtoSelecionado is null)
                return;

            var quantidade = Convert.ToInt32(numericUpDownQuantidade.Value);
            if (quantidade == 0)
                return;

            var produtoEstoque = _produtoRepositorio.ObterPorId(produtoSelecionado.Id);
            if (quantidade > produtoEstoque.QuantidadeEstoque)
            {
                MessageBox.Show(
                    $"Quantidade escolhida é maior do que a disponível {produtoEstoque.QuantidadeEstoque} no estoque");
                return;
            }

            var vendaProduto = new VendaProduto
            {
                Venda = venda,
                Produto = produtoSelecionado,
                Quantidade = quantidade,
            };
            _vendaProdutoRepositorio.AdicionarItem(vendaProduto);
            PopularCarrinho();
            AtualizarTotalPedido();
            MessageBox.Show("Item adicionado ao carrinho");

            comboBoxProdutos.SelectedIndex = -1;
            numericUpDownQuantidade.Value = 0;
            labelPrecoUnitarioTexto.Text = 0.0m.FormatarMoeda();
            labelPrecoParcialTexto.Text = 0.0m.FormatarMoeda();
        }

        private void PopularCarrinho()
        {
            var itensCarrinho = _vendaProdutoRepositorio.ObterTodosPorIdVenda(venda.Id);
            dataGridViewCarrinho.Rows.Clear();
            foreach (var item in itensCarrinho)
            {
                var totalProduto = item.Quantidade * item.Produto.PrecoUnitario;
                dataGridViewCarrinho.Rows.Add(new object[]
                {
                    item.Id,
                    item.Produto.Nome,
                    item.Quantidade,
                    item.Produto.PrecoUnitario.FormatarMoeda(),
                    totalProduto.FormatarMoeda()
                });
            }
        }

        private void buttonFecharPedido_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrinho.Rows.Count == 0)
            {
                MessageBox.Show("Adicione itens no carrinho.");
                return;
            }

            if (!ContemEstoqueSuficienteDosProdutos())
                return;

            _vendaRepositorio.FecharVenda(venda.Id);
            DebitarEstoqueDosProdutos();

            dataGridViewCarrinho.Rows.Clear();
            comboBoxClientes.SelectedIndex = -1;
            comboBoxProdutos.SelectedIndex = -1;
            numericUpDownQuantidade.Value = 0;
            labelDataHoraAberturaTexto.Text = "";
            labelDataHoraFechamentoTexto.Text = "";
            labelStatusTexto.Text = "";
            labelPrecoParcialTexto.Text = 0.0m.FormatarMoeda();
            labelPrecoUnitarioTexto.Text = 0.0m.FormatarMoeda();
            labelTotalTexto.Text = 0.0m.FormatarMoeda();

            venda = null;

            AlternarCampos();

            MessageBox.Show($"Pedido fechado com sucesso!");
        }

        private bool ContemEstoqueSuficienteDosProdutos()
        {
            var itensCarrinho = _vendaProdutoRepositorio.ObterTodosPorIdVenda(venda.Id);

            foreach (var itemCarrinho in itensCarrinho)
            {
                if (itemCarrinho.Quantidade > itemCarrinho.Produto.QuantidadeEstoque)
                {
                    MessageBox.Show(
                        $"Produto {itemCarrinho.Produto.Nome} contém quantidade {itemCarrinho.Quantidade} maior do que a disponível {itemCarrinho.Produto.QuantidadeEstoque} no estoque");
                    return false;
                }
            }
            return true;
        }

        private void DebitarEstoqueDosProdutos()
        {
            var itensCarrinho = _vendaProdutoRepositorio.ObterTodosPorIdVenda(venda.Id);

            foreach (var itemCarrinho in itensCarrinho)
            {
                var estoqueAtual = itemCarrinho.Produto.QuantidadeEstoque - itemCarrinho.Quantidade;
                _produtoRepositorio.AtualizarEstoque(itemCarrinho.Produto.Id, estoqueAtual);
            }
        }
    }
}
