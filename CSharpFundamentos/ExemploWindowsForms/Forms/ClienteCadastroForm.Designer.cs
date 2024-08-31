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
            textBoxEmail = new TextBox();
            labelUf = new Label();
            comboBoxUf = new ComboBox();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            labelCep = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            labelComplemento = new Label();
            richTextBoxDescricao = new RichTextBox();
            labelDescrição = new Label();
            textBoxComplemento = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(15, 12);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(61, 25);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(15, 45);
            textBoxNome.Margin = new Padding(4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(769, 31);
            textBoxNome.TabIndex = 2;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(15, 85);
            labelCPF.Margin = new Padding(4, 0, 4, 0);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(42, 25);
            labelCPF.TabIndex = 3;
            labelCPF.Text = "CPF";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(15, 114);
            maskedTextBoxCpf.Margin = new Padding(4);
            maskedTextBoxCpf.Mask = "000\\.000\\.000\\-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(306, 31);
            maskedTextBoxCpf.TabIndex = 4;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(349, 85);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(61, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(349, 114);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(435, 31);
            textBoxEmail.TabIndex = 6;
            // 
            // labelUf
            // 
            labelUf.AutoSize = true;
            labelUf.Location = new Point(15, 151);
            labelUf.Margin = new Padding(4, 0, 4, 0);
            labelUf.Name = "labelUf";
            labelUf.Size = new Size(33, 25);
            labelUf.TabIndex = 7;
            labelUf.Text = "UF";
            // 
            // comboBoxUf
            // 
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxUf.Location = new Point(15, 180);
            comboBoxUf.Margin = new Padding(4);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(143, 33);
            comboBoxUf.TabIndex = 8;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(166, 151);
            labelCidade.Margin = new Padding(4, 0, 4, 0);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(67, 25);
            labelCidade.TabIndex = 9;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(166, 180);
            textBoxCidade.Margin = new Padding(4);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(292, 31);
            textBoxCidade.TabIndex = 10;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(478, 180);
            textBoxBairro.Margin = new Padding(4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(306, 31);
            textBoxBairro.TabIndex = 11;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(478, 151);
            labelBairro.Margin = new Padding(4, 0, 4, 0);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(58, 25);
            labelBairro.TabIndex = 12;
            labelBairro.Text = "Bairro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(478, 219);
            labelCep.Margin = new Padding(4, 0, 4, 0);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(42, 25);
            labelCep.TabIndex = 13;
            labelCep.Text = "CEP";
            labelCep.Click += label1_Click;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(478, 248);
            maskedTextBoxCep.Margin = new Padding(4);
            maskedTextBoxCep.Mask = "00\\.000\\-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.RejectInputOnFirstFailure = true;
            maskedTextBoxCep.Size = new Size(136, 31);
            maskedTextBoxCep.TabIndex = 14;
            maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(622, 218);
            labelNumero.Margin = new Padding(4, 0, 4, 0);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(77, 25);
            labelNumero.TabIndex = 15;
            labelNumero.Text = "Número";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(622, 248);
            textBoxNumero.Margin = new Padding(4);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(162, 31);
            textBoxNumero.TabIndex = 16;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(15, 285);
            labelComplemento.Margin = new Padding(4, 0, 4, 0);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(126, 25);
            labelComplemento.TabIndex = 17;
            labelComplemento.Text = "Complemento";
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(15, 380);
            richTextBoxDescricao.Margin = new Padding(4);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(769, 149);
            richTextBoxDescricao.TabIndex = 18;
            richTextBoxDescricao.Text = "";
            // 
            // labelDescrição
            // 
            labelDescrição.AutoSize = true;
            labelDescrição.Location = new Point(15, 351);
            labelDescrição.Margin = new Padding(4, 0, 4, 0);
            labelDescrição.Name = "labelDescrição";
            labelDescrição.Size = new Size(88, 25);
            labelDescrição.TabIndex = 19;
            labelDescrição.Text = "Descrição";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(15, 314);
            textBoxComplemento.Margin = new Padding(4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(769, 31);
            textBoxComplemento.TabIndex = 20;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_32;
            buttonSalvar.Location = new Point(622, 538);
            buttonSalvar.Margin = new Padding(4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(162, 69);
            buttonSalvar.TabIndex = 21;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.close_32;
            buttonCancelar.Location = new Point(441, 538);
            buttonCancelar.Margin = new Padding(4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(162, 69);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(15, 248);
            textBoxLogradouro.Margin = new Padding(4);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(443, 31);
            textBoxLogradouro.TabIndex = 23;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(15, 219);
            labelLogradouro.Margin = new Padding(4, 0, 4, 0);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(106, 25);
            labelLogradouro.TabIndex = 24;
            labelLogradouro.Text = "Logradouro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 25;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(56, 80);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 26;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(405, 80);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 27;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(46, 149);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 28;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(231, 149);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 29;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(531, 149);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 30;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(121, 217);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 31;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(516, 215);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 32;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(694, 215);
            label9.Name = "label9";
            label9.Size = new Size(20, 25);
            label9.TabIndex = 33;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(138, 283);
            label10.Name = "label10";
            label10.Size = new Size(20, 25);
            label10.TabIndex = 34;
            label10.Text = "*";
            // 
            // ClienteCadastroForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 626);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelDescrição);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumero);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(labelCep);
            Controls.Add(labelBairro);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxCidade);
            Controls.Add(labelCidade);
            Controls.Add(comboBoxUf);
            Controls.Add(labelUf);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(labelCPF);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Margin = new Padding(4);
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
        private TextBox textBoxEmail;
        private Label labelUf;
        private ComboBox comboBoxUf;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private Label labelCep;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private Label labelComplemento;
        private RichTextBox richTextBoxDescricao;
        private Label labelDescrição;
        private TextBox textBoxComplemento;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}