namespace DrawingTests.MainModule.Submodule
{
    public class SubPresenter
    {
        private ISubView view;

        public SubPresenter(ISubView view)
        {
            this.view = view;
        }

        public void SwitchBackground()
        {
            view.StartSwitchingBackground();
        }

        public void StopSwitching()
        {
            view.StopSwitchingBackground();
        }
    }
}
