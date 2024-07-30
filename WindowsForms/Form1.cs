using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNumero1.Text);
            double n2 = double.Parse(txtNumero2.Text);

            Double Resultado = n1 + n2;

            LblResultado.Text = Resultado.ToString();


        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            //limpa as caixas
            txtNumero1.Clear();
            txtNumero2.Clear();

            //move o texto zero para o label 
            LblResultado.Text = "0";

            //
            txtNumero1.Focus();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
