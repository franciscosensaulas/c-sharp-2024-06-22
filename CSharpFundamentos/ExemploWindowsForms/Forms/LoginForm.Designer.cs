namespace ExemploWindowsForms.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            labelSenha = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(12, 72);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 20);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(12, 32);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(299, 27);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(12, 95);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(299, 27);
            textBoxSenha.TabIndex = 3;
            textBoxSenha.UseSystemPasswordChar = true;
            textBoxSenha.KeyDown += textBoxSenha_KeyDown;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(217, 138);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(94, 29);
            buttonEntrar.TabIndex = 4;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 191);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelSenha);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelSenha;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonEntrar;
    }
}