using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract8_EstructuraIf_Programado_por_Diego_Sanjur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuma.Checked)
            {
                lblSimbolo.Text = "+";
            }
        }
        private void rbResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbResta.Checked)
            {
                lblSimbolo.Text = "-";
            }
        }
        private void rbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMultiplicacion.Checked)
            {
                lblSimbolo.Text = "*";
            }
        }
        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDivision.Checked)
            {
                lblSimbolo.Text = "/";
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorA.Text, out decimal valorA))
            {
                MessageBox.Show("Ingrese un valor numérico válido en el primer campo");
                txtValorA.Focus();
                return;
            }

            if (!decimal.TryParse(txtValorB.Text, out decimal valorB))
            {
                MessageBox.Show("Ingrese un valor numérico válido en el segundo campo");
                txtValorB.Focus();
                return;
            }

            decimal resultado;

            if (rbSuma.Checked)
                resultado = valorA + valorB;
            else if (rbResta.Checked)
                resultado = valorA - valorB;
            else if (rbMultiplicacion.Checked)
                resultado = valorA * valorB;
            else if (rbDivision.Checked)
            {
                if (valorB == 0)
                {
                    MessageBox.Show("Error. No es posible realizar una división entre 0");
                    txtValorB.Focus();
                    return;
                }
                resultado = valorA / valorB;
            }
            else
            {
                MessageBox.Show("Seleccione una operación");
                return;
            }

            txtResultado.Text = resultado.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorA.Text = "";
            txtValorB.Text = "";
            txtResultado.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicación");
            this.Close();
        }
    }
}
