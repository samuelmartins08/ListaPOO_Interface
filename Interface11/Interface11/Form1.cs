using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = double.Parse(txtPeso.Text);
                double altura = double.Parse(txtAltura.Text);

                Pessoa pessoa = new Pessoa(peso, altura);
                pessoa.CalcularRelacao();

                double imc = pessoa.GetRelacao();
                string classificacao = pessoa.ClassificarPeso();

                lblResultado.Text = $"IMC: {imc:F2}";
                lblClassificacao.Text = $"Classificação: {classificacao}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores válidos para peso e altura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
