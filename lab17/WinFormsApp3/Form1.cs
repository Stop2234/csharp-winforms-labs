using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Graphics gr;       //объ€вл€ем объект - графику, на которой будем рисовать
        Pen p;             //объ€вл€ем объект - карандаш, которым будем рисовать контур
        SolidBrush fon;    //объ€вл€ем объект - заливки, дл€ заливки соответственно фона
        SolidBrush fig;    //и внутренности рисуемой фигуры


        int rad;          // переменна€ дл€ хранени€ радиуса рисуемых кругов
        Random rand;      // объект, дл€ получени€ случайных чисел

        public Form1()
        {
            InitializeComponent();
        }

        //опишем функцию, котора€ будет рисовать круг по координатам его центра
        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(fig, xc, yc, rad, rad);

            gr.DrawEllipse(p, xc, yc, rad, rad);

        }

        // дл€ перехода к данной функции сделайте двойной щелчок по кнопке (Button)
        // добавленной на форму. —м. на фото, после кода
        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();  //инициализируем объект типа графики
                                                // прив€зав  к PictureBox

            p = new Pen(Color.Lime);           // задали цвет дл€ карандаша 
            fon = new SolidBrush(Color.Black); // и дл€ заливки
            fig = new SolidBrush(Color.Purple);

            rad = 40;                          //задали радиус дл€ круга
            rand = new Random();               //инициализируем объект дл€ рандомных числе

            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height); // закрасим черным 
                                                                                // нашу область рисовани€

            // вызываем написанную нами функцию, дл€ прорисовки круга
            // случайным образом выбрав перед этим координаты центра
            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

            timer1.Enabled = true;  //включим в работу наш таймер,
                                    // то есть теперь будет происходить событие Tick и его будет обрабатывать функци€ On_Tick (по умолчанию)

        }

        // дл€ получени€ данной функции перейдите к конструктору формы 
        // и сделайте двойной щелчок по таймеру, добавленному на форму. —м. на фото после кода
        private void timer1_Tick(object sender, EventArgs e)
        {

            //сначала будем очищать область рисовани€ цветом фона
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);


            // затем оп€ть случайным образом выбираем координаты центров кругов
            // и рисуем их при помощи описанной нами функции
            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

        }
    }
}