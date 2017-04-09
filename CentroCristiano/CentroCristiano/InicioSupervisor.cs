using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroCristiano
{
    public partial class InicioSupervisor : Form
    {
        public static long IdS;
        public static int pass;
        public InicioSupervisor()
        {
            InitializeComponent();
            BackColor = Components.GetVerdeOscuro();
            IDSupervisor.BackColor = Components.GetBlanco();
            PassSupervisor.BackColor = Components.GetBlanco();
            IDSLabel.ForeColor = Components.GetBlanco();
            PSSLabel.ForeColor = Components.GetBlanco();
            ISS.ForeColor = Components.GetBlanco();
            ISS.BackColor = Components.GetVerdeOscuro();
            ISS.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            ISS.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            ISS.FlatAppearance.MouseOverBackColor = Components.GetVerde();
        }

        private void IDSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false) && (c != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void PassSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false) && (c != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ISs_Click(object sender, EventArgs e)
        {
            IdS = long.Parse(IDSupervisor.Text);
            pass = int.Parse(PassSupervisor.Text);

            if (Supervisores.buscarSupervisor(IdS, pass) == false)
            {
                this.Close();
            }
            else
            {
                InterfazSupervisor ventananueva = new InterfazSupervisor();
                ventananueva.Show();
                this.Close();
            }
        }
    }
}
