using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsForms.Forms
{
    public partial class CalculadoraForm : Form
    {
        private int Numero1 = 0;
        private string Operacao = "";

        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNumero1.Text = "";
            textBoxNumero2.Text = "";
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBoxNumero1.Text);
            int numero2 = Convert.ToInt32(textBoxNumero2.Text);

            int soma = numero1 + numero2;

            MessageBox.Show($"Soma: {soma}");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxValor.Text += "9";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToInt32(textBoxValor.Text);
            textBoxValor.Text = "";
            Operacao = "+";
        }
        
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToInt32(textBoxValor.Text);
            textBoxValor.Text = "";
            Operacao = "-";

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            int numero2 = Convert.ToInt32(textBoxValor.Text);
            if (Operacao == "+")
            {
                int soma = Numero1 + numero2;
                textBoxValor.Text = Convert.ToString(soma);
            }
            else
            {
                int subtracao = Numero1 - numero2;
                textBoxValor.Text = Convert.ToString(subtracao);
            }
        }
    }
}
