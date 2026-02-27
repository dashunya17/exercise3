using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1._1
{
    public partial class Form1 : Form
    {
            private ListBox listBox;
            private Label lblEven, lblOdd;
            private int[] array;

            public Form1()
            {
                this.Text = "Задача 3: Четные и нечетные";
                this.Size = new Size(400, 350);

                Button btnGen = new Button() { Text = "Сгенерировать", Location = new Point(20, 20), Size = new Size(150, 30) };
                btnGen.Click += BtnGen_Click;

                listBox = new ListBox() { Location = new Point(20, 60), Size = new Size(340, 150) };

                Button btnCount = new Button() { Text = "Подсчитать", Location = new Point(20, 220), Size = new Size(150, 30) };
                btnCount.Click += BtnCount_Click;

                lblEven = new Label() { Text = "Четных: ", Location = new Point(20, 260), Size = new Size(150, 20), ForeColor = Color.Green };
                lblOdd = new Label() { Text = "Нечетных: ", Location = new Point(20, 285), Size = new Size(150, 20), ForeColor = Color.Red };

                this.Controls.Add(btnGen);
                this.Controls.Add(listBox);
                this.Controls.Add(btnCount);
                this.Controls.Add(lblEven);
                this.Controls.Add(lblOdd);
            }

            private void BtnGen_Click(object sender, EventArgs e)
            {
                array = new int[15];
                Random rnd = new Random();
                listBox.Items.Clear();

                for (int i = 0; i < 15; i++)
                {
                    array[i] = rnd.Next(10, 51);
                    listBox.Items.Add($"a[{i}] = {array[i]}");
                }
            }

            private void BtnCount_Click(object sender, EventArgs e)
            {
                if (array == null) return;

                int even = 0, odd = 0;
                foreach (int num in array)
                {
                    if (num % 2 == 0) even++;
                    else odd++;
                }

                lblEven.Text = $"Четных: {even}";
                lblOdd.Text = $"Нечетных: {odd}";
            }
        }
    }