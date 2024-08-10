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
    }
}
