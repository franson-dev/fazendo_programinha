using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazendo_programinha
{
    public partial class super_calculadora : Form
    {
        public super_calculadora()
        {
            InitializeComponent();
        }
        //Variáveis globais
        decimal vNumAnt;
        string vOperacao;
        bool vLimpa = false;


        private void numbers(object sender, EventArgs e)
        {
            string sNumero = ((Button)sender).Text;
            if (lb_view.Text == "0") lb_view.Text = "";
            if(vLimpa)
            {
                lb_view.Text = "";
                vLimpa = false;
            }
            if (sNumero != "," || (sNumero == "," && !lb_view.Text.Contains(",")))
            {
                lb_view.Text += sNumero;
            }
            lb_view.Focus();
        }

        private void operations(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lb_view.Text);
            vOperacao = ((Button)sender).Text;
            vLimpa = true;
            lbHistoric.Text += vNumAnt + " " + vOperacao;
            lb_view.Focus();
        }

        private void gb_numbers_Enter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void b_equal_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lb_view.Text);

            switch (vOperacao)
            {
                case "+":
                    {
                        lb_view.Text = (vNumAnt + vNumAtual).ToString();
                        lbHistoric.Text += vNumAtual + " = ";
                        break;
                    }
                case "-":
                    {
                        lb_view.Text = (vNumAnt - vNumAtual).ToString();
                        lbHistoric.Text += vNumAtual + " = ";
                        break;
                    }
                case "*":
                    {
                        lb_view.Text = (vNumAnt * vNumAtual).ToString();
                        lbHistoric.Text += vNumAtual + " = ";
                        break;
                    }
                case "/":
                    {
                        lb_view.Text = (vNumAnt / vNumAtual).ToString();
                        lbHistoric.Text += vNumAtual + " = ";
                        break;
                    }
                case "PageUp":
                    {
                        lb_view.Text = Math.Pow((double)vNumAnt, (double)vNumAtual).ToString();
                        lbHistoric.Text += vNumAtual + " = ";
                        break;
                    }


                default:
                    break;
            }
            vLimpa = true;
            lb_view.Focus();
        }

        private void super_calculadora_Load(object sender, EventArgs e)
        {

        }

        private void lbHistoric_Click(object sender, EventArgs e)
        {

        }

        private void super_calculadora_KeyUp(object sender, KeyEventArgs e)
        {
            string tecla = e.KeyCode.ToString();

            foreach (Button btn in gb_numbers.Controls)
            {
                if ((btn is Button) && tecla.Length == 7)
                {
                    if (btn.Text == tecla.Substring(6, 1))
                    {
                        btn.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private void b_backspace_Click(object sender, EventArgs e)
        {
            lb_view.Text = lb_view.Text.Substring(0, lb_view.Text.Length - 1);
            if (lb_view.Text == "")
            {
                lb_view.Text = "0";
            }
        }
        private void b_ce_Click(object sender, EventArgs e)
        {
            lb_view.Text = "0";
        }

        private void b_c_Click(object sender, EventArgs e)
        {
            lb_view.Text = "0";
            lbHistoric.Text = "";
        }

        private void b_more_and_less_Click(object sender, EventArgs e)
        {
            lb_view.Text = (double.Parse(lb_view.Text) * -1).ToString();

        }
    }
}

