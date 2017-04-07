﻿using System;
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
        public LoginPastor()
        {
            InitializeComponent();
            BackColor = Components.GetVerdeOscuro();
            IDPastor.BackColor = Components.GetBlanco();
            PassPastor.BackColor = Components.GetBlanco();
            IDPLabel.ForeColor = Components.GetBlanco();
            PSPLabel.ForeColor = Components.GetBlanco();
        }

        private void IDPastor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(),out i)==false))
            {
                e.Handled = true;
            }
        }

        private void PassPastor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            int i = 0;
            if ((int.TryParse(c.ToString(), out i) == false))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long IdP = long.Parse(IDPastor.Text);
            int pass = int.Parse(PassPastor.Text);

            if (Pastores.buscarPastor(IdP, pass) == false)
            {
                this.Close();

            }
            else
            {
                Form3 ventananueva = new Form3();
                ventananueva.Show();
                this.Dispose();
            }
        }
    }
}