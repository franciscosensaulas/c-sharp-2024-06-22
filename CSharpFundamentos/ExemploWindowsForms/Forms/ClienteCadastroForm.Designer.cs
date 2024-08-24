namespace ExemploWindowsForms.Forms
{
    partial class ClienteCadastroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCPF = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            labelEmail = new Label();
            textBox2 = new TextBox();
            labelUf = new Label();
            comboBoxUf = new ComboBox();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            labelCep = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            labelNumero = new Label();
            textBox1 = new TextBox();
            labelComplemento = new Label();
            richTextBoxDescricao = new RichTextBox();
            labelDescrição = new Label();
            textBoxComplemento = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 10);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(616, 27);
            textBoxNome.TabIndex = 2;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(12, 68);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(33, 20);
            labelCPF.TabIndex = 3;
            labelCPF.Text = "CPF";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(12, 91);
            maskedTextBoxCpf.Mask = "000\\.000\\.000\\-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(246, 27);
            maskedTextBoxCpf.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(279, 68);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 27);
            textBox2.TabIndex = 6;
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Location = new Point(12, 121);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(26, 20);
            labelUf.TabIndex = 7;
            labelUf.Text = "UF";
            // 
            // comboBoxUf
            // 
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUf.Location = new Point(12, 144);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(115, 28);
            comboBoxUf.TabIndex = 8;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(133, 121);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(56, 20);
            labelCidade.TabIndex = 9;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(133, 144);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(234, 27);
            textBoxCidade.TabIndex = 10;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(382, 144);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(246, 27);
            textBoxBairro.TabIndex = 11;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(382, 121);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 12;
            labelBairro.Text = "Bairro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(382, 175);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 13;
            labelCep.Text = "CEP";
            labelCep.Click += label1_Click;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(382, 198);
            maskedTextBoxCep.Mask = "00\\.000\\-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.RejectInputOnFirstFailure = true;
            maskedTextBoxCep.Size = new Size(110, 27);
            maskedTextBoxCep.TabIndex = 14;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(498, 174);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 15;
            labelNumero.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(498, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 16;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(12, 228);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 17;
            labelComplemento.Text = "Complemento";
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(12, 304);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(616, 120);
            richTextBoxDescricao.TabIndex = 18;
            richTextBoxDescricao.Text = "";
            // 
            // labelDescrição
            // 
            labelDescrição.AutoSize = true;
            labelDescrição.Location = new Point(12, 281);
            labelDescrição.Name = "labelDescrição";
            labelDescrição.Size = new Size(74, 20);
            labelDescrição.TabIndex = 19;
            labelDescrição.Text = "Descrição";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(12, 251);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(616, 27);
            textBoxComplemento.TabIndex = 20;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_32;
            buttonSalvar.Location = new Point(498, 430);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(130, 55);
            buttonSalvar.TabIndex = 21;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.close_32;
            buttonCancelar.Location = new Point(353, 430);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(130, 55);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(12, 198);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(355, 27);
            textBoxLogradouro.TabIndex = 23;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(12, 175);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(87, 20);
            labelLogradouro.TabIndex = 24;
            labelLogradouro.Text = "Logradouro";
            // 
            // ClienteCadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 501);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelDescrição);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(labelComplemento);
            Controls.Add(textBox1);
            Controls.Add(labelNumero);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(labelCep);
            Controls.Add(labelBairro);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxCidade);
            Controls.Add(labelCidade);
            Controls.Add(comboBoxUf);
            Controls.Add(labelUf);
            Controls.Add(textBox2);
            Controls.Add(labelEmail);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(labelCPF);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "ClienteCadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema - Cliente Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCPF;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelEmail;
        private TextBox textBox2;
        private Label labelUf;
        private ComboBox comboBoxUf;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelNumero;
        private TextBox textBox1;
        private Label labelComplemento;
        private RichTextBox richTextBoxDescricao;
        private Label labelDescrição;
        private TextBox textBoxComplemento;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
    }
}