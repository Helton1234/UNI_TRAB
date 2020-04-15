using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void índiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" O IMC (Índice de Massa Corporal) é uma ferramenta usada para detectar casos de obesidade ou desnutrição, " +
                "principalmente em estudos que envolvem grandes populações. De acordo com o endocrinologista Mario Kedhi Carra, " +
                "membro da Associação Brasileira para o Estudo da Obesidade e da Síndrome Metabólica (ABESO), essa é uma medida universal de classificação de obesidade, " +
                "validada pela Organização Mundial da Saúde. ", "Oque é IMC ?");
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para descobrir o seu IMC a calculadora divide o peso pela altura elevada ao quadrado. " +
                "Ou seja, de forma mais simples, você multiplica sua altura por ela mesma e depois divide seu peso pelo resultado da última conta.", "Como Funciona");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double varAlt, varPes, calculo;
            varAlt = Convert.ToDouble(txtAlt.Text);
            varPes = Convert.ToDouble(txtPes.Text);
            calculo = varPes / (varAlt*varAlt);

            MessageBox.Show("O seu IMC é " + calculo.ToString() , "Resultado");

        }

        private void txtAlt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
