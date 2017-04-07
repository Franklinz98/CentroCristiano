namespace CentroCristiano
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDPastor
            // 
            this.IDPastor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDPastor.Location = new System.Drawing.Point(273, 86);
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
            this.PassPastor.Location = new System.Drawing.Point(273, 147);
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
            this.IDPLabel.Location = new System.Drawing.Point(194, 88);
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
            this.PSPLabel.Location = new System.Drawing.Point(192, 147);
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
            this.pictureBox1.Location = new System.Drawing.Point(32, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginPastor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PSPLabel);
            this.Controls.Add(this.IDPLabel);
            this.Controls.Add(this.PassPastor);
            this.Controls.Add(this.IDPastor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(510, 300);
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "LoginPastor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
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
        private System.Windows.Forms.Button button1;
    }
}