using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles_Elaborado_por_Diego_Sanjur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio",
                       "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            string mes = txtMes.Text.Trim().ToLower();
            int indiceMes = Array.IndexOf(meses, mes);

            if (indiceMes == -1)
            {
                MessageBox.Show("Ingrese un mes válido");
                txtMes.Focus();
                return;
            }

            int numeroMes = indiceMes + 1;

            if (!int.TryParse(txtDia.Text.Trim(), out int dia))
            {
                MessageBox.Show("Ingrese un número válido para el día");
                txtDia.Focus();
                return;
            }

            if (dia < 1 || dia > 31)
            {
                MessageBox.Show("El día debe estar entre 1 y 31");
                txtDia.Focus();
                return;
            }

            int anio = DateTime.Now.Year;
            int diasDelMes = DateTime.DaysInMonth(anio, numeroMes);

            if (dia > diasDelMes)
            {
                MessageBox.Show($"{txtMes.Text.Trim()} de {anio} tiene {diasDelMes} días");
                txtDia.Focus();
                return;
            }

            string mesCapitalizado = char.ToUpper(mes[0]) + mes.Substring(1);
            lblFecha.Text = $"La fecha es: {dia} de {mesCapitalizado} de {anio}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDia.Text = "";
            txtMes.Text = "";
            txtAnio.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando programa");
            this.Close();
        }
    }
}
