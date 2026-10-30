namespace лаба_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Привет друг");
            listBox1.Items.Add("Нет tyt");
            listBox1.Items.Add("bez rys");
            listBox1.Items.Add("И то m net");
            listBox1.Items.Add("абвг");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count = 0;
            char[] rys = ['а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'];

            int i = 0;
            while (i < len)
            {
                if (rys.Any(item => item == str[i]))
                    count++;
                i++;
            }
            label1.Text = "Количество русских строчных букв=" + count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}