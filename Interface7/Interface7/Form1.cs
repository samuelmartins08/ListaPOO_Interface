using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface7
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
                double cotacao = double.Parse(txtCotacao.Text);
                double quantidade = double.Parse(txtQuantidade.Text);

                ConversorDolar conversor = new ConversorDolar(cotacao, quantidade);
                conversor.CalcularReais();

                lblResultado.Text = $"Valor em reais: R$ {conversor.GetValorReais():F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos.");
            }
        }
    }
}
