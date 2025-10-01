using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double b = double.Parse(txtBase.Text);
                double h = double.Parse(txtAltura.Text);

                Triangulo triangulo = new Triangulo(b, h);
                triangulo.CalcularArea();

                lblResultado.Text = "Área: " + triangulo.GetArea().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }
    }
}
