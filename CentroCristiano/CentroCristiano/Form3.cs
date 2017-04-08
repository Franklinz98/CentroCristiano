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
    public partial class InterfazPastores : Form
    {
        public static String nombreusuario;

        public InterfazPastores()
        {
            InitializeComponent();
            //this.Text = "Plan Felipe Integral: " + Pastores.buscarNombre(LoginPastor.IdP);
        }
    }
}
