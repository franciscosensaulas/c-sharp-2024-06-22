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
    public partial class CategoriaCadastroRapidoForm : Form
    {
        private readonly CategoriaRepositorio _categoriaRepositorio;
        public string Nome { get; set; }

        public CategoriaCadastroRapidoForm()
        {
            InitializeComponent();

            _categoriaRepositorio = new CategoriaRepositorio();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Nome = textBoxNome.Text;
            var categoria = new Categoria
            {
                Nome = Nome
            };

            _categoriaRepositorio.Adicionar(categoria);
            // Definindo que a ação que seria executada na tela deu certo
            DialogResult = DialogResult.OK;

            Dispose();
        }
    }
}
