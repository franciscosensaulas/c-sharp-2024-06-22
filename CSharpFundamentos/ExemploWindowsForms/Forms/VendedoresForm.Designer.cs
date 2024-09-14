namespace ExemploWindowsForms.Forms
{
    partial class VendedoresForm
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
            dataGridViewVendedores = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            labelNome = new Label();
            labelSenha = new Label();
            labelUsuario = new Label();
            textBoxNome = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVendedores
            // 
            dataGridViewVendedores.AllowUserToAddRows = false;
            dataGridViewVendedores.AllowUserToDeleteRows = false;
            dataGridViewVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendedores.Columns.AddRange(new DataGridViewColumn[] { ColumnId, Nome, ColumnUsuario });
            dataGridViewVendedores.Location = new Point(12, 22);
            dataGridViewVendedores.Name = "dataGridViewVendedores";
            dataGridViewVendedores.ReadOnly = true;
            dataGridViewVendedores.RowHeadersWidth = 51;
            dataGridViewVendedores.Size = new Size(645, 416);
            dataGridViewVendedores.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Código";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 125;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.HeaderText = "Usuário";
            ColumnUsuario.MinimumWidth = 6;
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            ColumnUsuario.Width = 125;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(675, 22);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(675, 127);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(675, 74);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuário";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(675, 45);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(335, 27);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(675, 97);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(335, 27);
            textBoxUsuario.TabIndex = 5;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(675, 150);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(335, 27);
            textBoxSenha.TabIndex = 6;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(916, 183);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 7;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // VendedoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 450);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxNome);
            Controls.Add(labelUsuario);
            Controls.Add(labelSenha);
            Controls.Add(labelNome);
            Controls.Add(dataGridViewVendedores);
            Name = "VendedoresForm";
            Text = "Vendedores";
            Load += VendedoresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVendedores;
        private Label labelNome;
        private Label labelSenha;
        private Label labelUsuario;
        private TextBox textBoxNome;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonSalvar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ColumnUsuario;
    }
}