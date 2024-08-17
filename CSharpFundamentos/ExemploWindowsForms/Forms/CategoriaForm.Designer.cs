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
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorias.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome });
            resources.ApplyResources(dataGridViewCategorias, "dataGridViewCategorias");
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.ReadOnly = true;
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
            buttonEditar.Name = "buttonEditar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            resources.ApplyResources(buttonApagar, "buttonApagar");
            buttonApagar.Name = "buttonApagar";
            buttonApagar.UseVisualStyleBackColor = true;
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
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.UseVisualStyleBackColor = true;
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