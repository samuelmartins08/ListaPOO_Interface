using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(txtValor1.Text);
                double v2 = double.Parse(txtValor2.Text);

                if (v1 == v2)
                {
                    MessageBox.Show("Os valores devem ser distintos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Comparador comparador = new Comparador(v1, v2);
                comparador.DeterminarMaior();

                lblResultado.Text = $"O maior valor é: {comparador.GetMaior()}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
