namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculadora padrao = new Calculadora();
        private void btncientifica_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        public void num2()
        {
            txbvisor.Text += "2";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txbvisor.Text += "9";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora";
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            padrao.Somar(Convert.ToDouble(txbvisor.Text));
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            padrao.Subtrair(Convert.ToDouble(txbvisor.Text));
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            padrao.Multiplicar(Convert.ToDouble(txbvisor.Text));
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            padrao.Dividir(Convert.ToDouble(txbvisor.Text));
        }

        private void btnigualdade_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txbvisor.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}

