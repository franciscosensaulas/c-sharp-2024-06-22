namespace ExemploWindowsForms.Forms
{
    partial class CategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaForm));
            dataGridViewCategorias = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            buttonEditar = new Button();
            buttonApagar = new Button();
            labelNome = new Label();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            dataGridViewCategorias.AllowUserToAddRows = false;
            dataGridViewCategorias.AllowUserToDeleteRows = false;
            resources.ApplyResources(dataGridViewCategorias, "dataGridViewCategorias");
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorias.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome });
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.ReadOnly = true;
            dataGridViewCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategorias.CellContentClick += dataGridViewCategorias_CellContentClick;
            // 
            // ColumnId
            // 
            resources.ApplyResources(ColumnId, "ColumnId");
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(ColumnNome, "ColumnNome");
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // buttonEditar
            // 
            resources.ApplyResources(buttonEditar, "buttonEditar");
            buttonEditar.Image = Properties.Resources.pencil_32;
            buttonEditar.Name = "buttonEditar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonApagar
            // 
            resources.ApplyResources(buttonApagar, "buttonApagar");
            buttonApagar.Image = Properties.Resources.recycle_bin_32;
            buttonApagar.Name = "buttonApagar";
            buttonApagar.UseVisualStyleBackColor = true;
            buttonApagar.Click += buttonApagar_Click;
            // 
            // labelNome
            // 
            resources.ApplyResources(labelNome, "labelNome");
            labelNome.Name = "labelNome";
            // 
            // textBoxNome
            // 
            resources.ApplyResources(textBoxNome, "textBoxNome");
            textBoxNome.Name = "textBoxNome";
            // 
            // buttonSalvar
            // 
            resources.ApplyResources(buttonSalvar, "buttonSalvar");
            buttonSalvar.Image = Properties.Resources.floppy_disk_32;
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // CategoriaForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(buttonApagar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridViewCategorias);
            Name = "CategoriaForm";
            Activated += CategoriaForm_Activated;
            Load += CategoriaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCategorias;
        private Button buttonEditar;
        private Button buttonApagar;
        private Label labelNome;
        private TextBox textBoxNome;
        private Button buttonSalvar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
    }
}