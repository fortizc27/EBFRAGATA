
namespace WinFormsApp
{
    partial class FichaTecnica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichaTecnica));
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cbLateralidad = new System.Windows.Forms.ComboBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.lblPadecimiento = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblComent = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblPecho = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblLateralidad = new System.Windows.Forms.Label();
            this.lblPantIzq = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.lblPantDer = new System.Windows.Forms.Label();
            this.lblMusloIzq = new System.Windows.Forms.Label();
            this.lblMusloDer = new System.Windows.Forms.Label();
            this.lblBicepIzq = new System.Windows.Forms.Label();
            this.lblBicepDer = new System.Windows.Forms.Label();
            this.lblAbdomen = new System.Windows.Forms.Label();
            this.lblGluteo = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.numAlcance = new System.Windows.Forms.NumericUpDown();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numPantIzq = new System.Windows.Forms.NumericUpDown();
            this.numPecho = new System.Windows.Forms.NumericUpDown();
            this.numAbdomen = new System.Windows.Forms.NumericUpDown();
            this.numGluteo = new System.Windows.Forms.NumericUpDown();
            this.numBicepDer = new System.Windows.Forms.NumericUpDown();
            this.numBicepIzq = new System.Windows.Forms.NumericUpDown();
            this.numMusloDer = new System.Windows.Forms.NumericUpDown();
            this.numMusloIzq = new System.Windows.Forms.NumericUpDown();
            this.numPantDer = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.errorProviderPadecimientos = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numAlcance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPantIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbdomen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGluteo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBicepDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBicepIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusloDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusloIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPantDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPadecimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAltura.Location = new System.Drawing.Point(31, 359);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(46, 14);
            this.lblAltura.TabIndex = 51;
            this.lblAltura.Text = "Altura*";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPeso.Location = new System.Drawing.Point(31, 309);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 14);
            this.lblPeso.TabIndex = 49;
            this.lblPeso.Text = "Peso*";
            // 
            // cbLateralidad
            // 
            this.cbLateralidad.FormattingEnabled = true;
            this.cbLateralidad.Items.AddRange(new object[] {
            " ",
            "Diestro",
            "Zurdo"});
            this.cbLateralidad.Location = new System.Drawing.Point(31, 429);
            this.cbLateralidad.Name = "cbLateralidad";
            this.cbLateralidad.Size = new System.Drawing.Size(261, 21);
            this.cbLateralidad.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCedula.Location = new System.Drawing.Point(31, 160);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 14);
            this.lblCedula.TabIndex = 45;
            this.lblCedula.Text = "Cédula*";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNombre.Location = new System.Drawing.Point(28, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 14);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre*";
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(31, 227);
            this.txtPadecimiento.Multiline = true;
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(261, 69);
            this.txtPadecimiento.TabIndex = 0;
            // 
            // lblPadecimiento
            // 
            this.lblPadecimiento.AutoSize = true;
            this.lblPadecimiento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPadecimiento.Location = new System.Drawing.Point(31, 210);
            this.lblPadecimiento.Name = "lblPadecimiento";
            this.lblPadecimiento.Size = new System.Drawing.Size(148, 14);
            this.lblPadecimiento.TabIndex = 41;
            this.lblPadecimiento.Text = "Padecimiento o Lesiones*";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(31, 86);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 16);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "INFORMACIÓN GENERAL:";
            // 
            // lblComent
            // 
            this.lblComent.AutoSize = true;
            this.lblComent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblComent.Location = new System.Drawing.Point(41, 48);
            this.lblComent.Name = "lblComent";
            this.lblComent.Size = new System.Drawing.Size(177, 13);
            this.lblComent.TabIndex = 39;
            this.lblComent.Text = "Los campos con (*) son obligatorios";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.lblForm.Location = new System.Drawing.Point(40, 24);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(184, 24);
            this.lblForm.TabIndex = 38;
            this.lblForm.Text = "Formulario Ficha Técnica";
            // 
            // lblPecho
            // 
            this.lblPecho.AutoSize = true;
            this.lblPecho.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPecho.Location = new System.Drawing.Point(344, 111);
            this.lblPecho.Name = "lblPecho";
            this.lblPecho.Size = new System.Drawing.Size(41, 14);
            this.lblPecho.TabIndex = 59;
            this.lblPecho.Text = "Pecho";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTalla.Location = new System.Drawing.Point(31, 510);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(31, 14);
            this.lblTalla.TabIndex = 57;
            this.lblTalla.Text = "Talla";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAlcance.Location = new System.Drawing.Point(31, 461);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(49, 14);
            this.lblAlcance.TabIndex = 55;
            this.lblAlcance.Text = "Alcance";
            // 
            // lblLateralidad
            // 
            this.lblLateralidad.AutoSize = true;
            this.lblLateralidad.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblLateralidad.Location = new System.Drawing.Point(31, 412);
            this.lblLateralidad.Name = "lblLateralidad";
            this.lblLateralidad.Size = new System.Drawing.Size(65, 14);
            this.lblLateralidad.TabIndex = 53;
            this.lblLateralidad.Text = "Lateralidad";
            // 
            // lblPantIzq
            // 
            this.lblPantIzq.AutoSize = true;
            this.lblPantIzq.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPantIzq.Location = new System.Drawing.Point(344, 510);
            this.lblPantIzq.Name = "lblPantIzq";
            this.lblPantIzq.Size = new System.Drawing.Size(112, 14);
            this.lblPantIzq.TabIndex = 75;
            this.lblPantIzq.Text = "Pantorrilla Izquierda";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(31, 527);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(261, 20);
            this.txtTalla.TabIndex = 5;
            // 
            // lblPantDer
            // 
            this.lblPantDer.AutoSize = true;
            this.lblPantDer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblPantDer.Location = new System.Drawing.Point(344, 461);
            this.lblPantDer.Name = "lblPantDer";
            this.lblPantDer.Size = new System.Drawing.Size(108, 14);
            this.lblPantDer.TabIndex = 73;
            this.lblPantDer.Text = "Pantorrilla Derecha";
            // 
            // lblMusloIzq
            // 
            this.lblMusloIzq.AutoSize = true;
            this.lblMusloIzq.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMusloIzq.Location = new System.Drawing.Point(344, 412);
            this.lblMusloIzq.Name = "lblMusloIzq";
            this.lblMusloIzq.Size = new System.Drawing.Size(91, 14);
            this.lblMusloIzq.TabIndex = 71;
            this.lblMusloIzq.Text = "Muslo Izquierdo";
            // 
            // lblMusloDer
            // 
            this.lblMusloDer.AutoSize = true;
            this.lblMusloDer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMusloDer.Location = new System.Drawing.Point(344, 359);
            this.lblMusloDer.Name = "lblMusloDer";
            this.lblMusloDer.Size = new System.Drawing.Size(87, 14);
            this.lblMusloDer.TabIndex = 69;
            this.lblMusloDer.Text = "Muslo Derecho";
            // 
            // lblBicepIzq
            // 
            this.lblBicepIzq.AutoSize = true;
            this.lblBicepIzq.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblBicepIzq.Location = new System.Drawing.Point(344, 309);
            this.lblBicepIzq.Name = "lblBicepIzq";
            this.lblBicepIzq.Size = new System.Drawing.Size(90, 14);
            this.lblBicepIzq.TabIndex = 67;
            this.lblBicepIzq.Text = "Bícep Izquierdo";
            // 
            // lblBicepDer
            // 
            this.lblBicepDer.AutoSize = true;
            this.lblBicepDer.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblBicepDer.Location = new System.Drawing.Point(344, 259);
            this.lblBicepDer.Name = "lblBicepDer";
            this.lblBicepDer.Size = new System.Drawing.Size(86, 14);
            this.lblBicepDer.TabIndex = 65;
            this.lblBicepDer.Text = "Bícep Derecho";
            // 
            // lblAbdomen
            // 
            this.lblAbdomen.AutoSize = true;
            this.lblAbdomen.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAbdomen.Location = new System.Drawing.Point(344, 160);
            this.lblAbdomen.Name = "lblAbdomen";
            this.lblAbdomen.Size = new System.Drawing.Size(60, 14);
            this.lblAbdomen.TabIndex = 63;
            this.lblAbdomen.Text = "Abdomen";
            // 
            // lblGluteo
            // 
            this.lblGluteo.AutoSize = true;
            this.lblGluteo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblGluteo.Location = new System.Drawing.Point(344, 210);
            this.lblGluteo.Name = "lblGluteo";
            this.lblGluteo.Size = new System.Drawing.Size(43, 14);
            this.lblGluteo.TabIndex = 61;
            this.lblGluteo.Text = "Glúteo";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(34, 177);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(258, 20);
            this.txtCedula.TabIndex = 79;
            // 
            // numAlcance
            // 
            this.numAlcance.DecimalPlaces = 2;
            this.numAlcance.Location = new System.Drawing.Point(31, 478);
            this.numAlcance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAlcance.Name = "numAlcance";
            this.numAlcance.Size = new System.Drawing.Size(261, 20);
            this.numAlcance.TabIndex = 4;
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Location = new System.Drawing.Point(31, 376);
            this.numAltura.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(261, 20);
            this.numAltura.TabIndex = 2;
            // 
            // numPeso
            // 
            this.numPeso.Cursor = System.Windows.Forms.Cursors.Default;
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Location = new System.Drawing.Point(31, 326);
            this.numPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(261, 20);
            this.numPeso.TabIndex = 1;
            // 
            // numPantIzq
            // 
            this.numPantIzq.DecimalPlaces = 2;
            this.numPantIzq.Location = new System.Drawing.Point(344, 527);
            this.numPantIzq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPantIzq.Name = "numPantIzq";
            this.numPantIzq.Size = new System.Drawing.Size(261, 20);
            this.numPantIzq.TabIndex = 14;
            // 
            // numPecho
            // 
            this.numPecho.DecimalPlaces = 2;
            this.numPecho.Location = new System.Drawing.Point(344, 129);
            this.numPecho.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPecho.Name = "numPecho";
            this.numPecho.Size = new System.Drawing.Size(261, 20);
            this.numPecho.TabIndex = 6;
            // 
            // numAbdomen
            // 
            this.numAbdomen.DecimalPlaces = 2;
            this.numAbdomen.Location = new System.Drawing.Point(344, 178);
            this.numAbdomen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAbdomen.Name = "numAbdomen";
            this.numAbdomen.Size = new System.Drawing.Size(261, 20);
            this.numAbdomen.TabIndex = 7;
            // 
            // numGluteo
            // 
            this.numGluteo.DecimalPlaces = 2;
            this.numGluteo.Location = new System.Drawing.Point(344, 227);
            this.numGluteo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGluteo.Name = "numGluteo";
            this.numGluteo.Size = new System.Drawing.Size(261, 20);
            this.numGluteo.TabIndex = 8;
            // 
            // numBicepDer
            // 
            this.numBicepDer.DecimalPlaces = 2;
            this.numBicepDer.Location = new System.Drawing.Point(344, 276);
            this.numBicepDer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBicepDer.Name = "numBicepDer";
            this.numBicepDer.Size = new System.Drawing.Size(261, 20);
            this.numBicepDer.TabIndex = 9;
            // 
            // numBicepIzq
            // 
            this.numBicepIzq.DecimalPlaces = 2;
            this.numBicepIzq.Location = new System.Drawing.Point(344, 326);
            this.numBicepIzq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBicepIzq.Name = "numBicepIzq";
            this.numBicepIzq.Size = new System.Drawing.Size(261, 20);
            this.numBicepIzq.TabIndex = 10;
            // 
            // numMusloDer
            // 
            this.numMusloDer.DecimalPlaces = 2;
            this.numMusloDer.Location = new System.Drawing.Point(344, 376);
            this.numMusloDer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMusloDer.Name = "numMusloDer";
            this.numMusloDer.Size = new System.Drawing.Size(261, 20);
            this.numMusloDer.TabIndex = 11;
            // 
            // numMusloIzq
            // 
            this.numMusloIzq.DecimalPlaces = 2;
            this.numMusloIzq.Location = new System.Drawing.Point(344, 430);
            this.numMusloIzq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMusloIzq.Name = "numMusloIzq";
            this.numMusloIzq.Size = new System.Drawing.Size(261, 20);
            this.numMusloIzq.TabIndex = 12;
            // 
            // numPantDer
            // 
            this.numPantDer.DecimalPlaces = 2;
            this.numPantDer.Location = new System.Drawing.Point(344, 478);
            this.numPantDer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPantDer.Name = "numPantDer";
            this.numPantDer.Size = new System.Drawing.Size(261, 20);
            this.numPantDer.TabIndex = 13;
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
            this.btnGuardar.Location = new System.Drawing.Point(240, 570);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 49);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(344, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 49);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProviderPadecimientos
            // 
            this.errorProviderPadecimientos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPadecimientos.ContainerControl = this;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(227, 81);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 96;
            // 
            // FichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 627);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numPantDer);
            this.Controls.Add(this.numMusloIzq);
            this.Controls.Add(this.numMusloDer);
            this.Controls.Add(this.numBicepIzq);
            this.Controls.Add(this.numBicepDer);
            this.Controls.Add(this.numGluteo);
            this.Controls.Add(this.numAbdomen);
            this.Controls.Add(this.numPecho);
            this.Controls.Add(this.numPantIzq);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.numAltura);
            this.Controls.Add(this.numAlcance);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblPantIzq);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.lblPantDer);
            this.Controls.Add(this.lblMusloIzq);
            this.Controls.Add(this.lblMusloDer);
            this.Controls.Add(this.lblBicepIzq);
            this.Controls.Add(this.lblBicepDer);
            this.Controls.Add(this.lblAbdomen);
            this.Controls.Add(this.lblGluteo);
            this.Controls.Add(this.lblPecho);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.lblLateralidad);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cbLateralidad);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPadecimiento);
            this.Controls.Add(this.lblPadecimiento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblComent);
            this.Controls.Add(this.lblForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FichaTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FichaTecnica";
            this.Load += new System.EventHandler(this.FichaTecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAlcance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPantIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAbdomen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGluteo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBicepDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBicepIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusloDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMusloIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPantDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPadecimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cbLateralidad;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.Label lblPadecimiento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblComent;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblPecho;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label lblLateralidad;
        private System.Windows.Forms.Label lblPantIzq;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label lblPantDer;
        private System.Windows.Forms.Label lblMusloIzq;
        private System.Windows.Forms.Label lblMusloDer;
        private System.Windows.Forms.Label lblBicepIzq;
        private System.Windows.Forms.Label lblBicepDer;
        private System.Windows.Forms.Label lblAbdomen;
        private System.Windows.Forms.Label lblGluteo;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.NumericUpDown numAlcance;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.NumericUpDown numPantIzq;
        private System.Windows.Forms.NumericUpDown numPecho;
        private System.Windows.Forms.NumericUpDown numAbdomen;
        private System.Windows.Forms.NumericUpDown numGluteo;
        private System.Windows.Forms.NumericUpDown numBicepDer;
        private System.Windows.Forms.NumericUpDown numBicepIzq;
        private System.Windows.Forms.NumericUpDown numMusloDer;
        private System.Windows.Forms.NumericUpDown numMusloIzq;
        private System.Windows.Forms.NumericUpDown numPantDer;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderPadecimientos;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}