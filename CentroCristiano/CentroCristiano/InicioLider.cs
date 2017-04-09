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
    public partial class InicioLider : Form
    {
        public static long IdL;
        public static int pass;
        public InicioLider()
        {
            InitializeComponent();
            BackColor = Components.GetVerdeOscuro();
            IDLider.BackColor = Components.GetBlanco();
            PassLider.BackColor = Components.GetBlanco();
            IDLLabel.ForeColor = Components.GetBlanco();
            PSLLabel.ForeColor = Components.GetBlanco();
            ISL.ForeColor = Components.GetBlanco();
            ISL.BackColor = Components.GetVerdeOscuro();
            ISL.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            ISL.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            ISL.FlatAppearance.MouseOverBackColor = Components.GetVerde();
        }

        private void IDLider_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false) && (c != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void PassLider_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false) && (c != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ISL_Click(object sender, EventArgs e)
        {
            IdL = long.Parse(IDLider.Text);
            pass = int.Parse(PassLider.Text);

            if (Lideres.BuscarLider(IdL, pass) == false)
            {
                this.Close();
            }
            else
            {
                InterfazLider ventananueva = new InterfazLider();
                ventananueva.Show();
                this.Close();
            }
        }
    }
}
