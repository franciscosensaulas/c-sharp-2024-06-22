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
            SuspendLayout();
            // 
            // buttonCalculadora
            // 
            buttonCalculadora.Location = new Point(11, 11);
            buttonCalculadora.Margin = new Padding(2);
            buttonCalculadora.Name = "buttonCalculadora";
            buttonCalculadora.Size = new Size(320, 67);
            buttonCalculadora.TabIndex = 0;
            buttonCalculadora.Text = "Calculadora";
            buttonCalculadora.UseVisualStyleBackColor = true;
            buttonCalculadora.Click += button1_Click;
            // 
            // buttonCategoria
            // 
            buttonCategoria.Location = new Point(11, 440);
            buttonCategoria.Name = "buttonCategoria";
            buttonCategoria.Size = new Size(170, 142);
            buttonCategoria.TabIndex = 1;
            buttonCategoria.Text = "Categoria";
            buttonCategoria.UseVisualStyleBackColor = true;
            buttonCategoria.Click += buttonCategoria_Click;
            // 
            // buttonProduto
            // 
            buttonProduto.Location = new Point(371, 480);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(94, 83);
            buttonProduto.TabIndex = 2;
            buttonProduto.Text = "Produto";
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.Location = new Point(257, 480);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(94, 83);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Cliente";
            buttonCliente.UseVisualStyleBackColor = true;
            buttonCliente.Click += buttonCliente_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 594);
            Controls.Add(buttonCliente);
            Controls.Add(buttonProduto);
            Controls.Add(buttonCategoria);
            Controls.Add(buttonCalculadora);
            Margin = new Padding(2);
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCalculadora;
        private Button buttonCategoria;
        private Button buttonProduto;
        private Button buttonCliente;
    }
}
