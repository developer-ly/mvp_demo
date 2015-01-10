using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingTests.MainModule;

namespace DrawingTests
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView mainView = new MainView();
            MainPresenter mainPresenter = new MainPresenter(mainView);

            Application.Run(mainView);
        }
    }
}
