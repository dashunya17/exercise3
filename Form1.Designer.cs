namespace Forms3
{
    partial class Form1
    {
        private ListBox listBox;
        private Label lblEven;
        private Label lblOdd;
        private Button btnGen;
        private Button btnCount;

        private void InitializeComponent()
        {
            this.btnGen = new Button();
            this.listBox = new ListBox();
            this.btnCount = new Button();
            this.lblEven = new Label();
            this.lblOdd = new Label();

            this.btnGen.Text = "Сгенерировать";
            this.btnGen.Location = new System.Drawing.Point(20, 20);
            this.btnGen.Size = new System.Drawing.Size(150, 30);
            this.btnGen.Click += new EventHandler(this.rand);

            this.listBox.Location = new System.Drawing.Point(20, 60);
            this.listBox.Size = new System.Drawing.Size(340, 150);

            this.btnCount.Text = "Подсчитать";
            this.btnCount.Location = new System.Drawing.Point(20, 220);
            this.btnCount.Size = new System.Drawing.Size(150, 30);
            this.btnCount.Click += new EventHandler(this.Click);

            this.lblEven.Text = "Четных: ";
            this.lblEven.Location = new System.Drawing.Point(20, 260);
            this.lblEven.Size = new System.Drawing.Size(150, 20);
            this.lblEven.ForeColor = System.Drawing.Color.Green;

            this.lblOdd.Text = "Нечетных: ";
            this.lblOdd.Location = new System.Drawing.Point(20, 285);
            this.lblOdd.Size = new System.Drawing.Size(150, 20);
            this.lblOdd.ForeColor = System.Drawing.Color.Red;

            this.Text = "Четные и нечетные";
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.lblEven);
            this.Controls.Add(this.lblOdd);
        }
    }

}
