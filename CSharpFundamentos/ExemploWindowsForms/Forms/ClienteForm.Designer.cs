namespace ExemploWindowsForms.Forms
{
    partial class ClienteForm
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
            dataGridViewClientes = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCpf = new DataGridViewTextBoxColumn();
            ColumnEndereco = new DataGridViewTextBoxColumn();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonCadastrar = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCpf, ColumnEndereco });
            dataGridViewClientes.Location = new Point(15, 88);
            dataGridViewClientes.Margin = new Padding(4);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(970, 460);
            dataGridViewClientes.TabIndex = 0;
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
            // ColumnCpf
            // 
            ColumnCpf.HeaderText = "CPF";
            ColumnCpf.MinimumWidth = 6;
            ColumnCpf.Name = "ColumnCpf";
            ColumnCpf.ReadOnly = true;
            ColumnCpf.Width = 125;
            // 
            // ColumnEndereco
            // 
            ColumnEndereco.HeaderText = "Endereço";
            ColumnEndereco.MinimumWidth = 6;
            ColumnEndereco.Name = "ColumnEndereco";
            ColumnEndereco.ReadOnly = true;
            ColumnEndereco.Width = 125;
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(15, 20);
            labelPesquisa.Margin = new Padding(4, 0, 4, 0);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(80, 25);
            labelPesquisa.TabIndex = 1;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPesquisa.Location = new Point(104, 16);
            textBoxPesquisa.Margin = new Padding(4);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(434, 31);
            textBoxPesquisa.TabIndex = 2;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCadastrar.Image = Properties.Resources.add_32;
            buttonCadastrar.Location = new Point(916, 11);
            buttonCadastrar.Margin = new Padding(4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(69, 69);
            buttonCadastrar.TabIndex = 3;
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Image = Properties.Resources.pencil_32;
            buttonEditar.Location = new Point(840, 11);
            buttonEditar.Margin = new Padding(4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(69, 69);
            buttonEditar.TabIndex = 4;
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            buttonApagar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApagar.Image = Properties.Resources.recycle_bin_32;
            buttonApagar.Location = new Point(764, 11);
            buttonApagar.Margin = new Padding(4);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(69, 69);
            buttonApagar.TabIndex = 5;
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 562);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(dataGridViewClientes);
            Margin = new Padding(4);
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema - Clientes";
            Activated += ClienteForm_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClientes;
        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnEndereco;
    }
}