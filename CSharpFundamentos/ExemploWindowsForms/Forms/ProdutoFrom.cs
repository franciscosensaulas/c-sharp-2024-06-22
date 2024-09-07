using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Repositorios;
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
    public partial class ProdutoFrom : Form
    {
        private readonly CategoriaRepositorio _categoriaRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        private int? IdParaEditar;

        public ProdutoFrom()
        {
            _categoriaRepositorio = new CategoriaRepositorio();
            _produtoRepositorio = new ProdutoRepositorio();
            InitializeComponent();
        }

        private void buttonCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var form = new CategoriaCadastroRapidoForm();
            var resultado = form.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                CarregarCategorias();

                foreach (Categoria categoriaItem in comboBoxCategoria.Items)
                {
                    if (categoriaItem.Nome == form.Nome)
                    {
                        comboBoxCategoria.SelectedItem = categoriaItem;
                        break;
                    }
                }
            }
        }

        private void ProdutoFrom_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            CarregarProdutos();
        }

        private void CarregarCategorias()
        {
            comboBoxCategoria.Items.Clear();
            comboBoxFiltroCategoria.Items.Clear();

            var categorias = _categoriaRepositorio.ObterTodos();
            foreach (var categoria in categorias)
            {
                comboBoxCategoria.Items.Add(categoria);
                comboBoxFiltroCategoria.Items.Add(categoria);
            }
        }

        private void CarregarProdutos()
        {
            var textoPesquisa = textBoxFiltroNome.Text;
            var categoriaSelecionada = (Categoria?)comboBoxFiltroCategoria.SelectedItem;
            int? categoriaId = null;
            if (categoriaSelecionada is not null)
                categoriaId = categoriaSelecionada.Id;

            var produtos = _produtoRepositorio.ObterTodos(textoPesquisa, categoriaId);

            dataGridViewProdutos.Rows.Clear();

            foreach (var produto in produtos)
            {
                dataGridViewProdutos.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Categoria.Nome,
                    produto.QuantidadeEstoque,
                    produto.PrecoUnitario
                });
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void textBoxFiltroNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CarregarProdutos();
        }

        private void comboBoxFiltroCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Nome = textBoxNome.Text;
            produto.QuantidadeEstoque = Convert.ToInt16(numericUpDownQuantidadeEstoque.Value);
            produto.PrecoUnitario = Convert.ToDecimal(maskedTextBoxPrecoUnitario.Text);
            if (radioButtonHabilitadoVendaSim.Checked == true)
                produto.HabilitadoVenda = true;

            var categoriaSelecionada = (Categoria?)comboBoxCategoria.SelectedItem;
            if (categoriaSelecionada is null)
            {
                MessageBox.Show("Selecione uma categoria");
                return;
            }

            produto.Categoria = categoriaSelecionada;

            if (IdParaEditar is null)
            {
                var id = _produtoRepositorio.Adicionar(produto);
                MessageBox.Show(id.ToString());
            }
            else
            {
                produto.Id = IdParaEditar.GetValueOrDefault();
                _produtoRepositorio.Editar(produto);
            }

            LimparCampos();
            CarregarProdutos();
        }

        private void LimparCampos()
        {
            IdParaEditar = null;
            textBoxNome.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            maskedTextBoxPrecoUnitario.Clear();
            numericUpDownQuantidadeEstoque.Value = 0;
            radioButtonHabilitadoVendaNao.Checked = false;
            radioButtonHabilitadoVendaSim.Checked = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridViewProdutos.SelectedRows[0];

            var produtoId = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var produto = _produtoRepositorio.ObterPorId(produtoId);

            textBoxNome.Text = produto.Nome;
            maskedTextBoxPrecoUnitario.Text = produto.PrecoUnitario.ToString();
            numericUpDownQuantidadeEstoque.Value = produto.QuantidadeEstoque;

            if (produto.HabilitadoVenda)
                radioButtonHabilitadoVendaSim.Checked = true;
            else
                radioButtonHabilitadoVendaNao.Checked = true;

            foreach (Categoria categoriaItem in comboBoxCategoria.Items)
            {
                if (categoriaItem.Id == produto.Categoria.Id)
                {
                    comboBoxCategoria.SelectedItem = categoriaItem;
                    break;
                }
            }

            IdParaEditar = produto.Id;

            textBoxNome.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = dataGridViewProdutos.SelectedRows[0];

            var produtoId = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _produtoRepositorio.Apagar(produtoId);

            CarregarProdutos();
        }
    }
}
