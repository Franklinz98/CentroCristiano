namespace CentroCristiano
{
    partial class InicioLider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioLider));
            this.ISL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PSLLabel = new System.Windows.Forms.Label();
            this.IDLLabel = new System.Windows.Forms.Label();
            this.PassLider = new System.Windows.Forms.TextBox();
            this.IDLider = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISL
            // 
            this.ISL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ISL.Location = new System.Drawing.Point(289, 155);
            this.ISL.Name = "ISL";
            this.ISL.Size = new System.Drawing.Size(80, 23);
            this.ISL.TabIndex = 11;
            this.ISL.Text = "Iniciar Sesión";
            this.ISL.UseVisualStyleBackColor = true;
            this.ISL.Click += new System.EventHandler(this.ISL_Click);
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
            // PSLLabel
            // 
            this.PSLLabel.Location = new System.Drawing.Point(186, 107);
            this.PSLLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.PSLLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.PSLLabel.Name = "PSLLabel";
            this.PSLLabel.Size = new System.Drawing.Size(75, 20);
            this.PSLLabel.TabIndex = 9;
            this.PSLLabel.Text = "Contraseña:";
            this.PSLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDLLabel
            // 
            this.IDLLabel.Location = new System.Drawing.Point(186, 59);
            this.IDLLabel.MaximumSize = new System.Drawing.Size(75, 20);
            this.IDLLabel.MinimumSize = new System.Drawing.Size(75, 20);
            this.IDLLabel.Name = "IDLLabel";
            this.IDLLabel.Size = new System.Drawing.Size(75, 20);
            this.IDLLabel.TabIndex = 8;
            this.IDLLabel.Text = "Identificación:";
            this.IDLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassLider
            // 
            this.PassLider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassLider.Location = new System.Drawing.Point(267, 107);
            this.PassLider.MaxLength = 6;
            this.PassLider.Name = "PassLider";
            this.PassLider.PasswordChar = '•';
            this.PassLider.Size = new System.Drawing.Size(200, 20);
            this.PassLider.TabIndex = 7;
            this.PassLider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassLider.UseSystemPasswordChar = true;
            this.PassLider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassLider_KeyPress);
            // 
            // IDLider
            // 
            this.IDLider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLider.Location = new System.Drawing.Point(267, 59);
            this.IDLider.MaxLength = 10;
            this.IDLider.Name = "IDLider";
            this.IDLider.Size = new System.Drawing.Size(200, 20);
            this.IDLider.TabIndex = 6;
            this.IDLider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDLider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDLider_KeyPress);
            // 
            // InicioLider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.ISL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PSLLabel);
            this.Controls.Add(this.IDLLabel);
            this.Controls.Add(this.PassLider);
            this.Controls.Add(this.IDLider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "InicioLider";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ISL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PSLLabel;
        private System.Windows.Forms.Label IDLLabel;
        private System.Windows.Forms.TextBox PassLider;
        private System.Windows.Forms.TextBox IDLider;
    }
}