using ExemploWindowsForms.BancoDados;
using System.Data;

namespace ExemploWindowsForms.Forms
{
    public partial class CategoriaForm : Form
    {
        private int idParaEditar = -1;

        public CategoriaForm()
        {
            InitializeComponent();
        }

        private void CategoriaForm_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            // Consultar os registros das categorias ordenadas por nome
            comando.CommandText = "SELECT id, nome FROM categorias ORDER BY nome";
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            comando.Connection.Close();

            // Limpar os registros do data grid view(tabela visual de categorias)
            dataGridViewCategorias.Rows.Clear();

            //for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            //{
            //    DataRow registro = tabelaEmMemoria.Rows[i];
            //}

            // Percorrer cada um dos registros que encontrou na consulta (select) que foi executada
            foreach (DataRow registro in tabelaEmMemoria.Rows)
            {
                dataGridViewCategorias.Rows.Add(new object[]{
                    registro["id"],
                    registro["nome"]
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

            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();
            string mensagemFeedback = "";
            if (idParaEditar == -1)
            {
                // Definir o comando de insert que será executado na tabela de categorias
                comando.CommandText = "INSERT INTO categorias VALUES (@NOME)";
                // Substituir o @NOME com o nome que o usuário digitou no campo
                comando.Parameters.AddWithValue("@NOME", nome);
                mensagemFeedback = "Categoria cadastrada com sucesso";
            }
            else
            {
                comando.CommandText = "UPDATE categorias SET nome = @NOME WHERE id = @ID";
                comando.Parameters.AddWithValue("@NOME", nome);
                comando.Parameters.AddWithValue("@ID", idParaEditar);
                mensagemFeedback = "Categoria alterada com sucesso";
                idParaEditar = -1;
            }
            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
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

            // Abrir conexão com o banco de dados
            var conexao = new Conexao().Conectar();
            // Criar comando que permite definirmos qual o sql será executado
            var comando = conexao.CreateCommand();
            // Definir o comando de delete que será executado na tabela de categorias
            comando.CommandText = "DELETE FROM categorias WHERE id = @ID";
            // Substituir o @NOME com o nome que o usuário selecionou
            comando.Parameters.AddWithValue("@ID", idParaApagar);
            // Executa o comando
            comando.ExecuteNonQuery();
            // Fechar a conexão com o banco de dados
            conexao.Close();
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

            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome FROM categorias WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", idParaEditar);
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            if (tabelaEmMemoria.Rows.Count < 0){
                MessageBox.Show("Categoria não existe");
                return;
            }

            var registro = tabelaEmMemoria.Rows[0];
            var nome = registro["nome"].ToString();
            textBoxNome.Text = nome;

            conexao.Close();
        }
    }
}
