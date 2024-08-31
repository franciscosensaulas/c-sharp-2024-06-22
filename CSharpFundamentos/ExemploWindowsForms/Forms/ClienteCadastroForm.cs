using ExemploWindowsForms.Entidades;
using ExemploWindowsForms.Modelos;
using ExemploWindowsForms.Repositorios;
using Newtonsoft.Json;
using System.Net;
using System.Text.RegularExpressions;

namespace ExemploWindowsForms.Forms
{
    public partial class ClienteCadastroForm : Form
    {
        private readonly ClienteRepositorio _clienteRepositorio;
        private int? idParaEditar;

        private const string PatternEmail = @"^[a-zA-Z0-9]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$";

        public ClienteCadastroForm()
        {
            _clienteRepositorio = new ClienteRepositorio();
            InitializeComponent();
        }


        // : this() executará o construtor acima, para instanciar o objeto do repositório e
        // construir a tela
        public ClienteCadastroForm(int idCliente) : this()
        {
            // Armazenar o id do cliente para depois no click do salvar poder realizar o
            // update do reigstro
            idParaEditar = idCliente;

            // Consultar o cliente através do id na tabela de clientes
            var cliente = _clienteRepositorio.ObterPorId(idCliente);

            if (cliente is null)
            {
                MessageBox.Show("Cliente não encontrado");
                Dispose();
                return;
            }

            textBoxNome.Text = cliente.Nome;
            textBoxNome.Text = cliente.Nome;
            maskedTextBoxCpf.Text = cliente.Cpf;
            textBoxEmail.Text = cliente.Email;
            comboBoxUf.SelectedItem = cliente.Uf;
            textBoxCidade.Text = cliente.Cidade;
            textBoxLogradouro.Text = cliente.Logradouro;
            textBoxBairro.Text = cliente.Bairro;
            maskedTextBoxCep.Text = cliente.Cep;
            textBoxNumero.Text = cliente.Numero;
            textBoxComplemento.Text = cliente.Complemento;
            richTextBoxDescricao.Text = cliente.Descricao;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (EhFormValido() == false)
                return;

            var cliente = new Cliente();
            cliente.Nome = textBoxNome.Text.Trim();
            cliente.Cpf = maskedTextBoxCpf.Text.Trim();
            cliente.Email = textBoxEmail.Text.Trim();
            cliente.Uf = comboBoxUf.SelectedItem.ToString();
            cliente.Cidade = textBoxCidade.Text.Trim();
            cliente.Logradouro = textBoxLogradouro.Text.Trim();
            cliente.Bairro = textBoxBairro.Text.Trim();
            cliente.Cep = maskedTextBoxCep.Text.Trim();
            cliente.Numero = textBoxNumero.Text.Trim();
            cliente.Complemento = textBoxComplemento.Text.Trim();
            cliente.Descricao = richTextBoxDescricao.Text.Trim();

            if (idParaEditar is null)
            {
                _clienteRepositorio.Adicionar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            else
            {
                cliente.Id = idParaEditar.GetValueOrDefault();
                _clienteRepositorio.Editar(cliente);
                MessageBox.Show("Cliente alterado com sucesso");
            }
            Dispose();
        }

        private bool EhFormValido()
        {
            // Min 3, Máx 100
            //if(textBoxNome.Text.Trim().Length < 3)
            //{
            //    MessageBox.Show("Nome deve conter no mínimo 3 caracteres");
            //    textBoxNome.Focus();
            //    return false;
            //}
            //if (textBoxNome.Text.Trim().Length > 250)
            //{
            //    MessageBox.Show("Nome deve conter no máximo 250 caracteres");
            //    textBoxNome.Focus();
            //    return false;5
            //}
            if (IsTextBoxValido(textBoxNome, labelNome, 3, 250) == false)
                return false;

            if (IsMaskedTextBoxValido(maskedTextBoxCpf, labelCPF) == false)
                return false;


            var regex = new Regex(PatternEmail);
            if (regex.IsMatch(textBoxEmail.Text.Trim()) == false)
            {
                MessageBox.Show("E-mail não corresponde a um e-mail válido");
                textBoxEmail.Focus();
                return false;
            }


            if (IsTextBoxValido(textBoxEmail, labelCidade, tamanhoMaximo: 200) == false)
                return false;

            if (comboBoxUf.SelectedIndex == -1)
            {
                MessageBox.Show("Unidade Federativa não selecionada");
                comboBoxUf.DroppedDown = true;
                return false;
            }

            if (IsTextBoxValido(textBoxCidade, labelCidade, 3, 100) == false)
                return false;

            if (IsTextBoxValido(textBoxBairro, labelBairro, 3, 100) == false)
                return false;

            if (IsTextBoxValido(textBoxLogradouro, labelLogradouro, 3, 150) == false)
                return false;

            if (IsMaskedTextBoxValido(maskedTextBoxCep, labelCep) == false)
                return false;

            if (IsTextBoxValido(textBoxNumero, labelNumero, 1, 50) == false)
                return false;

            if (IsTextBoxValido(textBoxComplemento, labelComplemento, 4, 150) == false)
                return false;

            return true;
        }

        //if (IsMaskedTextBoxValido(maskedTextBoxCpf, labelCPF) == false)
        //      return false;

        private bool IsMaskedTextBoxValido(MaskedTextBox maskedTextBox, Label label)
        {
            if (maskedTextBox.MaskCompleted == false)
            {
                MessageBox.Show($"{label.Text} preenchido(a) incorretamente");
                maskedTextBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsTextBoxValido(
            TextBox textBoxValidar,
            Label label,
            int? tamanhoMinimo = null,
            int? tamanhoMaximo = null)
        {
            if (tamanhoMinimo is not null && textBoxValidar.Text.Trim().Length < tamanhoMinimo)
            {
                MessageBox.Show($"{label.Text} deve conter no mínimo {tamanhoMinimo} caracteres");
                textBoxValidar.Focus();
                return false;
            }

            if (tamanhoMaximo is not null && textBoxValidar.Text.Trim().Length > tamanhoMaximo)
            {
                MessageBox.Show($"{label.Text} deve conter no máximo {tamanhoMaximo} caracteres");
                textBoxValidar.Focus();
                return false;
            }
            return true;
        }

        private void BuscarDadosEnderecoPorCep()
        {
            if (IsMaskedTextBoxValido(maskedTextBoxCep, labelCep) == false)
                return;

            var cep = maskedTextBoxCep.Text.Replace(".", "").Replace("-", "");

            var httpClient = new HttpClient();
            var url = $"https://viacep.com.br/ws/{cep}/json/";
            var response = httpClient.GetAsync(url).Result;
            if (response == null || response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("CEP não encontrado");
                maskedTextBoxCep.Focus();
                return;
            }

            var conteudo = response.Content.ReadAsStringAsync().Result;
            var enderecoCep = JsonConvert.DeserializeObject<EnderecoCep>(conteudo);
            textBoxCidade.Text = enderecoCep.Localidade;
            textBoxLogradouro.Text = enderecoCep.Logradouro;
            textBoxBairro.Text = enderecoCep.Bairro;
            textBoxComplemento.Text = enderecoCep.Complemento;
            comboBoxUf.SelectedItem = enderecoCep.Uf;
        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            BuscarDadosEnderecoPorCep();
        }
    }
}
