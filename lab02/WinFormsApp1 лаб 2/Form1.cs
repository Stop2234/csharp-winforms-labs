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
            textBox1.Text = "-0,02235";
            textBox2.Text = "2,23";
            textBox3.Text = "15,221";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            double h = (Math.Pow(Math.E, x - y) * Math.Pow(Math.Abs(x - y), x + y)) / (Math.Atan(x) + Math.Atan(z)) + Math.Pow(Math.Pow(x, 6) + Math.Log(y), 1.0 / 3.0);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            textBox4.Text += Environment.NewLine + "Результат f=" + h.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}