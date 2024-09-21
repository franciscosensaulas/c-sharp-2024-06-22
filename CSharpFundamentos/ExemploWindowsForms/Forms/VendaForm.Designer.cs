namespace ExemploWindowsForms.Forms
{
    partial class VendaForm
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
            comboBoxProdutos = new ComboBox();
            labelProduto = new Label();
            labelPrecoUnitario = new Label();
            labelPrecoParcial = new Label();
            labelQuantidade = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            labelCliente = new Label();
            comboBoxClientes = new ComboBox();
            labelPrecoUnitarioTexto = new Label();
            labelPrecoParcialTexto = new Label();
            buttonAdicionar = new Button();
            labelStatus = new Label();
            labelStatusTexto = new Label();
            labelDataHoraAbertura = new Label();
            labelDataHoraAberturaTexto = new Label();
            labelDataHoraFechamento = new Label();
            labelDataHoraFechamentoTexto = new Label();
            dataGridViewCarrinho = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnProduto = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            ColumnPrecoParcial = new DataGridViewTextBoxColumn();
            labelTexto = new Label();
            labelTotalTexto = new Label();
            buttonFecharPedido = new Button();
            buttonCancelarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProdutos
            // 
            comboBoxProdutos.DisplayMember = "Nome";
            comboBoxProdutos.Enabled = false;
            comboBoxProdutos.FormattingEnabled = true;
            comboBoxProdutos.Location = new Point(382, 44);
            comboBoxProdutos.Name = "comboBoxProdutos";
            comboBoxProdutos.Size = new Size(378, 28);
            comboBoxProdutos.TabIndex = 0;
            comboBoxProdutos.ValueMember = "Nome";
            comboBoxProdutos.SelectedIndexChanged += comboBoxProdutos_SelectedIndexChanged;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Enabled = false;
            labelProduto.Location = new Point(382, 20);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(62, 20);
            labelProduto.TabIndex = 1;
            labelProduto.Text = "Produto";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Enabled = false;
            labelPrecoUnitario.Location = new Point(382, 141);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 2;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // labelPrecoParcial
            // 
            labelPrecoParcial.AutoSize = true;
            labelPrecoParcial.Enabled = false;
            labelPrecoParcial.Location = new Point(382, 171);
            labelPrecoParcial.Name = "labelPrecoParcial";
            labelPrecoParcial.Size = new Size(93, 20);
            labelPrecoParcial.TabIndex = 3;
            labelPrecoParcial.Text = "Preço Parcial";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Enabled = false;
            labelQuantidade.Location = new Point(382, 79);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 4;
            labelQuantidade.Text = "Quantidade";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Enabled = false;
            numericUpDownQuantidade.Location = new Point(382, 102);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(378, 27);
            numericUpDownQuantidade.TabIndex = 5;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(22, 20);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(55, 20);
            labelCliente.TabIndex = 6;
            labelCliente.Text = "Cliente";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DisplayMember = "Nome";
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(22, 44);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(327, 28);
            comboBoxClientes.TabIndex = 7;
            comboBoxClientes.ValueMember = "Nome";
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // labelPrecoUnitarioTexto
            // 
            labelPrecoUnitarioTexto.AutoSize = true;
            labelPrecoUnitarioTexto.Enabled = false;
            labelPrecoUnitarioTexto.Location = new Point(703, 141);
            labelPrecoUnitarioTexto.Name = "labelPrecoUnitarioTexto";
            labelPrecoUnitarioTexto.Size = new Size(57, 20);
            labelPrecoUnitarioTexto.TabIndex = 8;
            labelPrecoUnitarioTexto.Text = "R$ 0,00";
            // 
            // labelPrecoParcialTexto
            // 
            labelPrecoParcialTexto.AutoSize = true;
            labelPrecoParcialTexto.Enabled = false;
            labelPrecoParcialTexto.Location = new Point(703, 171);
            labelPrecoParcialTexto.Name = "labelPrecoParcialTexto";
            labelPrecoParcialTexto.Size = new Size(57, 20);
            labelPrecoParcialTexto.TabIndex = 9;
            labelPrecoParcialTexto.Text = "R$ 0,00";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Enabled = false;
            buttonAdicionar.Location = new Point(666, 194);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(94, 29);
            buttonAdicionar.TabIndex = 10;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Enabled = false;
            labelStatus.Location = new Point(22, 79);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(49, 20);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Status";
            // 
            // labelStatusTexto
            // 
            labelStatusTexto.AutoSize = true;
            labelStatusTexto.Enabled = false;
            labelStatusTexto.Location = new Point(273, 79);
            labelStatusTexto.Name = "labelStatusTexto";
            labelStatusTexto.Size = new Size(76, 20);
            labelStatusTexto.TabIndex = 12;
            labelStatusTexto.Text = "Concluído";
            // 
            // labelDataHoraAbertura
            // 
            labelDataHoraAbertura.AutoSize = true;
            labelDataHoraAbertura.Enabled = false;
            labelDataHoraAbertura.Location = new Point(22, 102);
            labelDataHoraAbertura.Name = "labelDataHoraAbertura";
            labelDataHoraAbertura.Size = new Size(140, 20);
            labelDataHoraAbertura.TabIndex = 13;
            labelDataHoraAbertura.Text = "Data Hora Abertura";
            // 
            // labelDataHoraAberturaTexto
            // 
            labelDataHoraAberturaTexto.AutoSize = true;
            labelDataHoraAberturaTexto.Enabled = false;
            labelDataHoraAberturaTexto.Location = new Point(206, 104);
            labelDataHoraAberturaTexto.Name = "labelDataHoraAberturaTexto";
            labelDataHoraAberturaTexto.Size = new Size(143, 20);
            labelDataHoraAberturaTexto.TabIndex = 14;
            labelDataHoraAberturaTexto.Text = "01/12/2024 23:00:00";
            // 
            // labelDataHoraFechamento
            // 
            labelDataHoraFechamento.AutoSize = true;
            labelDataHoraFechamento.Enabled = false;
            labelDataHoraFechamento.Location = new Point(22, 141);
            labelDataHoraFechamento.Name = "labelDataHoraFechamento";
            labelDataHoraFechamento.Size = new Size(163, 20);
            labelDataHoraFechamento.TabIndex = 15;
            labelDataHoraFechamento.Text = "Data Hora Fechamento";
            // 
            // labelDataHoraFechamentoTexto
            // 
            labelDataHoraFechamentoTexto.AutoSize = true;
            labelDataHoraFechamentoTexto.Enabled = false;
            labelDataHoraFechamentoTexto.Location = new Point(206, 141);
            labelDataHoraFechamentoTexto.Name = "labelDataHoraFechamentoTexto";
            labelDataHoraFechamentoTexto.Size = new Size(143, 20);
            labelDataHoraFechamentoTexto.TabIndex = 16;
            labelDataHoraFechamentoTexto.Text = "02/12/2024 09:45:00";
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.AllowUserToAddRows = false;
            dataGridViewCarrinho.AllowUserToDeleteRows = false;
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnProduto, ColumnQuantidade, ColumnPrecoUnitario, ColumnPrecoParcial });
            dataGridViewCarrinho.Enabled = false;
            dataGridViewCarrinho.Location = new Point(807, 44);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.ReadOnly = true;
            dataGridViewCarrinho.RowHeadersWidth = 51;
            dataGridViewCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCarrinho.Size = new Size(715, 613);
            dataGridViewCarrinho.TabIndex = 19;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // ColumnProduto
            // 
            ColumnProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnProduto.HeaderText = "Produto";
            ColumnProduto.MinimumWidth = 6;
            ColumnProduto.Name = "ColumnProduto";
            ColumnProduto.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.MinimumWidth = 6;
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            ColumnQuantidade.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // ColumnPrecoParcial
            // 
            ColumnPrecoParcial.HeaderText = "Total";
            ColumnPrecoParcial.MinimumWidth = 6;
            ColumnPrecoParcial.Name = "ColumnPrecoParcial";
            ColumnPrecoParcial.ReadOnly = true;
            ColumnPrecoParcial.Width = 125;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Enabled = false;
            labelTexto.Location = new Point(1395, 660);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(42, 20);
            labelTexto.TabIndex = 20;
            labelTexto.Text = "Total";
            // 
            // labelTotalTexto
            // 
            labelTotalTexto.AutoSize = true;
            labelTotalTexto.Enabled = false;
            labelTotalTexto.Location = new Point(1465, 660);
            labelTotalTexto.Name = "labelTotalTexto";
            labelTotalTexto.Size = new Size(57, 20);
            labelTotalTexto.TabIndex = 21;
            labelTotalTexto.Text = "R$ 0,00";
            // 
            // buttonFecharPedido
            // 
            buttonFecharPedido.Enabled = false;
            buttonFecharPedido.Location = new Point(1392, 12);
            buttonFecharPedido.Name = "buttonFecharPedido";
            buttonFecharPedido.Size = new Size(130, 29);
            buttonFecharPedido.TabIndex = 22;
            buttonFecharPedido.Text = "Fechar Pedido";
            buttonFecharPedido.UseVisualStyleBackColor = true;
            buttonFecharPedido.Click += buttonFecharPedido_Click;
            // 
            // buttonCancelarPedido
            // 
            buttonCancelarPedido.Enabled = false;
            buttonCancelarPedido.Location = new Point(1250, 12);
            buttonCancelarPedido.Name = "buttonCancelarPedido";
            buttonCancelarPedido.Size = new Size(136, 29);
            buttonCancelarPedido.TabIndex = 23;
            buttonCancelarPedido.Text = "Cancelar Pedido";
            buttonCancelarPedido.UseVisualStyleBackColor = true;
            buttonCancelarPedido.Click += buttonCancelarPedido_Click;
            // 
            // VendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 709);
            Controls.Add(buttonCancelarPedido);
            Controls.Add(buttonFecharPedido);
            Controls.Add(labelTotalTexto);
            Controls.Add(labelTexto);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(labelDataHoraFechamentoTexto);
            Controls.Add(labelDataHoraFechamento);
            Controls.Add(labelDataHoraAberturaTexto);
            Controls.Add(labelDataHoraAbertura);
            Controls.Add(labelStatusTexto);
            Controls.Add(labelStatus);
            Controls.Add(buttonAdicionar);
            Controls.Add(labelPrecoParcialTexto);
            Controls.Add(labelPrecoUnitarioTexto);
            Controls.Add(comboBoxClientes);
            Controls.Add(labelCliente);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(labelQuantidade);
            Controls.Add(labelPrecoParcial);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelProduto);
            Controls.Add(comboBoxProdutos);
            Name = "VendaForm";
            Text = "VendaForm";
            Load += VendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProdutos;
        private Label labelProduto;
        private Label labelPrecoUnitario;
        private Label labelPrecoParcial;
        private Label labelQuantidade;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelCliente;
        private ComboBox comboBoxClientes;
        private Label labelPrecoUnitarioTexto;
        private Label labelPrecoParcialTexto;
        private Button buttonAdicionar;
        private Label labelStatus;
        private Label labelStatusTexto;
        private Label labelDataHoraAbertura;
        private Label labelDataHoraAberturaTexto;
        private Label labelDataHoraFechamento;
        private Label labelDataHoraFechamentoTexto;
        private DataGridView dataGridViewCarrinho;
        private Label labelTexto;
        private Label labelTotalTexto;
        private Button buttonFecharPedido;
        private Button buttonCancelarPedido;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnProduto;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
        private DataGridViewTextBoxColumn ColumnPrecoParcial;
    }
}