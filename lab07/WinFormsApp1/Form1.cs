namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double[] A = new double[25];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                A[i] = rand.Next(-10, 10) + rand.NextDouble();
                listBox1.Items.Add("A[" + (i+1).ToString() + "]=" + A[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            int ki = 0;
            listBox2.Items.Clear();
            for (int i = 0; i < 25; i++)
            {
                if (A[i] < 0)
                    k++;
                if (A[i] >= 1 && A[i] <= 2)
                    ki++;
            }
            listBox2.Items.Add("Число отрицательных элементов=" + k.ToString());
            listBox2.Items.Add("Число элементов принадлежащих [1,2]=" + ki.ToString());
        }
    }
}