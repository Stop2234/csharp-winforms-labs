using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpiralCirclesApp
{
    public partial class Form1 : Form
    {
        private int numberOfCircles = 15; 

        public Form1()
        {
            InitializeComponent();
            this.Text = "Spiral Circles";
            this.panel1.Paint += new PaintEventHandler(this.Panel1_Paint);

            Button drawButton = new Button();
            drawButton.Text = "Draw Circles";
            drawButton.Dock = DockStyle.Top;
            drawButton.Click += new EventHandler(this.DrawButton_Click);
            this.Controls.Add(drawButton);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawCircles(g, numberOfCircles, 0, 0, 1);
        }

        private void DrawCircles(Graphics g, int remainingCircles, double angle, double radius, int circleIndex)
        {
            if (remainingCircles == 0)
                return;

            int x = (int)(panel1.Width / 2 + radius * Math.Cos(angle));
            int y = (int)(panel1.Height /2 + radius * Math.Sin(-angle));

            int circleRadius = circleIndex * 3;
            g.DrawEllipse(Pens.Blue, x - circleRadius, y - circleRadius, circleRadius * 2, circleRadius * 2);

            DrawCircles(g, remainingCircles - 1, angle + Math.PI / 5, radius + circleRadius/2, circleIndex + 1);
        }
    }
}
