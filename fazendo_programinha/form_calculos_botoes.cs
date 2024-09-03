using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazendo_programinha
{
    public partial class form_calculos_botoes : Form
    {
        public form_calculos_botoes()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "+";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = a + b;

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            lblSinal.Text = "?";
            textBox1.Clear();
            lblResultado.Text = "?";
            textBox2.Focus();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "-";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = a - b;

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "^";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = Math.Pow(a, b);

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {

        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "/";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = a / b;

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void form_calculos_botoes_Load(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void form_calculos_botoes_Load_1(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click_1(object sender, EventArgs e)
        {

        }

        private void divisao_Click_1(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "/";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = a / b;

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void multiplicacao_Click_1(object sender, EventArgs e)
        {
            double a, b, r;

            lblSinal.Text = "X";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                r = a * b;

                lblResultado.Text = r.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void form_calculos_botoes_Load_2(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, resPercentualA, resPercentualB;

            lblSinal.Text = " ";
            try
            {
                a = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);

                resPercentualA = a % 2;
                resPercentualB = b % 2;

                if (resPercentualA == 0 && resPercentualB == 0)
                {
                    lblResultado.Text = "AMBOS SÃO PARES";
                }
                else if (resPercentualA == 0 && resPercentualB == 1)
                {
                    lblResultado.Text = "O PRIMEIRO É PAR E O SEGUNDO ÍMPAR";
                }
                else if (resPercentualA == 1 && resPercentualB == 0)
                {
                    lblResultado.Text = "Primeiro valor é ímpar e o segundo é par" + a;
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Digita algum número PELO AMOR DE DEUS!!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSinal_Click_1(object sender, EventArgs e)
        {

        }
    }
}
