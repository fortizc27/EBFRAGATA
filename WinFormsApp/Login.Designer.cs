
namespace WinFormsApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnEntrar = new FontAwesome.Sharp.IconButton();
            this.ImagenLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(293, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(293, 97);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(44, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "CLAVE:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(296, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(296, 113);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 4;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.btnEntrar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnEntrar.IconColor = System.Drawing.Color.Black;
            this.btnEntrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntrar.IconSize = 35;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntrar.Location = new System.Drawing.Point(310, 152);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 34);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // ImagenLogin
            // 
            this.ImagenLogin.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogin.Image")));
            this.ImagenLogin.Location = new System.Drawing.Point(46, 37);
            this.ImagenLogin.Name = "ImagenLogin";
            this.ImagenLogin.Size = new System.Drawing.Size(200, 149);
            this.ImagenLogin.TabIndex = 6;
            this.ImagenLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(449, 221);
            this.Controls.Add(this.ImagenLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(465, 260);
            this.MinimumSize = new System.Drawing.Size(465, 260);
            this.Name = "Login";
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconButton btnEntrar;
        private System.Windows.Forms.PictureBox ImagenLogin;
    }
}

