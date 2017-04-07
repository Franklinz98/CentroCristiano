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
            Pastores pastores = new Pastores();
            BackColor = Components.GetBlanco();
            PanelLogos.BackColor = Components.GetVerdeOscuro();
            Diosbendice.ForeColor = Components.GetVeige();
            Diosbendice.Text = "¡Dios bendice tu " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Today.ToString("dddd", new CultureInfo("es-ES"))) + "!";
            PastoresLabel.BackColor = Components.GetVerdeOscuro();
            PastoresLabel.ForeColor = Components.GetBlanco();
            Pastoresbutton.BackColor = Components.GetVerdeOscuro();
            Pastoresbutton.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            Pastoresbutton.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            Pastoresbutton.FlatAppearance.MouseOverBackColor = Components.GetVerde();
            RedLabel.BackColor = Components.GetVerdeOscuro();
            RedLabel.ForeColor = Components.GetBlanco();
            Red.BackColor = Components.GetVerdeOscuro();
            Red.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            Red.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            Red.FlatAppearance.MouseOverBackColor = Components.GetVerde();
            LiderLabel.BackColor = Components.GetVerdeOscuro();
            LiderLabel.ForeColor = Components.GetBlanco();
            Lider.BackColor = Components.GetVerdeOscuro();
            Lider.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            Lider.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            Lider.FlatAppearance.MouseOverBackColor = Components.GetVerde();
        }

        private void Pastores_Click(object sender, EventArgs e)
        {
            LoginPastor LoginP = new LoginPastor();
            LoginP.Show();
        }
    }
}
