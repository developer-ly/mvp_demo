using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingTests.MainModule.Submodule
{
    public interface ISubView
    {
        void StartSwitchingBackground();
        void StopSwitchingBackground();
    }

    public partial class SubView : UserControl, ISubView
    {
        private Bitmap plot;
        private Brush brush1;
        private Brush brush2;
        private int drawCount;

        private Timer timer;

        public SubView()
        {
            InitializeComponent();

            brush1 = new SolidBrush(Color.Yellow);
            brush2 = new SolidBrush(Color.Blue);
            
            timer = new Timer();
            timer.Tick += OnTick;
        }
        
        private void OnTick(object sender, EventArgs e)
        {
            SwitchBackground();
        }

        private void SwitchBackground()
        {

            if (InvokeRequired)
                Console.WriteLine("InvokeRequired");    // never happens, so i assume it is not considered a call from another thread...

            if (plot == null || plot.Size != pictureBox.Size)
                plot = new Bitmap((int)(pictureBox.Width*0.8), (int)(pictureBox.Height*0.8));

            using (Graphics g = Graphics.FromImage(plot))
            {
                int x = plot.Width / 2;
                int y = plot.Height / 2;
                int w = plot.Width / 4;
                int h = plot.Height / 4;

                if (drawCount % 2 == 0)
                {
                    g.Clear(Color.White);
                    g.FillRectangle(brush1, (x - w) / 2, (y - h) / 2, w, h);
                }
                else
                {
                    g.Clear(Color.Black);
                    g.FillRectangle(brush2, (x - w) / 2, (y - h) / 2, w, h);
                }
                drawCount++;
            }
            pictureBox.Image = plot;
        }

        public void StartSwitchingBackground()
        {
            if (!timer.Enabled)
                timer.Start();
            Console.WriteLine("started");
        }

        public void StopSwitchingBackground()
        {
            if (timer.Enabled) timer.Stop();
            Console.WriteLine("stopped");
        }

        private void btnStartSwitching_Click(object sender, EventArgs e)
        {
            StartSwitchingBackground();
        }

        private void btnStopSwitching_Click(object sender, EventArgs e)
        {
            StopSwitchingBackground();
        }
    }
}
