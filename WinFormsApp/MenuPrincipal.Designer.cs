
namespace WinFormsApp
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pp2 = new System.Windows.Forms.Panel();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnPanelPrincipal = new FontAwesome.Sharp.IconButton();
            this.pp1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.iconLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblVentana = new System.Windows.Forms.Label();
            this.iconVentana = new FontAwesome.Sharp.IconPictureBox();
            this.pp3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pp4 = new System.Windows.Forms.Panel();
            this.pp2.SuspendLayout();
            this.pp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).BeginInit();
            this.pp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pp2
            // 
            this.pp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.pp2.Controls.Add(this.btnAyuda);
            this.pp2.Controls.Add(this.btnReportes);
            this.pp2.Controls.Add(this.panel2);
            this.pp2.Controls.Add(this.btnAcercaDe);
            this.pp2.Controls.Add(this.btnSalir);
            this.pp2.Controls.Add(this.btnRoles);
            this.pp2.Controls.Add(this.btnUsuarios);
            this.pp2.Controls.Add(this.btnClientes);
            this.pp2.Controls.Add(this.btnPanelPrincipal);
            this.pp2.Controls.Add(this.pp1);
            this.pp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pp2.Location = new System.Drawing.Point(0, 0);
            this.pp2.Name = "pp2";
            this.pp2.Size = new System.Drawing.Size(206, 659);
            this.pp2.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.AutoEllipsis = true;
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.Black;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 32;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 540);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(206, 39);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 36;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 292);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(206, 39);
            this.btnReportes.TabIndex = 10;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 2);
            this.panel2.TabIndex = 9;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AutoEllipsis = true;
            this.btnAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnAcercaDe.IconColor = System.Drawing.Color.Black;
            this.btnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcercaDe.IconSize = 36;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 581);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(206, 39);
            this.btnAcercaDe.TabIndex = 8;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoEllipsis = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 620);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 39);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnRoles.IconColor = System.Drawing.Color.Black;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoles.IconSize = 36;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 253);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(206, 39);
            this.btnRoles.TabIndex = 6;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 36;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 214);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(206, 39);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 36;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 175);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(206, 39);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnPanelPrincipal
            // 
            this.btnPanelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanelPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPanelPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnPanelPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnPanelPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPrincipal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnPanelPrincipal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPanelPrincipal.IconColor = System.Drawing.Color.Black;
            this.btnPanelPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPanelPrincipal.IconSize = 36;
            this.btnPanelPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanelPrincipal.Location = new System.Drawing.Point(0, 136);
            this.btnPanelPrincipal.Name = "btnPanelPrincipal";
            this.btnPanelPrincipal.Size = new System.Drawing.Size(206, 39);
            this.btnPanelPrincipal.TabIndex = 2;
            this.btnPanelPrincipal.Text = "Panel Principal";
            this.btnPanelPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanelPrincipal.UseVisualStyleBackColor = false;
            this.btnPanelPrincipal.Click += new System.EventHandler(this.btnPanelPrincipal_Click);
            // 
            // pp1
            // 
            this.pp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.pp1.Controls.Add(this.lblTitulo);
            this.pp1.Controls.Add(this.iconLogo);
            this.pp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pp1.Location = new System.Drawing.Point(0, 0);
            this.pp1.Name = "pp1";
            this.pp1.Size = new System.Drawing.Size(206, 136);
            this.pp1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 32);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Escuela de Boxeo\r\nFRAGATA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.Transparent;
            this.iconLogo.ForeColor = System.Drawing.Color.Black;
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconLogo.IconColor = System.Drawing.Color.Black;
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.IconSize = 62;
            this.iconLogo.Location = new System.Drawing.Point(52, 15);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(72, 62);
            this.iconLogo.TabIndex = 3;
            this.iconLogo.TabStop = false;
            // 
            // lblVentana
            // 
            this.lblVentana.AutoSize = true;
            this.lblVentana.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F);
            this.lblVentana.Location = new System.Drawing.Point(52, 8);
            this.lblVentana.Name = "lblVentana";
            this.lblVentana.Size = new System.Drawing.Size(172, 30);
            this.lblVentana.TabIndex = 1;
            this.lblVentana.Text = "PANEL PRINCIPAL";
            // 
            // iconVentana
            // 
            this.iconVentana.BackColor = System.Drawing.Color.Transparent;
            this.iconVentana.ForeColor = System.Drawing.Color.Black;
            this.iconVentana.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconVentana.IconColor = System.Drawing.Color.Black;
            this.iconVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentana.IconSize = 36;
            this.iconVentana.Location = new System.Drawing.Point(10, 5);
            this.iconVentana.Name = "iconVentana";
            this.iconVentana.Size = new System.Drawing.Size(37, 36);
            this.iconVentana.TabIndex = 1;
            this.iconVentana.TabStop = false;
            // 
            // pp3
            // 
            this.pp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.pp3.Controls.Add(this.panel1);
            this.pp3.Controls.Add(this.iconVentana);
            this.pp3.Controls.Add(this.lblVentana);
            this.pp3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pp3.Location = new System.Drawing.Point(206, 0);
            this.pp3.Name = "pp3";
            this.pp3.Size = new System.Drawing.Size(979, 41);
            this.pp3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(215)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 2);
            this.panel1.TabIndex = 2;
            // 
            // pp4
            // 
            this.pp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pp4.Location = new System.Drawing.Point(206, 41);
            this.pp4.Name = "pp4";
            this.pp4.Size = new System.Drawing.Size(979, 618);
            this.pp4.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1185, 659);
            this.Controls.Add(this.pp4);
            this.Controls.Add(this.pp3);
            this.Controls.Add(this.pp2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escuela de Boxeo FRAGATA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.pp2.ResumeLayout(false);
            this.pp1.ResumeLayout(false);
            this.pp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).EndInit();
            this.pp3.ResumeLayout(false);
            this.pp3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pp3;
        private System.Windows.Forms.Panel pp2;
        private System.Windows.Forms.Panel pp1;
        private System.Windows.Forms.Label lblVentana;
        private FontAwesome.Sharp.IconPictureBox iconVentana;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
        private FontAwesome.Sharp.IconButton btnPanelPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pp4;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAcercaDe;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnAyuda;
    }
}