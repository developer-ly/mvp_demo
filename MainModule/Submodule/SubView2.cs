using System.Drawing;
using System.Windows.Forms;

namespace DrawingTests.MainModule.Submodule
{
    public partial class SubView2 : UserControl
    {
        private Bitmap plot;
        private Brush brush;
        public SubView2()
        {
            InitializeComponent();
            plot = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush = new SolidBrush(Color.Tomato);
            Draw();
        }

        private void Draw()
        {
            if (plot == null || plot.Size != pictureBox1.Size)
                plot = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(plot))
            {
                int x = pictureBox1.Location.X + 20;
                int y = pictureBox1.Location.Y + 20;
                int w = pictureBox1.Size.Width - 40;
                int h = pictureBox1.Size.Height - 40;
                g.FillRectangle(brush, x, y, w, h);
            }
            pictureBox1.Image = plot;
        }
    }
}
