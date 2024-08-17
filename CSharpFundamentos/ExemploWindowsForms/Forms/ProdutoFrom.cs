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
        public ProdutoFrom()
        {
            InitializeComponent();
        }

        private void buttonCadastrarCategoria_Click(object sender, EventArgs e)
        {
            var form = new CategoriaCadastroRapidoForm();
            form.ShowDialog();
        }
    }
}
