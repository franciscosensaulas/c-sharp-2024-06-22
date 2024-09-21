using ExemploWindowsForms.Helpers;
using ExemploWindowsForms.Repositorios;
using ExemploWindowsForms.Repositorios.Interfaces;

namespace ExemploWindowsForms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IVendedorRepositorio _vendedorRepositorio;

        public LoginForm()
        {
            _vendedorRepositorio = new VendedorRepositorio();
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            var usuario = textBoxUsuario.Text;
            var senha = textBoxSenha.Text.Criptografar();

            if (usuario == "admin" && senha == "C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC")
            {
                var principalForm = new PrincipalForm();
                // Oculta a tela atual para n fechar a aplicação
                Hide();
                // Abrir a tela como caixa de dialogo
                principalForm.ShowDialog();
                // Fechar a aplicação quando a tela do menu principal do sistema for fechado
                Dispose();
                return;
            }

            var vendedor = _vendedorRepositorio.Autenticar(usuario, senha);
            if (vendedor == null)
            {
                MessageBox.Show("Login/Senha inválidos");
                return;
            }
            // Definir o vendedor que existirá durante toda a aplicação
            VendaForm.Vendedor = vendedor;

            var vendaForm = new VendaForm();
            vendaForm.ShowDialog();
            Hide();
            Dispose();
        }


        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxSenha.Focus();
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonEntrar.PerformClick();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "marquinhos";
            textBoxSenha.Text = "admin";
        }
    }
}
