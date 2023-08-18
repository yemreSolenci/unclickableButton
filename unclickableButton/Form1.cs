namespace unclickableButton
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Size lastSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void unclickableButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Týkladýn");
        }

        private void unclickableButton_MouseEnter(object sender, EventArgs e)
        {
            unclickableButton.Location = randomPoint(unclickableButton);
        }

        private Point randomPoint(Button b)
        {
            int x, y;
            do
            {
                x = rnd.Next(Size.Width - b.Size.Width - 15);
                y = rnd.Next(Size.Height - b.Size.Height - 38);
                System.Diagnostics.Debug.Write("Try ");
            } while (b.Location.X - b.Size.Width < x && x < b.Location.X + b.Size.Width && b.Location.Y - b.Size.Height < y && y < b.Location.Y + b.Size.Height);
            System.Diagnostics.Debug.WriteLine("");
            return new Point(x, y);
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            lastSize = Size;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (Size.Width < lastSize.Width || Size.Height < lastSize.Height)
                unclickableButton.Location = randomPoint(unclickableButton);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                unclickableButton.Location = randomPoint(unclickableButton);
        }
    }
}