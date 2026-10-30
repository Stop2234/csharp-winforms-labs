namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Pen pen = new Pen(Color.Blue, 2);
        public Graphics g;
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, 100, 100, 100, 100);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void ocr(int k, int x, int y, int z, int h)
        {
            
        }
        private bool flag = false;



        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (int.TryParse(text, out int number))
            {
                ocr(int.Parse(text), 100, 100, 100, 100);
            }
            else MessageBox.Show("Неверный ввод");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flag = false;
        }


        
    }
}