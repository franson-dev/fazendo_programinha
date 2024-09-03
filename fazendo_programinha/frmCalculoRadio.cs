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
    public partial class frmCalculoRadio : Form
    {
        public frmCalculoRadio()
        {
            InitializeComponent();
        }

        private void frmCalculoRadio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbSomar_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void rbPotenciacao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPrimeiroValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbDividir_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tbSegundoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bIfElseIf_Click(object sender, EventArgs e)
        {
            double a, b, r;

            if (!double.TryParse(tbPrimeiroValor.Text, out a) || !double.TryParse(tbSegundoValor.Text, out b))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
                return;
            }

            if (rbSomar.Checked)
            {
                lbSigla.Text = "+";
                r = a + b;
            }
            else if (rbSubtrair.Checked)
            {
                lbSigla.Text = "-";
                r = a - b;
            }
            else if (rbMultiplicar.Checked)
            {
                lbSigla.Text = "*";
                r = a * b;
            }
            else if (rbDividir.Checked)
            {
                lbSigla.Text = "/";
                if (b == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                    lbResultado.Text = "?";
                    return;
                }
                r = a / b;
            }
            else if (rbPotenciacao.Checked)
            {
                lbSigla.Text = "^";
                r = Math.Pow(a, b);
            }
            else
            {
                MessageBox.Show("Selecione uma operação.");
                return;
            }

            lbResultado.Text = r.ToString();
            MessageBox.Show($"Resultado do cálculo: {lbResultado.Text}");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tbPrimeiroValor.Clear();
            lbSigla.Text = "?";
            tbSegundoValor.Clear();
            lbResultado.Text = "?";
            tbPrimeiroValor.Focus();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double a, b, r;

            // Tenta converter os valores dos TextBox para double
            if (!double.TryParse(tbPrimeiroValor.Text, out a) || !double.TryParse(tbSegundoValor.Text, out b))
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos.");
                return;
            }

            // Usa o switch para determinar a operação com base no RadioButton selecionado
            if (rbSomar.Checked || rbSubtrair.Checked || rbMultiplicar.Checked || rbDividir.Checked || rbPotenciacao.Checked)
            {
                switch (true) // O switch está usando true como condição padrão
                {
                    case bool _ when rbSomar.Checked:
                        lbSigla.Text = "+";
                        r = a + b;
                        break;
                    case bool _ when rbSubtrair.Checked:
                        lbSigla.Text = "-";
                        r = a - b;
                        break;
                    case bool _ when rbMultiplicar.Checked:
                        lbSigla.Text = "*";
                        r = a * b;
                        break;
                    case bool _ when rbDividir.Checked:
                        lbSigla.Text = "/";
                        if (b == 0)
                        {
                            MessageBox.Show("Não é possível dividir por zero.");
                            lbResultado.Text = "?";
                            return;
                        }
                        r = a / b;
                        break;
                    case bool _ when rbPotenciacao.Checked:
                        lbSigla.Text = "^";
                        r = Math.Pow(a, b);
                        break;
                    default:
                        MessageBox.Show("Selecione uma operação.");
                        return;
                }

                lbResultado.Text = r.ToString();
                MessageBox.Show($"Resultado do cálculo: {lbResultado.Text}");
            }
            else
            {
                MessageBox.Show("Selecione uma operação.");
            }
        }

    }
}
