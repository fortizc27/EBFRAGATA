
namespace WinFormsApp
{
    partial class Peleas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peleas));
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.lblContrincante = new System.Windows.Forms.Label();
            this.lblFechaPelea = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblComent = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.dtFechaPelea = new System.Windows.Forms.DateTimePicker();
            this.txtContrincante = new System.Windows.Forms.TextBox();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lblIdAtleta = new System.Windows.Forms.Label();
            this.errorProviderFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContrincante = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDecision = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrincante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDecision)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblObservacion.Location = new System.Drawing.Point(30, 414);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(92, 14);
            this.lblObservacion.TabIndex = 94;
            this.lblObservacion.Text = "Observaciones*";
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDecision.Location = new System.Drawing.Point(30, 361);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(58, 14);
            this.lblDecision.TabIndex = 93;
            this.lblDecision.Text = "Decisión*";
            // 
            // lblContrincante
            // 
            this.lblContrincante.AutoSize = true;
            this.lblContrincante.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblContrincante.Location = new System.Drawing.Point(30, 211);
            this.lblContrincante.Name = "lblContrincante";
            this.lblContrincante.Size = new System.Drawing.Size(84, 14);
            this.lblContrincante.TabIndex = 92;
            this.lblContrincante.Text = "Contrincante*";
            // 
            // lblFechaPelea
            // 
            this.lblFechaPelea.AutoSize = true;
            this.lblFechaPelea.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFechaPelea.Location = new System.Drawing.Point(30, 162);
            this.lblFechaPelea.Name = "lblFechaPelea";
            this.lblFechaPelea.Size = new System.Drawing.Size(79, 14);
            this.lblFechaPelea.TabIndex = 90;
            this.lblFechaPelea.Text = "Fecha Pelea*";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 89;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNombre.Location = new System.Drawing.Point(27, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 14);
            this.lblNombre.TabIndex = 88;
            this.lblNombre.Text = "Nombre*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(33, 277);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 69);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDescripcion.Location = new System.Drawing.Point(30, 260);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 14);
            this.lblDescripcion.TabIndex = 86;
            this.lblDescripcion.Text = "Descripción*";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 88);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 16);
            this.lblTitulo.TabIndex = 85;
            this.lblTitulo.Text = "INFORMACIÓN GENERAL:";
            // 
            // lblComent
            // 
            this.lblComent.AutoSize = true;
            this.lblComent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblComent.Location = new System.Drawing.Point(40, 50);
            this.lblComent.Name = "lblComent";
            this.lblComent.Size = new System.Drawing.Size(177, 13);
            this.lblComent.TabIndex = 84;
            this.lblComent.Text = "Los campos con (*) son obligatorios";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.lblForm.Location = new System.Drawing.Point(39, 26);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(134, 24);
            this.lblForm.TabIndex = 83;
            this.lblForm.Text = "Formulario Peleas";
            // 
            // dtFechaPelea
            // 
            this.dtFechaPelea.Location = new System.Drawing.Point(30, 179);
            this.dtFechaPelea.Name = "dtFechaPelea";
            this.dtFechaPelea.Size = new System.Drawing.Size(261, 20);
            this.dtFechaPelea.TabIndex = 0;
            // 
            // txtContrincante
            // 
            this.txtContrincante.Location = new System.Drawing.Point(31, 228);
            this.txtContrincante.Name = "txtContrincante";
            this.txtContrincante.Size = new System.Drawing.Size(261, 20);
            this.txtContrincante.TabIndex = 1;
            // 
            // txtDecision
            // 
            this.txtDecision.Location = new System.Drawing.Point(33, 378);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(261, 20);
            this.txtDecision.TabIndex = 3;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(30, 431);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(261, 69);
            this.txtObservacion.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(192, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 49);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(88, 524);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 49);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIdAtleta
            // 
            this.lblIdAtleta.AutoSize = true;
            this.lblIdAtleta.Location = new System.Drawing.Point(108, 112);
            this.lblIdAtleta.Name = "lblIdAtleta";
            this.lblIdAtleta.Size = new System.Drawing.Size(0, 13);
            this.lblIdAtleta.TabIndex = 104;
            this.lblIdAtleta.Visible = false;
            // 
            // errorProviderFecha
            // 
            this.errorProviderFecha.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFecha.ContainerControl = this;
            // 
            // errorProviderContrincante
            // 
            this.errorProviderContrincante.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContrincante.ContainerControl = this;
            // 
            // errorProviderDescripcion
            // 
            this.errorProviderDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDescripcion.ContainerControl = this;
            // 
            // errorProviderDecision
            // 
            this.errorProviderDecision.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDecision.ContainerControl = this;
            // 
            // Peleas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 585);
            this.Controls.Add(this.lblIdAtleta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.txtContrincante);
            this.Controls.Add(this.dtFechaPelea);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.lblContrincante);
            this.Controls.Add(this.lblFechaPelea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblComent);
            this.Controls.Add(this.lblForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Peleas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peleas";
            this.Load += new System.EventHandler(this.Peleas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrincante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Label lblContrincante;
        private System.Windows.Forms.Label lblFechaPelea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblComent;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.DateTimePicker dtFechaPelea;
        private System.Windows.Forms.TextBox txtContrincante;
        private System.Windows.Forms.TextBox txtDecision;
        private System.Windows.Forms.TextBox txtObservacion;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label lblIdAtleta;
        private System.Windows.Forms.ErrorProvider errorProviderFecha;
        private System.Windows.Forms.ErrorProvider errorProviderContrincante;
        private System.Windows.Forms.ErrorProvider errorProviderDescripcion;
        private System.Windows.Forms.ErrorProvider errorProviderDecision;
    }
}