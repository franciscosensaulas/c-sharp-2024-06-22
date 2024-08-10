namespace ExemploWindowsForms.Forms
{
    partial class CalculadoraForm
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
            textBoxNumero1 = new TextBox();
            labelNumero1 = new Label();
            labelNumero2 = new Label();
            textBoxNumero2 = new TextBox();
            buttonSomar = new Button();
            buttonLimpar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonSoma = new Button();
            buttonSubtracao = new Button();
            buttonIgual = new Button();
            textBoxValor = new TextBox();
            SuspendLayout();
            // 
            // textBoxNumero1
            // 
            textBoxNumero1.Location = new Point(24, 46);
            textBoxNumero1.Name = "textBoxNumero1";
            textBoxNumero1.Size = new Size(284, 31);
            textBoxNumero1.TabIndex = 0;
            // 
            // labelNumero1
            // 
            labelNumero1.AutoSize = true;
            labelNumero1.Location = new Point(24, 9);
            labelNumero1.Name = "labelNumero1";
            labelNumero1.Size = new Size(92, 25);
            labelNumero1.TabIndex = 1;
            labelNumero1.Text = "Número 1";
            // 
            // labelNumero2
            // 
            labelNumero2.AutoSize = true;
            labelNumero2.Location = new Point(32, 89);
            labelNumero2.Name = "labelNumero2";
            labelNumero2.Size = new Size(92, 25);
            labelNumero2.TabIndex = 2;
            labelNumero2.Text = "Número 2";
            // 
            // textBoxNumero2
            // 
            textBoxNumero2.Location = new Point(24, 117);
            textBoxNumero2.Name = "textBoxNumero2";
            textBoxNumero2.Size = new Size(284, 31);
            textBoxNumero2.TabIndex = 3;
            // 
            // buttonSomar
            // 
            buttonSomar.Location = new Point(196, 166);
            buttonSomar.Name = "buttonSomar";
            buttonSomar.Size = new Size(112, 34);
            buttonSomar.TabIndex = 4;
            buttonSomar.Text = "Somar";
            buttonSomar.UseVisualStyleBackColor = true;
            buttonSomar.Click += buttonSomar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(78, 166);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(112, 34);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(552, 301);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(659, 301);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(765, 301);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(552, 195);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 9;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(659, 195);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 10;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(765, 195);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 11;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(552, 87);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(659, 89);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 13;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(765, 89);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 14;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(552, 412);
            button0.Name = "button0";
            button0.Size = new Size(303, 90);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonSoma
            // 
            buttonSoma.Location = new Point(873, 87);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(90, 90);
            buttonSoma.TabIndex = 16;
            buttonSoma.Text = "+";
            buttonSoma.UseVisualStyleBackColor = true;
            buttonSoma.Click += buttonSoma_Click;
            // 
            // buttonSubtracao
            // 
            buttonSubtracao.Location = new Point(873, 195);
            buttonSubtracao.Name = "buttonSubtracao";
            buttonSubtracao.Size = new Size(90, 90);
            buttonSubtracao.TabIndex = 17;
            buttonSubtracao.Text = "-";
            buttonSubtracao.UseVisualStyleBackColor = true;
            buttonSubtracao.Click += buttonSubtracao_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(873, 301);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(90, 201);
            buttonIgual.TabIndex = 18;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // textBoxValor
            // 
            textBoxValor.BackColor = SystemColors.Window;
            textBoxValor.Font = new Font("Segoe UI", 20F);
            textBoxValor.Location = new Point(552, 9);
            textBoxValor.Multiline = true;
            textBoxValor.Name = "textBoxValor";
            textBoxValor.ReadOnly = true;
            textBoxValor.RightToLeft = RightToLeft.Yes;
            textBoxValor.Size = new Size(411, 60);
            textBoxValor.TabIndex = 19;
            // 
            // CalculadoraForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 696);
            Controls.Add(textBoxValor);
            Controls.Add(buttonIgual);
            Controls.Add(buttonSubtracao);
            Controls.Add(buttonSoma);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonSomar);
            Controls.Add(textBoxNumero2);
            Controls.Add(labelNumero2);
            Controls.Add(labelNumero1);
            Controls.Add(textBoxNumero1);
            Name = "CalculadoraForm";
            Text = "CalculadoraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumero1;
        private Label labelNumero1;
        private Label labelNumero2;
        private TextBox textBoxNumero2;
        private Button buttonSomar;
        private Button buttonLimpar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonSoma;
        private Button buttonSubtracao;
        private Button buttonIgual;
        private TextBox textBoxValor;
    }
}