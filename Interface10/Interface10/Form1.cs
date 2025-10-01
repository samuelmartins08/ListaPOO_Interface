using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double baseRet = double.Parse(txtBase.Text);
                double altura = double.Parse(txtAltura.Text);

                Terreno terreno = new Terreno(baseRet, altura);
                terreno.CalcularArea();

                double area = terreno.GetArea();
                lblResultado.Text = $"Área do terreno: {area} m²";

                if (area > 100)
                {
                    lblTipo.Text = "Terreno grande";
                }
                else
                {
                    lblTipo.Text = "Terreno pequeno";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
