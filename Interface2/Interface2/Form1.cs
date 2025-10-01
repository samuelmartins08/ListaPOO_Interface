using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
             private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double aresta = double.Parse(txtAresta.Text);

                Quadrado q = new Quadrado(aresta);
                q.CalcularArea();

                lblResultado.Text = "Área: " + q.GetArea().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
