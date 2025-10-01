using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface3
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
                double diagonal = double.Parse(txtDiagonal.Text);

                Quadrado quadrado = new Quadrado(diagonal);
                quadrado.CalcularArea();

                lblResultado.Text = "Área: " + quadrado.GetArea().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
