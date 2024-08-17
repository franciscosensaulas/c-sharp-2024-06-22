namespace ExemploWindowsForms.Forms
{
    partial class CategoriaCadastroRapidoForm
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
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 9);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(497, 27);
            textBoxNome.TabIndex = 1;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Image = Properties.Resources.floppy_disk_32;
            buttonSalvar.Location = new Point(379, 65);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(130, 55);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Image = Properties.Resources.close_32;
            buttonCancelar.Location = new Point(243, 65);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(130, 55);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // CategoriaCadastroRapidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 133);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "CategoriaCadastroRapidoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema - Categoria Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}