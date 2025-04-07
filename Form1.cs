using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Calculadora padrao = new Calculadora();

        string primeiroNumero = "";
        string operacao = "";
        bool esperandoSegundoNumero = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Adiciona número ao visor
        private void AdicionarNumero(string numero)
        {
            if (esperandoSegundoNumero)
            {
                txbvisor.Clear();
                esperandoSegundoNumero = false;
            }

            txbvisor.Text += numero;
        }

        // Botões numéricos
        private void btn1_Click(object sender, EventArgs e) => AdicionarNumero("1");
        private void button9_Click(object sender, EventArgs e) => AdicionarNumero("2");
        private void button7_Click(object sender, EventArgs e) => AdicionarNumero("3");
        private void button5_Click(object sender, EventArgs e) => AdicionarNumero("4");
        private void button6_Click(object sender, EventArgs e) => AdicionarNumero("5");
        private void button4_Click(object sender, EventArgs e) => AdicionarNumero("6");
        private void button2_Click(object sender, EventArgs e) => AdicionarNumero("7");
        private void button1_Click(object sender, EventArgs e) => AdicionarNumero("8");
        private void button3_Click(object sender, EventArgs e) => AdicionarNumero("9");
        private void button12_Click(object sender, EventArgs e) => AdicionarNumero("0");

        // Botão de ponto decimal
        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (!txbvisor.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(txbvisor.Text))
                    txbvisor.Text = "0,";
                else
                    txbvisor.Text += ",";
            }
        }

        // Define operação
        private void DefinirOperacao(string nomeOperacao, string simbolo)
        {
            if (!string.IsNullOrWhiteSpace(txbvisor.Text))
            {
                primeiroNumero = txbvisor.Text;
                operacao = nomeOperacao;
                lblOperacao.Text = $"{primeiroNumero} {simbolo}";
                esperandoSegundoNumero = true;
            }
        }

        private void btnsomar_Click(object sender, EventArgs e) => DefinirOperacao("somar", "+");
        private void btnsubtrair_Click(object sender, EventArgs e) => DefinirOperacao("subtrair", "−");
        private void button14_Click(object sender, EventArgs e) => DefinirOperacao("multiplicar", "×");
        private void btndividir_Click(object sender, EventArgs e) => DefinirOperacao("dividir", "÷");

        // Botão igual
        private void btnigual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbvisor.Text))
            {
                if (string.IsNullOrEmpty(operacao))
                {
                    MessageBox.Show("Selecione uma operação primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    string segundoNumero = txbvisor.Text;

                    if (operacao == "dividir" && segundoNumero == "0")
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    padrao.Operar(primeiroNumero, segundoNumero, operacao);

                    txbvisor.Text = padrao.Resultado;
                    lblOperacao.Text = "";
                    esperandoSegundoNumero = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnlimpar_Click(sender, e);
                }
            }
        }

        // Limpa tudo
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txbvisor.Clear();
            lblOperacao.Text = "";
            primeiroNumero = "";
            operacao = "";
            esperandoSegundoNumero = false;
        }

        // Limpa apenas o visor
        private void btnC_Click(object sender, EventArgs e)
        {
            txbvisor.Clear();
            lblOperacao.Text = "";
        }
    }
}
