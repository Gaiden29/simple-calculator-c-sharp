using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoCalculadoraCheckBox
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            if (cbxOperador.SelectedIndex == 0)
                resultado = valor1 + valor2;
            else
                if (cbxOperador.SelectedIndex == 1)
                    resultado = valor1 - valor2;
                else
                    if (cbxOperador.SelectedIndex == 2)
                        resultado = valor1 * valor2;
                    else
                        if (cbxOperador.SelectedIndex == 3)
                            resultado = valor1 / valor2;

            lblResultado.Text = "Resultado: " + Convert.ToDouble(resultado);
        }

        

        
    }
}
