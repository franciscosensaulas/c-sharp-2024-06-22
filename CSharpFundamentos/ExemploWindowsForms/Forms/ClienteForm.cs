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
    }
}
