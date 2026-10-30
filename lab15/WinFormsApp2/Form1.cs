using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private int numCircles = 10; // »змените это значение по своему усмотрению

        public MainForm()
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // ќсвобождение управл€емых ресурсов
            }
            base.Dispose(disposing);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawSpiralCircles(e.Graphics, ClientSize.Width / 2, ClientSize.Height / 2, 10, 30);
        }

        private void DrawSpiralCircles(Graphics g, int centerX, int centerY, int radius, int increment)
        {
            if (numCircles <= 0)
                return;

            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            numCircles--;

            // ¬ычисл€ем новые координаты центра дл€ следующей окружности
            double angle = numCircles * Math.PI / 180.0;
            int newX = centerX + (int)(increment * Math.Cos(angle));
            int newY = centerY + (int)(increment * Math.Sin(angle));

            DrawSpiralCircles(g, newX, newY, radius + increment, increment);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
