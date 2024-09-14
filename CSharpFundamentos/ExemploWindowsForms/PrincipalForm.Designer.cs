namespace ExemploWindowsForms
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCalculadora = new Button();
            buttonCategoria = new Button();
            buttonProduto = new Button();
            buttonCliente = new Button();
            buttonVendedores = new Button();
            SuspendLayout();
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCalculadora.Image = Properties.Resources.calculator_64;
            buttonCalculadora.Location = new Point(11, 11);
            buttonCalculadora.Margin = new Padding(2);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(370, 86);
            buttonCalculadora.TabIndex = 0;
            buttonCalculadora.Text = "Calculadora";
            buttonCalculadora.TextAlign = ContentAlignment.MiddleRight;
            buttonCalculadora.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCalculadora.UseVisualStyleBackColor = true;
            buttonCalculadora.Click += button1_Click;
            // 
            // buttonCategoria
            // 
            buttonCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCategoria.Image = Properties.Resources.categories_64;
            buttonCategoria.Location = new Point(12, 458);
            buttonCategoria.Name = "buttonCategoria";
            buttonCategoria.Padding = new Padding(0, 15, 0, 0);
            buttonCategoria.Size = new Size(120, 120);
            buttonCategoria.TabIndex = 1;
            buttonCategoria.Text = "Categoria";
            buttonCategoria.TextAlign = ContentAlignment.BottomCenter;
            buttonCategoria.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCategoria.UseVisualStyleBackColor = true;
            buttonCategoria.Click += buttonCategoria_Click;
            // 
            // buttonProduto
            // 
            buttonProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonProduto.Image = Properties.Resources.dairy_products_64;
            buttonProduto.Location = new Point(261, 458);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Padding = new Padding(0, 15, 0, 0);
            buttonProduto.Size = new Size(120, 120);
            buttonProduto.TabIndex = 2;
            buttonProduto.Text = "Produto";
            buttonProduto.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCliente.Image = Properties.Resources.people_64;
            buttonCliente.Location = new Point(135, 458);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Padding = new Padding(0, 15, 0, 0);
            buttonCliente.Size = new Size(120, 120);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Cliente";
            buttonCliente.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonCliente.UseVisualStyleBackColor = true;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // buttonVendedores
            // 
            buttonVendedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonVendedores.Image = Properties.Resources.dairy_products_64;
            buttonVendedores.Location = new Point(264, 332);
            buttonVendedores.Name = "buttonVendedores";
            buttonVendedores.Padding = new Padding(0, 15, 0, 0);
            buttonVendedores.Size = new Size(120, 120);
            buttonVendedores.TabIndex = 4;
            buttonVendedores.Text = "Vendedores";
            buttonVendedores.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonVendedores.UseVisualStyleBackColor = true;
            buttonVendedores.Click += buttonVendedores_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 590);
            Controls.Add(buttonVendedores);
            Controls.Add(buttonCliente);
            Controls.Add(buttonProduto);
            Controls.Add(buttonCategoria);
            Controls.Add(buttonCalculadora);
            Margin = new Padding(2);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCalculadora;
        private Button buttonCategoria;
        private Button buttonProduto;
        private Button buttonCliente;
        private Button buttonVendedores;
    }
}
