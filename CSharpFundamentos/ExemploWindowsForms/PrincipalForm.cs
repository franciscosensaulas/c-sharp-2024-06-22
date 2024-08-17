using ExemploWindowsForms.Forms;

namespace ExemploWindowsForms
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculadoraForm form = new CalculadoraForm();
            form.ShowDialog();
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            var form = new CategoriaForm();
            form.ShowDialog();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            var form = new ProdutoFrom();
            form.ShowDialog();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            var form = new ClienteForm();
            form.ShowDialog();
        }
    }
}
