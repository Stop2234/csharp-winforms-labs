namespace WinFormsApp1_лаб
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            label1.Text = "Начало работы";
        }
    }
}