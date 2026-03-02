using System.Windows.Forms;

namespace Forms3
{
    public partial class Form1 : Form
    {
        private int[] numbers;

        public Form1()
        {
            InitializeComponent();
        }

        private void rand (object sender, EventArgs e)
        {
            numbers = new int[15];
            listBox.Items.Clear();
            Random rand = new Random();

            for (int i = 0; i < 15; i++)
            {
                numbers[i] = rand.Next(10, 51);
                listBox.Items.Add($"a[{i}] = {numbers[i]}");
            }
        }

        private void Click(object sender, EventArgs e)
        {
            if (numbers == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            int even = 0;
            int odd = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }

            lblEven.Text = $"Четных: {even}";
            lblOdd.Text = $"Нечетных: {odd}";
        }
    }
}