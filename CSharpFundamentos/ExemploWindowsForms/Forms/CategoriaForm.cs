using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Repositorios;
using System.Data;

namespace ExemploWindowsForms.Forms
{
    public partial class CategoriaForm : Form
    {
        private readonly CategoriaRepositorio _categoriaRepositorio;
        private int idParaEditar = -1;

        public CategoriaForm()
        {
            _categoriaRepositorio = new CategoriaRepositorio();

            InitializeComponent();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
        }

        private void CarregarCategorias()
        {
            // Limpar os registros do data grid view(tabela visual de categorias)
            dataGridViewCategorias.Rows.Clear();

            var categorias = _categoriaRepositorio.ObterTodos();
            //for (int i = 0; i < categorias.Count; i++)
            //{
            //    var categoria = categorias[i];
            //}

            // Percorrer cada um dos registros que encontrou na consulta (select) que foi executada
            foreach (var categoria in categorias)
            {
                dataGridViewCategorias.Rows.Add(new object[]{
                    categoria.Id,
                    categoria.Nome
                });
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter o nome que o usuário digitou
            var nome = textBoxNome.Text.Trim();

            if (nome.Length < 3)
            {
                MessageBox.Show(
                    "Nome deve conter no mínimo 3 caracteres",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }
            if (nome.Length > 100)
            {
                MessageBox.Show(
                    "Nome deve conter no máximo 100 caracteres",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxNome.Focus();
                return;
            }

            var categoria = new Categoria();
            categoria.Nome = nome;

            string mensagemFeedback = "";
            if (idParaEditar == -1)
            {
                _categoriaRepositorio.Adicionar(categoria);
                mensagemFeedback = "Categoria cadastrada com sucesso";
            }
            else
            {
                categoria.Id = idParaEditar;
                _categoriaRepositorio.Editar(categoria);
                mensagemFeedback = "Categoria alterada com sucesso";
                idParaEditar = -1;
            }

            textBoxNome.Clear();

            // Realizar a consulta na tabela de categorias atualizando o
            // datagridview com o novo registro
            CarregarCategorias();
            // Apresentar feedback de que a categoria foi salva
            MessageBox.Show(mensagemFeedback);
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridViewCategorias.SelectedRows[0].Index;
            if (indiceLinhaSelecionada == -1)
                return;

            var linhaSelecionada = dataGridViewCategorias.Rows[indiceLinhaSelecionada];
            var idParaApagar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value;

            var desejaRealmenteApagar = MessageBox.Show(
                $"Deseja realmente apagar '{nome}?'",
                "AVISO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (desejaRealmenteApagar == DialogResult.No)
                return;

            _categoriaRepositorio.Apagar(idParaApagar);

            // Realizar a consulta na tabela de categorias atualziando o
            // datagridview sem o registro apagado
            CarregarCategorias();
            // Apresentar feedback de que a categoria foi apagada
            MessageBox.Show("Categoria apagada com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridViewCategorias.SelectedRows[0].Index;
            if (indiceLinhaSelecionada == -1)
                return;

            var linhaSelecionada = dataGridViewCategorias.Rows[indiceLinhaSelecionada];
            idParaEditar = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var categoria = _categoriaRepositorio.ObterPorId(idParaEditar);

            if (categoria is null)
            {
                MessageBox.Show("Categoria não existe");
                return;
            }

            textBoxNome.Text = categoria.Nome;
        }

        private void CategoriaForm_Activated(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void dataGridViewCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
