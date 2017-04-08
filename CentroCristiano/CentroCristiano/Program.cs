using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroCristiano
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreen SPCC = new SplashScreen();
            if (SPCC.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Principal());
            }
        }
    }
}
