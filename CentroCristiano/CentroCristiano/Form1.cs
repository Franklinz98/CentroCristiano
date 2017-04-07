using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroCristiano
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Color VerdeOscuro = Color.FromArgb(0, 65, 58);
            Color Verde = Color.FromArgb(14,77,67);
            Color VerdeClaro = Color.FromArgb(54,115,109);
            Color Veige = Color.FromArgb(230, 190, 124);
            Color Blanco = Color.FromArgb(255, 253, 248);
            BackColor = Blanco;
            PanelLogos.BackColor = VerdeOscuro;
            Diosbendice.ForeColor = Veige;
            Diosbendice.Text = "¡Dios bendice tu " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Today.ToString("dddd", new CultureInfo("es-ES"))) + "!";
            PastoresLabel.BackColor = VerdeOscuro;
            PastoresLabel.ForeColor = Blanco;
            Pastores.BackColor = VerdeOscuro;
            Pastores.FlatAppearance.BorderColor = VerdeOscuro;
            Pastores.FlatAppearance.MouseDownBackColor = VerdeClaro;
            Pastores.FlatAppearance.MouseOverBackColor = Verde;
            RedLabel.BackColor = VerdeOscuro;
            RedLabel.ForeColor = Blanco;
            Red.BackColor = VerdeOscuro;
            Red.FlatAppearance.BorderColor = VerdeOscuro;
            Red.FlatAppearance.MouseDownBackColor = VerdeClaro;
            Red.FlatAppearance.MouseOverBackColor = Verde;
            LiderLabel.BackColor = VerdeOscuro;
            LiderLabel.ForeColor = Blanco;
            Lider.BackColor = VerdeOscuro;
            Lider.FlatAppearance.BorderColor = VerdeOscuro;
            Lider.FlatAppearance.MouseDownBackColor = VerdeClaro;
            Lider.FlatAppearance.MouseOverBackColor = Verde;
        }
    }
}
