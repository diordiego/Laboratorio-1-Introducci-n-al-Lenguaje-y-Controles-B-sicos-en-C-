using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuentos_Elaborado_por_Diego_Sanjur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorVentas.Text, out decimal valorVentas))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                txtValorVentas.Focus();
                return;
            }

            if (valorVentas < 0)
            {
                MessageBox.Show("El valor de la venta no puede ser negativo");
                txtValorVentas.Focus();
                return;
            }

            decimal descuentoPorcentaje;

            if (valorVentas >= 500)
                descuentoPorcentaje = 0.30m;
            else if (valorVentas >= 300)
                descuentoPorcentaje = 0.20m;
            else if (valorVentas >= 100)
                descuentoPorcentaje = 0.10m;
            else
                descuentoPorcentaje = 0m;

            decimal descuentoVentas = valorVentas * descuentoPorcentaje;
            decimal ventasTotales = valorVentas - descuentoVentas;

            txtDescuentoPorc.Text = descuentoPorcentaje.ToString("P0");
            txtDescuentoDin.Text = descuentoVentas.ToString("C2");
            txtVentaFinal.Text = ventasTotales.ToString("C2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorVentas.Text = "";
            txtDescuentoDin.Text = "";
            txtDescuentoPorc.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrará esta aplicación");
            this.Close();
        }
    }
}
