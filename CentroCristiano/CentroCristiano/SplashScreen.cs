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
    public partial class SplashScreenCC : Form
    {
        public SplashScreenCC()
        {
            InitializeComponent();
            TimerSS.Enabled = true;
            TimerSS.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerSS.Stop();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
