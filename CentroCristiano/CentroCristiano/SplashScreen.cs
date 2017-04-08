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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            TiempoSS.Enabled = true;
            TiempoSS.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TiempoSS.Stop();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
