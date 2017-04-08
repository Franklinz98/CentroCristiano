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
    public partial class LoginPastor : Form
    {
        public static long IdP;
        public static int pass;
        public LoginPastor()
        {
            InitializeComponent();
            BackColor = Components.GetVerdeOscuro();
            IDPastor.BackColor = Components.GetBlanco();
            PassPastor.BackColor = Components.GetBlanco();
            IDPLabel.ForeColor = Components.GetBlanco();
            PSPLabel.ForeColor = Components.GetBlanco();
            ISP.ForeColor = Components.GetBlanco();
            ISP.BackColor = Components.GetVerdeOscuro();
            ISP.FlatAppearance.BorderColor = Components.GetVerdeOscuro();
            ISP.FlatAppearance.MouseDownBackColor = Components.GetVerdeClaro();
            ISP.FlatAppearance.MouseOverBackColor = Components.GetVerde();
        }

        private void IDPastor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(),out i)==false)&&(c!=(char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void PassPastor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false) && (c != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdP = long.Parse(IDPastor.Text);
            pass = int.Parse(PassPastor.Text);

            if (Pastores.buscarPastor(IdP, pass) == false)
            {
                this.Close();

            }
            else
            {
                InterfazPastores ventananueva = new InterfazPastores();
                ventananueva.Show();
                this.Close();
            }
        }

        private void LoginPastor_Load(object sender, EventArgs e)
        {

        }
    }
}
