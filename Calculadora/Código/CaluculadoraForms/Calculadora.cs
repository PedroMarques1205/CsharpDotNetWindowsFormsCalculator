using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaluculadoraForms
{

    public partial class Calculadora : Form
    {
        int contador = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador <=1)
            {
                btnResultado.PerformClick();
                textResult.Text = textResult.Text+"%";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text+"9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador <=1)
            {
                btnResultado.PerformClick();
                textResult.Text += "÷";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador <=1)
            {
                btnResultado.PerformClick();
                textResult.Text = textResult.Text+"x";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador <=1)
            {
                btnResultado.PerformClick();
                textResult.Text = textResult.Text+"+";
            }
            
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            textResult.Text += ",";
        }
        private void btnSubtra_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador <=1)
            {
                btnResultado.PerformClick();
                textResult.Text += "-";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            char[] regras = new char[] { '+', '-', 'x', '÷', '%' };

            string aux = textResult.Text;

            string[] operacao = textResult.Text.Split(regras);


            foreach (char item in aux)
            {
                if (item=='+')
                {
                    textResult.Text = Convert.ToString(Decimal.Parse(operacao[0]) + Decimal.Parse(operacao[1]));
                }
                else if (item=='-')
                {
                    textResult.Text = Convert.ToString(Decimal.Parse(operacao[0]) - Decimal.Parse(operacao[1]));
                }
                else if (item=='x')
                {
                    textResult.Text = Convert.ToString(Decimal.Parse(operacao[0]) * Decimal.Parse(operacao[1]));
                }
                else if (item=='÷')
                {
                    textResult.Text = Convert.ToString(Decimal.Parse(operacao[0]) / Decimal.Parse(operacao[1]));
                }
                else if (item=='%')
                {
                    textResult.Text = Convert.ToString(Decimal.Parse(operacao[0]) * Decimal.Parse(operacao[1])/100);
                }
            }
            contador=0;

        }

    }
}
