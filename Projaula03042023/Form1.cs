using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projaula03042023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtValorA.Text);
            double b = double.Parse(txtValorB.Text);
            double c = double.Parse(txtValorC.Text);
            // Δ = b2 – 4ac

            //x’ = (–b – raizq(Δ)) / (2 * a)
            //x” = (–b + raizq(Δ)) / (2 * a)

            double delta = ((b * b) - 4 * (a * c));
            double x1 = (-b - Math.Sqrt(delta) / (2 * a));
            double x2 = (-b + Math.Sqrt(delta) / (2 * a));

            MessageBox.Show("Valor de Delta é: " + delta);
            MessageBox.Show("Valor do X1 é: "+ x1);
            MessageBox.Show("Valor do X2 é: " + x2);
        }
    }
}
