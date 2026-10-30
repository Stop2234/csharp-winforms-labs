namespace лаба4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0; int o1 = 0;
            Random rnd = new Random();
            while (k < 3)
            {
                k++;
                int h = rnd.Next(1, 7);
                switch (h)
                {
                    case 1:
                        Button b = new Button();
                        b.Location = new Point(1 + 10 * k, 1 * k * k);
                        b.Size = new Size(50, 50);
                        b.Text = "В панели я";
                        b.BackColor = Color.YellowGreen;
                        b.Parent = panel1;
                        textBox1.Text += Environment.NewLine + "Кординаты кнопки " + b.Location.X + " " + b.Location.Y;
                        break;
                    case 2:
                        Label z = new Label();
                        z.Location = new Point(70, 15 * k * k);
                        z.Size = new Size(120, 140);
                        z.Text = "Не везет сегодня";
                        z.ForeColor = Color.Black;
                        z.Parent = panel1;
                        textBox1.Text += Environment.NewLine + "Кординаты текста " + z.Location.X + " " + z.Location.Y;
                        break;

                    case 3:
                        TextBox c = new TextBox();
                        c.Parent = this;
                        c.Location = new Point(300, 10 * k);
                        c.Size = new Size(150, 50);
                        c.Text = "Я есть";
                        c.BackColor = Color.Purple;
                        textBox1.Text += Environment.NewLine + "Кординаты textbox " + c.Location.X + " " + c.Location.Y;
                        break;
                    case 4:
                        Button m = new Button();
                        m.Parent = this;
                        m.Location = new Point(45 * k, 10 * k * k);
                        m.Size = new Size(100, 100);
                        m.Text = "Привет";
                        m.BackColor = Color.Gray;
                        textBox1.Text += Environment.NewLine + "Кординаты кнопки " + m.Location.X + " " + m.Location.Y;
                        break;
                    case 5:
                        Label j = new Label();
                        j.Parent = this;
                        j.Location = new Point(200, 10 * k * k);
                        j.Size = new Size(100, 50);
                        j.Text = "Hello";
                        j.BackColor = Color.Green;
                        textBox1.Text += Environment.NewLine + "Кординаты текста " + j.Location.X + " " + j.Location.Y;
                        break;
                    case 6:
                        TextBox i = new TextBox();
                        i.Parent = panel1;
                        i.Multiline = true;
                        i.Location = new Point(100, 100 * k);
                        i.Size = new Size(100, 150);
                        i.Text = "Давно не \n виделись";
                        i.BackColor = Color.Yellow;
                        textBox1.Text += Environment.NewLine + "Кординаты text box " + i.Location.X + " " + i.Location.Y;
                        break;

                }

            }
            foreach (Control c in this.Controls)
                if (c is Button)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых кнопок в форме " + (o1).ToString();
            o1 = 0;
            foreach (Control c in panel1.Controls)
                if (c is Button)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых кнопок в панели " + o1.ToString();
            o1 = 0;
            foreach (Control c in panel1.Controls)
                if (c is Label)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых строк в панели " + o1.ToString();
            o1 = 0;
            foreach (Control c in this.Controls)
                if (c is Label)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых строк в форме " + o1.ToString();
            o1 = 0;
            foreach (Control c in this.Controls)
                if (c is TextBox)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых TextBox в форме " + o1.ToString();
            o1 = 0;
            foreach (Control c in panel1.Controls)
                if (c is Label)
                    o1++;
            textBox1.Text += Environment.NewLine + "Количесво сгенерированых TextBox в панели " + o1.ToString();




        }
    }
}