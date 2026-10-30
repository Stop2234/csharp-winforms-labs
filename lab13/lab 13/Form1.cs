namespace lab_13
{
    public partial class Form1 : Form
    {
        public double calk(double x, double y, double z)
        { return x * x * y * y * y * Math.Sqrt(z); }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, e1, f,z1,z2;
            a = double.Parse(textBox1.Text);
            b= double.Parse(textBox2.Text);
            c = double.Parse(textBox6.Text);
            d = double.Parse(textBox3.Text);
            e1 = double.Parse(textBox7.Text);
            f=double.Parse(textBox5.Text);
            textBox4.Text = null;
            if (c < 0 || f < 0)
                textBox4.Text = "Параметры не соответсвуют примеру sqrt()>0";
            else
            {
                z1 = calk(a, b, c);
                z2 = calk(d, e1, f);
                textBox4.Text += "Выражения с числами a,b,c=" + z1.ToString()+Environment.NewLine;
               
                textBox4.Text += "Выражения с числами d,e,f=" + z2.ToString() + Environment.NewLine;
                if (z1 > z2)
                    textBox4.Text += "Больше с числами a,b,c";
                else
                    textBox4.Text += "Больше с числами d,e,f";
            }   
        }
    }
}