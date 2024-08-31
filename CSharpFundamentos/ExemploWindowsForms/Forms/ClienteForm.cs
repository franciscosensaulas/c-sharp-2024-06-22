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
    public partial class ClienteForm : Form
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClienteForm()
        {
            InitializeComponent();
            _clienteRepositorio = new ClienteRepositorio();
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var form = new ClienteCadastroForm();
            form.ShowDialog();
        }

        private void CarregarClientes()
        {
            var clientes = _clienteRepositorio.ObterTodos();
            dataGridViewClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dataGridViewClientes.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    $"{cliente.Uf} {cliente.Cidade} {cliente.Bairro} {cliente.Logradouro}",
                });
            }
        }

        private void ClienteForm_Activated(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count < 0)
            {
                MessageBox.Show("Selecione um registro de cliente");
                return;
            }

            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var form = new ClienteCadastroForm(id);
            form.ShowDialog();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count < 0)
            {
                MessageBox.Show("Selecione um registro de cliente");
                return;
            }
            var resultado = MessageBox.Show(
                "Deseja realmente apagar o cliente?", "CUIDADO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
                return;

            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            _clienteRepositorio.Apagar(id);
            MessageBox.Show("Cliente apagado com sucesso");
            CarregarClientes();
        }
        /* Colaborador:
            id
            nome
            cpf
            valor hora
            quantidade horas
         */
    }
}
