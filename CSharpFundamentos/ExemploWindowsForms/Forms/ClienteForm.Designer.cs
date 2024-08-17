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
            dataGridView1 = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCpf = new DataGridViewTextBoxColumn();
            ColumnEndereco = new DataGridViewTextBoxColumn();
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonCadastrar = new Button();
            buttonEditar = new Button();
            buttonApagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCpf, ColumnEndereco });
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 368);
            dataGridView1.TabIndex = 0;
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
            labelPesquisa.Location = new Point(12, 16);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(65, 20);
            labelPesquisa.TabIndex = 1;
            labelPesquisa.Text = "Pesquisa";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(83, 13);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(348, 27);
            textBoxPesquisa.TabIndex = 2;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Image = Properties.Resources.add_32;
            buttonCadastrar.Location = new Point(733, 9);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(55, 55);
            buttonCadastrar.TabIndex = 3;
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Image = Properties.Resources.pencil_32;
            buttonEditar.Location = new Point(672, 9);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(55, 55);
            buttonEditar.TabIndex = 4;
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            buttonApagar.Image = Properties.Resources.recycle_bin_32;
            buttonApagar.Location = new Point(611, 9);
            buttonApagar.Name = "buttonApagar";
            buttonApagar.Size = new Size(55, 55);
            buttonApagar.TabIndex = 5;
            buttonApagar.UseVisualStyleBackColor = true;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            Controls.Add(dataGridView1);
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema - Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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