using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1 = 1, y1 = 1, x2 = 70, y2 = 70, f = 0;
        private Pen pen = new Pen(Color.DarkRed, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, x1, y1, x2, y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f == 0)
            {
                if (x1 + 70 < ClientSize.Width)
                    x1 += 10;
                else
                {
                    x1 = ClientSize.Width - 72;
                    f = 1;
                }
            }
            if (f == 1)
            {
                if (y1 + 70 < ClientSize.Height)
                    y1 += 10;
                else
                {
                    y1 = ClientSize.Height - 72;
                    f = 2;
                }
            }
            if (f == 2)
            {
                if (x1 > 1)
                    x1 -= 10;
                else
                {
                    f = 3;
                }
            }
            if (f == 3)
            {
                if (y1 > 1)
                    y1 -= 10;
                else
                {
                    f = 0;
                }
            }

            Invalidate();

        }
    }
}