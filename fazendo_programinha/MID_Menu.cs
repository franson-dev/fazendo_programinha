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
    public partial class MID_Menu : Form
    {
        public MID_Menu()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingForm = Application.OpenForms.OfType<form_calculos_botoes>().FirstOrDefault();
            if (existingForm == null)
            {
                form_calculos_botoes objCalcBot = new form_calculos_botoes
                {
                    MdiParent = this
                };
                objCalcBot.Show();
            }
            else
            {
                existingForm.Activate(); // Ativa o formulário existente
            }
        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingForm = Application.OpenForms.OfType<frmCalculoRadio>().FirstOrDefault();
            if (existingForm == null)
            {
                frmCalculoRadio objCalcBot = new frmCalculoRadio
                {
                    MdiParent = this
                };
                objCalcBot.Show();
            }
            else
            {
                existingForm.Activate(); // Ativa o formulário existente
            }

        }

        private void MID_Menu_Load(object sender, EventArgs e)
        {

        }

        private void superHiperMegaCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var existingForm = Application.OpenForms.OfType<super_calculadora>().FirstOrDefault();
            if (existingForm == null)
            {
                super_calculadora objCalcBot = new super_calculadora
                {
                    MdiParent = this
                };
                objCalcBot.Show();
            }
            else
            {
                existingForm.Activate(); // Ativa o formulário existente
            }
        }
    }
}
