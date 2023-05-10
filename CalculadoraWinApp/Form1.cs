using System.Globalization;
using System.Runtime.Serialization;

namespace CalculadoraWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        decimal valor1 = 0, valor2 = 0;
        string operacao;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("0");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("1");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar("9");
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            adicionarNumeroAoClicar(".");

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
                txtOperacao.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
                txtOperacao.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
                txtOperacao.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
                txtOperacao.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "x";
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "SOMA":
                    txtOperacao.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "SUBTRACAO":
                    txtOperacao.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "DIVISAO":
                    txtOperacao.Text = Convert.ToString(valor1 / valor2);
                    break;
                case "MULTIPLICACAO":
                    txtOperacao.Text = Convert.ToString(valor1 * valor2);
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            lblOperacao.Text = "";
        }
        private void adicionarNumeroAoClicar(string number)
        {
            txtOperacao.Text += number;
        }
    }
}