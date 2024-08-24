namespace ExemploWindowsForms.Forms
{
    partial class ProdutoFrom
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
            dataGridViewProdutos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCategoria = new DataGridViewTextBoxColumn();
            ColumnQuantidadeEstoque = new DataGridViewTextBoxColumn();
            ColumnPrecoUnitario = new DataGridViewTextBoxColumn();
            labelFiltros = new Label();
            labelFiltroNome = new Label();
            textBoxFiltroNome = new TextBox();
            labelTotal = new Label();
            labelNome = new Label();
            buttonSalvar = new Button();
            textBoxNome = new TextBox();
            radioButtonHabilitadoVendaSim = new RadioButton();
            radioButtonHabilitadoVendaNao = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            labelCategoria = new Label();
            comboBoxCategoria = new ComboBox();
            buttonCadastrarCategoria = new Button();
            label6 = new Label();
            labelHabilitadoVenda = new Label();
            labelPrecoUnitario = new Label();
            maskedTextBoxPrecoUnitario = new MaskedTextBox();
            buttonCancelar = new Button();
            labelValorTotal = new Label();
            labelQuantidadeEstoque = new Label();
            numericUpDownQuantidadeEstoque = new NumericUpDown();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelFiltroCategoria = new Label();
            comboBoxFiltroCategoria = new ComboBox();
            panel1 = new Panel();
            buttonPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeEstoque).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCategoria, ColumnQuantidadeEstoque, ColumnPrecoUnitario });
            dataGridViewProdutos.Location = new Point(12, 164);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutos.Size = new Size(913, 467);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCategoria
            // 
            ColumnCategoria.HeaderText = "Categoria";
            ColumnCategoria.MinimumWidth = 6;
            ColumnCategoria.Name = "ColumnCategoria";
            ColumnCategoria.ReadOnly = true;
            ColumnCategoria.Width = 125;
            // 
            // ColumnQuantidadeEstoque
            // 
            ColumnQuantidadeEstoque.HeaderText = "Estoque";
            ColumnQuantidadeEstoque.MinimumWidth = 6;
            ColumnQuantidadeEstoque.Name = "ColumnQuantidadeEstoque";
            ColumnQuantidadeEstoque.ReadOnly = true;
            ColumnQuantidadeEstoque.Width = 125;
            // 
            // ColumnPrecoUnitario
            // 
            ColumnPrecoUnitario.HeaderText = "Preço Unitário";
            ColumnPrecoUnitario.MinimumWidth = 6;
            ColumnPrecoUnitario.Name = "ColumnPrecoUnitario";
            ColumnPrecoUnitario.ReadOnly = true;
            ColumnPrecoUnitario.Width = 125;
            // 
            // labelFiltros
            // 
            labelFiltros.AutoSize = true;
            labelFiltros.Location = new Point(3, 3);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(49, 20);
            labelFiltros.TabIndex = 1;
            labelFiltros.Text = "Filtros";
            // 
            // labelFiltroNome
            // 
            labelFiltroNome.AutoSize = true;
            labelFiltroNome.Location = new Point(263, 35);
            labelFiltroNome.Name = "labelFiltroNome";
            labelFiltroNome.Size = new Size(50, 20);
            labelFiltroNome.TabIndex = 2;
            labelFiltroNome.Text = "Nome";
            // 
            // textBoxFiltroNome
            // 
            textBoxFiltroNome.Location = new Point(263, 58);
            textBoxFiltroNome.Name = "textBoxFiltroNome";
            textBoxFiltroNome.Size = new Size(606, 27);
            textBoxFiltroNome.TabIndex = 3;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(768, 634);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(42, 20);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(946, 2);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 5;
            labelNome.Text = "Nome";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_32;
            buttonSalvar.Location = new Point(1369, 296);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(48, 48);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(946, 25);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(471, 27);
            textBoxNome.TabIndex = 7;
            // 
            // radioButtonHabilitadoVendaSim
            // 
            radioButtonHabilitadoVendaSim.AutoSize = true;
            radioButtonHabilitadoVendaSim.Location = new Point(1168, 213);
            radioButtonHabilitadoVendaSim.Name = "radioButtonHabilitadoVendaSim";
            radioButtonHabilitadoVendaSim.Size = new Size(55, 24);
            radioButtonHabilitadoVendaSim.TabIndex = 8;
            radioButtonHabilitadoVendaSim.TabStop = true;
            radioButtonHabilitadoVendaSim.Text = "Sim";
            radioButtonHabilitadoVendaSim.UseVisualStyleBackColor = true;
            // 
            // radioButtonHabilitadoVendaNao
            // 
            radioButtonHabilitadoVendaNao.AutoSize = true;
            radioButtonHabilitadoVendaNao.Location = new Point(1168, 242);
            radioButtonHabilitadoVendaNao.Name = "radioButtonHabilitadoVendaNao";
            radioButtonHabilitadoVendaNao.Size = new Size(58, 24);
            radioButtonHabilitadoVendaNao.TabIndex = 9;
            radioButtonHabilitadoVendaNao.TabStop = true;
            radioButtonHabilitadoVendaNao.Text = "Não";
            radioButtonHabilitadoVendaNao.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(946, 213);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(946, 243);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(946, 273);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(946, 66);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(74, 20);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(946, 89);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(430, 28);
            comboBoxCategoria.TabIndex = 14;
            // 
            // buttonCadastrarCategoria
            // 
            buttonCadastrarCategoria.Image = Properties.Resources.add_24;
            buttonCadastrarCategoria.Location = new Point(1382, 85);
            buttonCadastrarCategoria.Name = "buttonCadastrarCategoria";
            buttonCadastrarCategoria.Size = new Size(35, 35);
            buttonCadastrarCategoria.TabIndex = 15;
            buttonCadastrarCategoria.UseVisualStyleBackColor = true;
            buttonCadastrarCategoria.Click += buttonCadastrarCategoria_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(946, 190);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // labelHabilitadoVenda
            // 
            labelHabilitadoVenda.AutoSize = true;
            labelHabilitadoVenda.Location = new Point(1168, 190);
            labelHabilitadoVenda.Name = "labelHabilitadoVenda";
            labelHabilitadoVenda.Size = new Size(125, 20);
            labelHabilitadoVenda.TabIndex = 17;
            labelHabilitadoVenda.Text = "Habilitado Venda";
            // 
            // labelPrecoUnitario
            // 
            labelPrecoUnitario.AutoSize = true;
            labelPrecoUnitario.Location = new Point(1165, 132);
            labelPrecoUnitario.Name = "labelPrecoUnitario";
            labelPrecoUnitario.Size = new Size(103, 20);
            labelPrecoUnitario.TabIndex = 18;
            labelPrecoUnitario.Text = "Preço Unitário";
            // 
            // maskedTextBoxPrecoUnitario
            // 
            maskedTextBoxPrecoUnitario.Location = new Point(1165, 155);
            maskedTextBoxPrecoUnitario.Name = "maskedTextBoxPrecoUnitario";
            maskedTextBoxPrecoUnitario.Size = new Size(252, 27);
            maskedTextBoxPrecoUnitario.TabIndex = 19;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.close_32;
            buttonCancelar.Location = new Point(1315, 296);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(48, 48);
            buttonCancelar.TabIndex = 20;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Location = new Point(816, 634);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(109, 20);
            labelValorTotal.TabIndex = 21;
            labelValorTotal.Text = "labelValorTotal";
            // 
            // labelQuantidadeEstoque
            // 
            labelQuantidadeEstoque.AutoSize = true;
            labelQuantidadeEstoque.Location = new Point(946, 129);
            labelQuantidadeEstoque.Name = "labelQuantidadeEstoque";
            labelQuantidadeEstoque.Size = new Size(144, 20);
            labelQuantidadeEstoque.TabIndex = 22;
            labelQuantidadeEstoque.Text = "Quantidade Estoque";
            // 
            // numericUpDownQuantidadeEstoque
            // 
            numericUpDownQuantidadeEstoque.Location = new Point(946, 155);
            numericUpDownQuantidadeEstoque.Name = "numericUpDownQuantidadeEstoque";
            numericUpDownQuantidadeEstoque.Size = new Size(200, 27);
            numericUpDownQuantidadeEstoque.TabIndex = 23;
            // 
            // buttonEditar
            // 
            buttonEditar.Image = Properties.Resources.pencil_32;
            buttonEditar.Location = new Point(820, 112);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(48, 48);
            buttonEditar.TabIndex = 24;
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Image = Properties.Resources.recycle_bin_32;
            buttonApagar.Location = new Point(874, 112);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(48, 48);
            buttonApagar.TabIndex = 25;
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // labelFiltroCategoria
            // 
            labelFiltroCategoria.AutoSize = true;
            labelFiltroCategoria.Location = new Point(3, 35);
            labelFiltroCategoria.Name = "labelFiltroCategoria";
            labelFiltroCategoria.Size = new Size(74, 20);
            labelFiltroCategoria.TabIndex = 26;
            labelFiltroCategoria.Text = "Categoria";
            // 
            // comboBoxFiltroCategoria
            // 
            comboBoxFiltroCategoria.FormattingEnabled = true;
            comboBoxFiltroCategoria.Location = new Point(3, 58);
            comboBoxFiltroCategoria.Name = "comboBoxFiltroCategoria";
            comboBoxFiltroCategoria.Size = new Size(236, 28);
            comboBoxFiltroCategoria.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPesquisar);
            panel1.Controls.Add(textBoxFiltroNome);
            panel1.Controls.Add(labelFiltroCategoria);
            panel1.Controls.Add(comboBoxFiltroCategoria);
            panel1.Controls.Add(labelFiltroNome);
            panel1.Controls.Add(labelFiltros);
            panel1.Location = new Point(12, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 100);
            panel1.TabIndex = 28;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Image = Properties.Resources.search_32;
            buttonPesquisar.Location = new Point(875, 54);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(35, 35);
            buttonPesquisar.TabIndex = 28;
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // ProdutoFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 660);
            Controls.Add(panel1);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(numericUpDownQuantidadeEstoque);
            Controls.Add(labelQuantidadeEstoque);
            Controls.Add(labelValorTotal);
            Controls.Add(buttonCancelar);
            Controls.Add(maskedTextBoxPrecoUnitario);
            Controls.Add(labelPrecoUnitario);
            Controls.Add(labelHabilitadoVenda);
            Controls.Add(label6);
            Controls.Add(buttonCadastrarCategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(radioButtonHabilitadoVendaNao);
            Controls.Add(radioButtonHabilitadoVendaSim);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSalvar);
            Controls.Add(labelNome);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewProdutos);
            Name = "ProdutoFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema - Produtos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidadeEstoque).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonApagar;
        private Button buttonCadastrarCategoria;
        private Button buttonCancelar;
        private Button buttonEditar;
        private Button buttonPesquisar;
        private Button buttonSalvar;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxFiltroCategoria;
        private DataGridView dataGridViewProdutos;
        private Label label6;
        private Label labelCategoria;
        private Label labelFiltroCategoria;
        private Label labelFiltroNome;
        private Label labelFiltros;
        private Label labelHabilitadoVenda;
        private Label labelNome;
        private Label labelPrecoUnitario;
        private Label labelQuantidadeEstoque;
        private Label labelTotal;
        private Label labelValorTotal;
        private MaskedTextBox maskedTextBoxPrecoUnitario;
        private NumericUpDown numericUpDownQuantidadeEstoque;
        private Panel panel1;
        private RadioButton radioButtonHabilitadoVendaNao;
        private RadioButton radioButtonHabilitadoVendaSim;
        private TextBox textBoxFiltroNome;
        private TextBox textBoxNome;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCategoria;
        private DataGridViewTextBoxColumn ColumnQuantidadeEstoque;
        private DataGridViewTextBoxColumn ColumnPrecoUnitario;
    }
}