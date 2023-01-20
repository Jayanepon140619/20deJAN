using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "7";
        }

        private void button2Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "1";
        }

        private void button3Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "3";
        }

        private void button26Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "9";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + "0";
        }

        private void botaox_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "mult";
            labelOperacao.Text = "X";
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaosoma_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(resultado.Text,CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "soma";
            labelOperacao.Text = "+";





        }

        private void BOTAOCE_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void botaomenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "menos";
            labelOperacao.Text = "-";
        }

        private void botaobarra_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "div";
            labelOperacao.Text = "/";
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        
        
        }

        private void botaoresultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "soma")

            {
                resultado.Text = Convert.ToString(valor1 + valor2);
            }
            if (operacao == "menos")

            {
                resultado.Text = Convert.ToString(valor1 - valor2);
            }
            if (operacao == "div")

            {
                resultado.Text = Convert.ToString(valor1 / valor2);
            }
            if (operacao == "mult")

            {
                resultado.Text = Convert.ToString(valor1 * valor2);
            }







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}








