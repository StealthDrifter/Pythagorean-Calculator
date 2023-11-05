namespace WinFormsApp1
{
    public partial class TriangleUI : Form
    {
        public TriangleUI()
        {
            InitializeComponent();
        }
        private int tileHeight = 0;
        private int tileWidth = 0;
        private int tileLength = 0;
        private void TileLength_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TileLength.Text, out tileLength))
            {
                UpdateOutput();
            }
            else { tileLength = 0; }

        }

        private void TileLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TileHeight_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TileHeight.Text, out tileHeight))
            {
                UpdateOutput();
            }
            else { tileHeight = 0; }
        }

        private void TileHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TileWidth_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TileWidth.Text, out tileWidth))
            {
                UpdateOutput();
            }
            else { tileWidth = 0; }

        }

        private void TileWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UpdateOutput()
        {
            Program.numberB = tileWidth * tileLength;
            Program.numberA = tileHeight * tileLength;
            NumberC.Text = Program.Pythagorean().ToString();
        }
    }
}