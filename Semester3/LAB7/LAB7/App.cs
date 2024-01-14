using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public class App
    {
        public readonly MenuForm MenuWindow;
        public readonly MainForm MainWindow;

        public TCarPark Carpark;

        App()
        {
            setup();
            MenuWindow = new MenuForm();
            MainWindow = new MainForm();
        }

        private void setup()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public void Run()
        {
            Application.Run(MenuWindow);
        }

    }
}
