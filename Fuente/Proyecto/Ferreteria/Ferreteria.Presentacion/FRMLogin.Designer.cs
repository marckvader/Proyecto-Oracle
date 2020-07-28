namespace Ferreteria.Presentacion
{
    partial class FRMLogin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXTuser = new System.Windows.Forms.TextBox();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.LBLUser = new System.Windows.Forms.Label();
            this.LBLPassword = new System.Windows.Forms.Label();
            this.CMBEmpresa = new System.Windows.Forms.ComboBox();
            this.LBLEmpresa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.LBLEmpresa);
            this.panel1.Controls.Add(this.CMBEmpresa);
            this.panel1.Controls.Add(this.LBLPassword);
            this.panel1.Controls.Add(this.LBLUser);
            this.panel1.Controls.Add(this.BTNLogin);
            this.panel1.Controls.Add(this.TXTPassword);
            this.panel1.Controls.Add(this.TXTuser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(26, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 360);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 129);
            this.panel2.TabIndex = 1;
            // 
            // TXTuser
            // 
            this.TXTuser.Location = new System.Drawing.Point(133, 116);
            this.TXTuser.Name = "TXTuser";
            this.TXTuser.Size = new System.Drawing.Size(204, 20);
            this.TXTuser.TabIndex = 1;
            // 
            // TXTPassword
            // 
            this.TXTPassword.Location = new System.Drawing.Point(133, 159);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '*';
            this.TXTPassword.Size = new System.Drawing.Size(204, 20);
            this.TXTPassword.TabIndex = 2;
            // 
            // LBLUser
            // 
            this.LBLUser.AutoSize = true;
            this.LBLUser.Location = new System.Drawing.Point(215, 100);
            this.LBLUser.Name = "LBLUser";
            this.LBLUser.Size = new System.Drawing.Size(43, 13);
            this.LBLUser.TabIndex = 4;
            this.LBLUser.Text = "Usuario";
            // 
            // LBLPassword
            // 
            this.LBLPassword.AutoSize = true;
            this.LBLPassword.Location = new System.Drawing.Point(205, 143);
            this.LBLPassword.Name = "LBLPassword";
            this.LBLPassword.Size = new System.Drawing.Size(53, 13);
            this.LBLPassword.TabIndex = 5;
            this.LBLPassword.Text = "Password";
            // 
            // CMBEmpresa
            // 
            this.CMBEmpresa.FormattingEnabled = true;
            this.CMBEmpresa.Location = new System.Drawing.Point(133, 215);
            this.CMBEmpresa.Name = "CMBEmpresa";
            this.CMBEmpresa.Size = new System.Drawing.Size(204, 21);
            this.CMBEmpresa.TabIndex = 6;
            this.CMBEmpresa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LBLEmpresa
            // 
            this.LBLEmpresa.AutoSize = true;
            this.LBLEmpresa.Location = new System.Drawing.Point(180, 199);
            this.LBLEmpresa.Name = "LBLEmpresa";
            this.LBLEmpresa.Size = new System.Drawing.Size(115, 13);
            this.LBLEmpresa.TabIndex = 7;
            this.LBLEmpresa.Text = "Seleccione la Empresa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ferreteria.Presentacion.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(428, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // BTNLogin
            // 
            this.BTNLogin.FlatAppearance.BorderSize = 0;
            this.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLogin.Image = global::Ferreteria.Presentacion.Properties.Resources.login2;
            this.BTNLogin.Location = new System.Drawing.Point(157, 261);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(154, 69);
            this.BTNLogin.TabIndex = 3;
            this.BTNLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ferreteria.Presentacion.Properties.Resources.person2;
            this.pictureBox1.Location = new System.Drawing.Point(183, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FRMLogin";
            this.Size = new System.Drawing.Size(527, 434);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.TextBox TXTPassword;
        private System.Windows.Forms.TextBox TXTuser;
        private System.Windows.Forms.ComboBox CMBEmpresa;
        private System.Windows.Forms.Label LBLPassword;
        private System.Windows.Forms.Label LBLUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LBLEmpresa;
    }
}
