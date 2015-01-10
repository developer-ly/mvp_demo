using System;
using DrawingTests.MainModule.Submodule;

namespace DrawingTests.MainModule
{
    public class MainPresenter
    {
        private readonly IMainView mainView;

        private readonly SubPresenter subPresenter;

        public MainPresenter(IMainView view)
        {
            this.mainView = view;
            this.subPresenter = new SubPresenter(mainView.SubView);
            mainView.SwitchEventTriggered += OnSwitchEventTriggerd;
            mainView.StopSwitchEventTriggered += OnStopSwitchEventTriggered;
        }

        private void OnStopSwitchEventTriggered(object sender, EventArgs e)
        {
            subPresenter.StopSwitching();
        }

        private void OnSwitchEventTriggerd(object sender, EventArgs e)
        {
            subPresenter.SwitchBackground();
        }
    }
}
