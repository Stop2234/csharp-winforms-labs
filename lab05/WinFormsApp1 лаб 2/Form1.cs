using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1_лаб_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Работу выполнил Двойцов Егор 23ПИ1" + Environment.NewLine;
            if ((x > xk && dx > 0) || (x < xk && dx < 0) || dx == 0)
                textBox4.Text += Environment.NewLine + "Некоректные данные , будет зацикливание";
            else
                if (x > xk)
                for (; x >= xk; x += dx)
                {
                    double y = 9 * Math.Pow(x, 4) + Math.Sin(57.2 + x);
                    textBox4.Text += Environment.NewLine + "x= " + x.ToString() + " y=" + y.ToString();
                }
            else
                for (; x <= xk; x += dx)
                {
                    double y = 9 * Math.Pow(x, 4) + Math.Sin(57.2 + x);
                    textBox4.Text += Environment.NewLine + "x= " + x.ToString() + " y=" + y.ToString();
                }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}