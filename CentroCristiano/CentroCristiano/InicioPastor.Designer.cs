﻿namespace CentroCristiano
{
    partial class LoginPastor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPastor));
            this.IDPastor = new System.Windows.Forms.TextBox();
            this.PassPastor = new System.Windows.Forms.TextBox();
            this.IDPLabel = new System.Windows.Forms.Label();
            this.PSPLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ISP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDPastor
            // 
            this.IDPastor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDPastor.Location = new System.Drawing.Point(267, 59);
            this.IDPastor.MaxLength = 10;
            this.IDPastor.Name = "IDPastor";
            this.IDPastor.Size = new System.Drawing.Size(200, 20);
            this.IDPastor.TabIndex = 0;
            this.IDPastor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDPastor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDPastor_KeyPress);
            // 
            // PassPastor
            // 
            this.PassPastor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassPastor.Location = new System.Drawing.Point(267, 107);
            this.PassPastor.MaxLength = 6;
            this.PassPastor.Name = "PassPastor";
            this.PassPastor.PasswordChar = '•';
            this.PassPastor.Size = new System.Drawing.Size(200, 20);
            this.PassPastor.TabIndex = 1;
            this.PassPastor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassPastor.UseSystemPasswordChar = true;
            this.PassPastor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassPastor_KeyPress);
            // 
            // IDPLabel
            // 
            this.IDPLabel.Location = new System.Drawing.Point(186, 59);
            this.IDPLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.IDPLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.IDPLabel.Name = "IDPLabel";
            this.IDPLabel.Size = new System.Drawing.Size(75, 20);
            this.IDPLabel.TabIndex = 2;
            this.IDPLabel.Text = "Identificación:";
            this.IDPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PSPLabel
            // 
            this.PSPLabel.Location = new System.Drawing.Point(186, 107);
            this.PSPLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.PSPLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.PSPLabel.Name = "PSPLabel";
            this.PSPLabel.Size = new System.Drawing.Size(75, 20);
            this.PSPLabel.TabIndex = 3;
            this.PSPLabel.Text = "Contraseña:";
            this.PSPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CentroCristiano.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(26, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ISP
            // 
            this.ISP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISP.Location = new System.Drawing.Point(289, 155);
            this.ISP.Name = "ISP";
            this.ISP.Size = new System.Drawing.Size(80, 23);
            this.ISP.TabIndex = 5;
            this.ISP.Text = "Iniciar Sesión";
            this.ISP.UseVisualStyleBackColor = true;
            this.ISP.Click += new System.EventHandler(this.ISP_Click);
            // 
            // LoginPastor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.ISP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PSPLabel);
            this.Controls.Add(this.IDPLabel);
            this.Controls.Add(this.PassPastor);
            this.Controls.Add(this.IDPastor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "LoginPastor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDPastor;
        private System.Windows.Forms.TextBox PassPastor;
        private System.Windows.Forms.Label IDPLabel;
        private System.Windows.Forms.Label PSPLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ISP;
    }
}