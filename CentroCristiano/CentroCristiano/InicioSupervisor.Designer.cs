namespace CentroCristiano
{
    partial class InicioSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSupervisor));
            this.ISS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PSSLabel = new System.Windows.Forms.Label();
            this.IDSLabel = new System.Windows.Forms.Label();
            this.PassSupervisor = new System.Windows.Forms.TextBox();
            this.IDSupervisor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISS
            // 
            this.ISS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISS.Location = new System.Drawing.Point(289, 155);
            this.ISS.Name = "ISS";
            this.ISS.Size = new System.Drawing.Size(80, 23);
            this.ISS.TabIndex = 11;
            this.ISS.Text = "Iniciar Sesión";
            this.ISS.UseVisualStyleBackColor = true;
            this.ISS.Click += new System.EventHandler(this.ISs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CentroCristiano.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(26, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 140);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PSSLabel
            // 
            this.PSSLabel.Location = new System.Drawing.Point(186, 107);
            this.PSSLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.PSSLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.PSSLabel.Name = "PSSLabel";
            this.PSSLabel.Size = new System.Drawing.Size(75, 20);
            this.PSSLabel.TabIndex = 9;
            this.PSSLabel.Text = "Contraseña:";
            this.PSSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDSLabel
            // 
            this.IDSLabel.Location = new System.Drawing.Point(186, 59);
            this.IDSLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.IDSLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.IDSLabel.Name = "IDSLabel";
            this.IDSLabel.Size = new System.Drawing.Size(75, 20);
            this.IDSLabel.TabIndex = 8;
            this.IDSLabel.Text = "Identificación:";
            this.IDSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassSupervisor
            // 
            this.PassSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassSupervisor.Location = new System.Drawing.Point(267, 107);
            this.PassSupervisor.MaxLength = 6;
            this.PassSupervisor.Name = "PassSupervisor";
            this.PassSupervisor.PasswordChar = '•';
            this.PassSupervisor.Size = new System.Drawing.Size(200, 20);
            this.PassSupervisor.TabIndex = 7;
            this.PassSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassSupervisor.UseSystemPasswordChar = true;
            this.PassSupervisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassSupervisor_KeyPress);
            // 
            // IDSupervisor
            // 
            this.IDSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDSupervisor.Location = new System.Drawing.Point(267, 59);
            this.IDSupervisor.MaxLength = 10;
            this.IDSupervisor.Name = "IDSupervisor";
            this.IDSupervisor.Size = new System.Drawing.Size(200, 20);
            this.IDSupervisor.TabIndex = 6;
            this.IDSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDSupervisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDSupervisor_KeyPress);
            // 
            // InicioSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.ISS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PSSLabel);
            this.Controls.Add(this.IDSLabel);
            this.Controls.Add(this.PassSupervisor);
            this.Controls.Add(this.IDSupervisor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "InicioSupervisor";
            this.ShowInTaskbar = false;
            this.Text = "Iniciar Sesión";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ISS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PSSLabel;
        private System.Windows.Forms.Label IDSLabel;
        private System.Windows.Forms.TextBox PassSupervisor;
        private System.Windows.Forms.TextBox IDSupervisor;
    }
}