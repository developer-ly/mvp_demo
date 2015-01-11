using System;
using System.Windows.Forms;
using DrawingTests.MainModule.Submodule;

namespace DrawingTests.MainModule
{
    public interface IMainView
    {
        ISubView SubView { get; }
        event EventHandler SwitchEventTriggered;
        event EventHandler StopSwitchEventTriggered;
    }

    public partial class MainView : Form, IMainView
    {
        private SubView subView;
        public MainView()
        {
            InitializeComponent();

            subView = new SubView();
            splitContainer1.Panel2.Controls.Add(subView);
            subView.Dock = DockStyle.Fill;
            subView.Anchor = AnchorStyles.Top & AnchorStyles.Left;
            splitContainer1.Resize += splitContainer1_Resize;
        }

        void splitContainer1_Resize(object sender, EventArgs e)
        {
            subView.Size = splitContainer1.Panel2.Size;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartSwitching();
        }

        private void StartSwitching()
        {
            OnStartSwitchingTriggered();
        }

        private void OnStartSwitchingTriggered()
        {
            var handler = SwitchEventTriggered;
            if (handler == null) return;
            handler(this, EventArgs.Empty);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSwitching();
        }

        private void StopSwitching()
        {
            OnStopSwitching();
        }

        private void OnStopSwitching()
        {
            var handler = StopSwitchEventTriggered;
            if (handler == null) return;
            handler(this, EventArgs.Empty);
        }

        public ISubView SubView { get { return this.subView1; } }
        public event EventHandler SwitchEventTriggered;
        public event EventHandler StopSwitchEventTriggered;
    }
}
