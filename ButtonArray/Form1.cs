namespace ButtonArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int columns = 5;
            int rows = 5;

            int size = 100;
            int padding = 10;
            Point location = Point.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(size, size);
                    button.Location = location;
                    location.X += padding + size;
                    button.Text = $"{i * 5 + j + 1}";

                    Random random = new Random();
                    button.BackColor = Color.FromArgb(random.Next(Int32.MaxValue));

                    button.Click += button1_Click;
                    this.Controls.Add(button);
                }
                location.Y += padding + size;
                location.X -= (padding + size) * columns;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.Controls.Remove(button);
        }
    }
}