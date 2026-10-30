using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillPie(Brushes.Yellow,20, 20, 100, 100, 0, 360);
            double h;
            g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, 0,70);
            g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, 0, 50);
            g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, 0, 90);
            g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, 0, 30);
            g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, 0, 110);
            for (int i = 0; i < 180; i += 15)
            {
                h = (70 - Math.Sqrt(Math.Pow(70 - 1, 2) + Math.Pow(70 - 1, 2) - Math.Pow(70 - i, 2)));
                g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, i, (int)h);
            }
            for (int i = 0; i < 180; i += 15)
            {
                h = (70+Math.Sqrt(Math.Pow(70 - 1, 2) + Math.Pow(70 - 1, 2) - Math.Pow(70 - i, 2)));
                g.DrawLine(new Pen(Brushes.Yellow, 4), 70, 70, i, (int)h);
            }

            int z = -1;
            for (int i = 50; i < 700; i += 50,z*=-1)
            { g.DrawArc(new Pen(Brushes.Black, 4),150+i,230+z*i/2,50,50,170,170);
                g.DrawArc(new Pen(Brushes.Black, 4), 100+i, 230+z*i/2, 50, 50, 190, 170);
            }


        }
    }
}