using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Helpers;
using ExemploWindowsForms.Repositorios;

namespace ExemploWindowsForms.Forms
{
    public partial class VendedoresForm : Form
    {
        private readonly VendedorRepositorio _vendedorRepositorio;
        public VendedoresForm()
        {
            _vendedorRepositorio = new VendedorRepositorio();

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VendedoresForm_Load(object sender, EventArgs e)
        {
            CarregarVendedores();
        }

        private void CarregarVendedores()
        {
            var vendedores = _vendedorRepositorio.ObterTodos();
            dataGridViewVendedores.Rows.Clear();

            foreach (var vendedor in vendedores)
            {
                dataGridViewVendedores.Rows.Add(
                    new object[]
                    {
                        vendedor.Id,
                        vendedor.Nome,
                        vendedor.Usuario,
                    });
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var usuario = textBoxUsuario.Text.Trim();
            var senha = textBoxSenha.Text.Trim().Criptografar();

            var vendedor = new Vendedor();
            vendedor.Nome = nome;
            vendedor.Usuario = usuario;
            vendedor.Senha = senha;

            _vendedorRepositorio.Adicionar(vendedor);
            CarregarVendedores();

            textBoxNome.Clear();
            textBoxUsuario.Clear();
            textBoxSenha.Clear();

            MessageBox.Show("Vendedor cadastrado com sucesso");
        }
    }
}
