namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal resultado;
        public decimal valor;
        string operacaoselecionada;


        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn01.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Multiplicacao";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacaoselecionada = "Adicao";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operacaoselecionada)
            {

                case "Adicao":
                    {

                        resultado = valor + decimal.Parse(txtVisor.Text);
                        txtVisor.Text = resultado.ToString();

                        break;

                    }
                case "Subtracao":
                    {

                        resultado = valor - decimal.Parse(txtVisor.Text);
                        txtVisor.Text = resultado.ToString();

                        break;

                    }
                case "Divisao":
                    {

                        resultado = valor / decimal.Parse(txtVisor.Text);
                        txtVisor.Text = resultado.ToString();

                        break;

                    }
                case "Multiplicacao":
                    {

                        resultado = valor * decimal.Parse(txtVisor.Text);
                        txtVisor.Text = resultado.ToString();

                        break;

                    }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn03.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelInitial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn05_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn05.Text;
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn02.Text;
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn04.Text;
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn06.Text;
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn07.Text;
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn08.Text;
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn09.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtVisor.Text += btn00.Text;
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button23_Click(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            operacaoselecionada = "Subtracao";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "-";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            operacaoselecionada = "Divisao";
            valor += decimal.Parse(txtVisor.Text);
            txtVisor.Text = "";
            lblOperacao.Text = "/";
        }
    }
}