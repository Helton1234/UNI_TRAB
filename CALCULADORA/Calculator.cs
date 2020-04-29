using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        
        double acumula = 0;
        string operacao = "";

        private void button0_Click(object sender, EventArgs e)
        {
            telinha.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telinha.Text += 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            telinha.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            telinha.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            telinha.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            telinha.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            telinha.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            telinha.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            telinha.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            telinha.Text += 9;
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            telinha.Text += ",";
        }

        private void clearEX_Click(object sender, EventArgs e)
        {
            acumula = 0;
            telinha.Text = "";
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(telinha.Text);
                telinha.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(telinha.Text);
                telinha.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(telinha.Text);
                telinha.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(telinha.Text) != 0)
                {
                    acumula /= double.Parse(telinha.Text);
                    telinha.Text = acumula.ToString();
                }
                else
                {
                    telinha.Text = "Dividindo por zero";
                }
            }
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula = double.Parse(telinha.Text);
                telinha.Text = "+";
                operacao = "+";
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(telinha.Text);
                telinha.Text = "/";
                operacao = "/";
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(telinha.Text);
                telinha.Text = "*";
                operacao = "*";
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(telinha.Text);
                telinha.Text = "-";
                operacao = "-";
            }
        }

        private void MaisMenos_Click(object sender, EventArgs e)
        {
            double x = double.Parse(telinha.Text) * (-1);
            telinha.Text = x.ToString();
        }
    }
}