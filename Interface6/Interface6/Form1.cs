using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                double milhas = double.Parse(txtMilhas.Text);

                ConversorMilhas conversor = new ConversorMilhas(milhas);
                conversor.ConverterParaKm();

                lblResultado.Text = $"Resultado: {conversor.GetKm():F3} Km";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um número válido.");
            }
        }
    }
}
