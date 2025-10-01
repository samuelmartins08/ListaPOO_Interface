using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface12
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

                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                if (triangulo.FormaTriangulo())
                {
                    lblResultado.Text = "Forma um triângulo.";
                    lblClassificacao.Text = "Classificação: " + triangulo.Classificar();
                }
                else
                {
                    lblResultado.Text = "NÃO forma um triângulo.";
                    lblClassificacao.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
