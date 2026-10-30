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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double m = double.Parse(textBox2.Text);
            double z = 0, h = 0;
            if (radioButton1.Checked)
            {
                MessageBox.Show("Выбрана функция sh(x)");
                z = Math.Sinh(x);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Выбрана функция x^2");
                z = x * x;
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Выбрана функция e^x");
                z = Math.Pow(Math.E, x);
            }
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "M = " + m.ToString();
            if (m > -1 && x > m)
            {
                h = Math.Sin(5 * z + 3 * m * Math.Abs(z));
                textBox4.Text += Environment.NewLine + "Результат j=" + h.ToString();
            }
            else if (x > m)
            {
                h = Math.Cos(3 * z + 5 * m * Math.Abs(z));
                textBox4.Text += Environment.NewLine + "Результат j=" + h.ToString();
            }
            else if (x == m)
            {
                h = Math.Pow(z + m, 2);
                textBox4.Text += Environment.NewLine + "Результат j=" + h.ToString();
            }
            else
                textBox4.Text += Environment.NewLine + "Данные не удовлетворяют не одно из условий системы";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}