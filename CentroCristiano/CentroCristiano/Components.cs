using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroCristiano
{
    class Components
    {
        private static Color VerdeOscuro = Color.FromArgb(0, 65, 58);
        private static Color Verde = Color.FromArgb(14, 77, 67);
        private static Color VerdeClaro = Color.FromArgb(54, 115, 109);
        private static Color Veige = Color.FromArgb(230, 190, 124);
        private static Color Blanco = Color.FromArgb(255, 253, 248);
        public static Color GetVerdeOscuro()
        {
            return VerdeOscuro;
        }
        public static Color GetVerde()
        {
            return Verde;
        }
        public static Color GetVerdeClaro()
        {
            return VerdeClaro;
        }
        public static Color GetVeige()
        {
            return Veige;
        }
        public static Color GetBlanco()
        {
            return Blanco;
        }
        public Components()
        {
            
        }
    }
}
