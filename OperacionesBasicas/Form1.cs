using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesBasicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;

            num1 = Convert.ToInt16(txtnum1.Text);
            num2 = Convert.ToInt16(txtnum2.Text);

            suma = num1 + num2;

            MessageBox.Show("la suma es: " + suma, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int num1, num2, resta;

            num1 = Convert.ToInt16(txtnum1.Text);
            num2 = Convert.ToInt16(txtnum2.Text);

            resta = num1 - num2;

            MessageBox.Show("la resta es: " + resta, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num1, num2, mult;

            num1 = Convert.ToInt16(txtnum1.Text);
            num2 = Convert.ToInt16(txtnum2.Text);

            mult = num1 * num2;

            MessageBox.Show("la multiplicación es: " + mult, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int num1, num2, div;

            num1 = Convert.ToInt16(txtnum1.Text);
            num2 = Convert.ToInt16(txtnum2.Text);

            div = num1 / num2;

            MessageBox.Show("la división es: " + div, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
