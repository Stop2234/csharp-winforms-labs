using System.Reflection.Metadata;

namespace Лаба_8
{
    public partial class Form1 : Form
    {
        int[] A = new int[100];
        int[] b=new int[100];
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
                A[i] = rand.Next(-100, 100);
            for (int i = 0; i < 100; i++)
            {
                textBox3.Text += " a[" + (i + 1).ToString() + "]=" + A[i].ToString();
                if ((i + 1) % 10 == 0)
                    textBox3.Text += Environment.NewLine;
            }
            Array.Copy(A, b, 100);
            int z = 0;
            BubbleSort(ref b, ref z);
            for (int i = 0; i < 100; i++)
            {
                textBox4.Text += " a[" + (i + 1).ToString() + "]=" + b[i].ToString();
                if ((i + 1) % 10 == 0)
                    textBox4.Text += Environment.NewLine;
            }
            textBox4.Text += Environment.NewLine + "Количество итераций=" + z.ToString();
            int[] c = new int[100];
            Array.Copy(A, c, 100);
            z = 0;
            QuickSort(ref c, 0, 99,ref z);
            for (int i = 0; i < 100; i++)
            {
                textBox5.Text += " a[" + (i + 1).ToString() + "]=" + c[i].ToString();
                if ((i + 1) % 10 == 0)
                    textBox5.Text += Environment.NewLine;

            }
            textBox5.Text += Environment.NewLine + "Количество итераций=" + z.ToString();
            int[] d = new int[100];
            Array.Copy(A, d, 100);
            int k = 0;
            SelectionSort(ref d, ref k);
            for (int i = 0; i < 100; i++)
            {
                textBox6.Text += " a[" + (i + 1).ToString() + "]=" + d[i].ToString();
                if ((i + 1) % 10 == 0)
                    textBox6.Text += Environment.NewLine;
            }
            textBox6.Text += Environment.NewLine + "Количество итераций=" + k.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int IndexOf(ref int[] Array, int Value, ref int k)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                k++;
                if (Array[i] == Value)
                    return i;
            }
            return -1;
        }
        void QuickSort(ref int[] Array, int Left, int Right,ref int k)
        {
            int i = Left; int j = Right;
            int x = Array[(Left + Right) / 2];
            do
            {
                while (Array[i] < x)
                    ++i;
                while (Array[j] > x)
                    --j;
                if (i <= j)
                {
                    k++;
                    int t = Array[i];
                    Array[i] = Array[j];
                    Array[j] = t;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (Left < j)
                QuickSort(ref Array, Left, j,ref k);
            if (i < Right)
                QuickSort(ref Array, i, Right,ref k);
        }
        void BubbleSort(ref int[] Array, ref int k)
        {
            for (int i = 0; i < Array.Length - 1; i++)
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        int t = Array[i];
                        Array[i] = Array[j]; Array[j] = t;
                        k++;
                    }
                }
        }
        void SelectionSort(ref int[] Array, ref int k)
        {
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                        min = j;
                    k++;
                }
                if (min != i)
                {
                    int t = Array[i];
                    Array[i] = Array[min];
                    Array[min] = t;
                    k++;
                }
            }
        }
        int IndexOf1(ref int[] Array, int Value, int Left, int Right, ref int k)
        {
            int x = (Left + Right) / 2;
            k++;
            if (Array[x] == Value) return x;
            if ((x == Left) || (x == Right))
                return -1;
            if (Array[x] < Value)
                return IndexOf1(ref Array, Value, x, Right, ref k);
            else
                return IndexOf1(ref Array, Value, Left, x, ref k);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int h = Convert.ToInt32(textBox2.Text);
            int z = 0;
            int k = IndexOf(ref A, h, ref z);
            textBox1.Text += "Обычный поиск" + Environment.NewLine;
            if (k == -1)
                textBox1.Text += "Заданый элемент не присутвует в данном массиве" + Environment.NewLine;
            else
                textBox1.Text += "Заданый элемент находится на " + (k + 1).ToString() + " месте" + Environment.NewLine + "Количесво итераций=" + z.ToString()+Environment.NewLine;
             k = IndexOf1(ref b, h, 1, 100, ref z);
            textBox1.Text += "Поиск в сортированом массиве" + Environment.NewLine;
            if (k == -1)
                textBox1.Text += "Заданый элемент не присутвует в данном массиве" + Environment.NewLine;
            else
                textBox1.Text += "Заданый элемент находится на " + (k + 1).ToString() + " месте" + Environment.NewLine + "Количесво итераций=" + z.ToString() + Environment.NewLine;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}