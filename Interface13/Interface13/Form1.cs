using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtLadoA.Text);
                double ladoB = double.Parse(txtLadoB.Text);
                double ladoC = double.Parse(txtLadoC.Text);

                TrianguloRetangulo triangulo = new TrianguloRetangulo(ladoA, ladoB, ladoC);

                if (!triangulo.FormaTriangulo())
                {
                    lblResultado.Text = "Os valores NÃO formam um triângulo.";
                   
                }
                else
                {
                    // Formam triângulo
                    if (triangulo.EhRetangulo())
                    {
                        lblResultado.Text = "Os valores formam um triângulo retângulo.";
                    }
                    else
                    {
                        lblResultado.Text = "Os valores formam um triângulo, mas NÃO é retângulo.";
                    }
                   
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
