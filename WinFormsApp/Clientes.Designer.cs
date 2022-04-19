
namespace WinFormsApp
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.errorProviderIngreso = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGenero = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFecNac = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNacionalidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCerrarFormulario = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelAddEdit = new System.Windows.Forms.Panel();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnPeleas = new FontAwesome.Sharp.IconButton();
            this.btnFichaTecnica = new FontAwesome.Sharp.IconButton();
            this.lblTelefonoSOS = new System.Windows.Forms.Label();
            this.txtTelefonoSOS = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularSOS = new System.Windows.Forms.MaskedTextBox();
            this.lblCelularSOS = new System.Windows.Forms.Label();
            this.txtEmailSOS = new System.Windows.Forms.TextBox();
            this.lblEmailSOS = new System.Windows.Forms.Label();
            this.txtNacionalidadSOS = new System.Windows.Forms.TextBox();
            this.lblNacionalidadSOS = new System.Windows.Forms.Label();
            this.dtFechaNacSOS = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacSOS = new System.Windows.Forms.Label();
            this.cbGeneroSOS = new System.Windows.Forms.ComboBox();
            this.lblGeneroSOS = new System.Windows.Forms.Label();
            this.txtCedulaSOS = new System.Windows.Forms.MaskedTextBox();
            this.lblCedulaSOS = new System.Windows.Forms.Label();
            this.txtNombreSOS = new System.Windows.Forms.TextBox();
            this.lblNombreSOS = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblComent = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.errorProviderParticular = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSangre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombreCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIdCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFecNacCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNacionalidadCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmailCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCelularCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderParticularCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGeneroCE = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecNac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCelular)).BeginInit();
            this.panelAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParticular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSangre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecNacCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidadCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCelularCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParticularCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGeneroCE)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 59);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.lblNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClientes, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(64, 59);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.lblNum.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNum.Location = new System.Drawing.Point(11, 9);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(51, 30);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "70";
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.lblClientes.Location = new System.Drawing.Point(11, 39);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(75, 18);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Controls.Add(this.dgClientes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(831, 590);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.ColumnHeadersHeight = 35;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Categoria,
            this.Nombre,
            this.IdCliente,
            this.Genero,
            this.FechaNac,
            this.Nacionalidad,
            this.Correo,
            this.Celular,
            this.Particular,
            this.Sangre,
            this.Direccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClientes.Location = new System.Drawing.Point(12, 12);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgClientes.RowHeadersWidth = 42;
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(807, 536);
            this.dgClientes.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "FechaIngreso";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.DataPropertyName = "IdCliente";
            this.IdCliente.HeaderText = "Cedula";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "FechaNac";
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Email";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Particular
            // 
            this.Particular.DataPropertyName = "Particular";
            this.Particular.HeaderText = "Particular";
            this.Particular.Name = "Particular";
            this.Particular.ReadOnly = true;
            // 
            // Sangre
            // 
            this.Sangre.DataPropertyName = "Sangre";
            this.Sangre.HeaderText = "Tipo Sangre";
            this.Sangre.Name = "Sangre";
            this.Sangre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(12, 554);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 33);
            this.panel3.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Crimson;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 18;
            this.btnEliminar.Location = new System.Drawing.Point(720, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 25);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 18;
            this.btnEditar.Location = new System.Drawing.Point(633, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.errorProviderCategoria.SetIconAlignment(this.btnNuevo, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 18;
            this.btnNuevo.Location = new System.Drawing.Point(546, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(81, 25);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorProviderIngreso
            // 
            this.errorProviderIngreso.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderIngreso.ContainerControl = this;
            // 
            // errorProviderCategoria
            // 
            this.errorProviderCategoria.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCategoria.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderId
            // 
            this.errorProviderId.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderId.ContainerControl = this;
            // 
            // errorProviderGenero
            // 
            this.errorProviderGenero.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderGenero.ContainerControl = this;
            // 
            // errorProviderFecNac
            // 
            this.errorProviderFecNac.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFecNac.ContainerControl = this;
            // 
            // errorProviderNacionalidad
            // 
            this.errorProviderNacionalidad.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNacionalidad.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderCelular
            // 
            this.errorProviderCelular.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCelular.ContainerControl = this;
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
            this.btnGuardar.Location = new System.Drawing.Point(107, 1214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 49);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrarFormulario
            // 
            this.btnCerrarFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarFormulario.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFormulario.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCerrarFormulario.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormulario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnCerrarFormulario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrarFormulario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormulario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarFormulario.ForeColor = System.Drawing.Color.Crimson;
            this.btnCerrarFormulario.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrarFormulario.IconColor = System.Drawing.Color.Crimson;
            this.btnCerrarFormulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarFormulario.IconSize = 32;
            this.btnCerrarFormulario.Location = new System.Drawing.Point(-50, -437);
            this.btnCerrarFormulario.Name = "btnCerrarFormulario";
            this.btnCerrarFormulario.Size = new System.Drawing.Size(28, 28);
            this.btnCerrarFormulario.TabIndex = 23;
            this.btnCerrarFormulario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarFormulario.UseVisualStyleBackColor = false;
            this.btnCerrarFormulario.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.Location = new System.Drawing.Point(33, 674);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 87);
            this.iconButton1.TabIndex = 58;
            this.iconButton1.Text = "Ficha Técnica";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.Location = new System.Drawing.Point(161, 674);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 87);
            this.iconButton2.TabIndex = 59;
            this.iconButton2.Text = "Peleas";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.AutoScroll = true;
            this.panelAddEdit.BackColor = System.Drawing.Color.White;
            this.panelAddEdit.Controls.Add(this.dtIngreso);
            this.panelAddEdit.Controls.Add(this.lblClienteId);
            this.panelAddEdit.Controls.Add(this.btnCerrar);
            this.panelAddEdit.Controls.Add(this.btnPeleas);
            this.panelAddEdit.Controls.Add(this.btnFichaTecnica);
            this.panelAddEdit.Controls.Add(this.lblTelefonoSOS);
            this.panelAddEdit.Controls.Add(this.txtTelefonoSOS);
            this.panelAddEdit.Controls.Add(this.txtCelularSOS);
            this.panelAddEdit.Controls.Add(this.lblCelularSOS);
            this.panelAddEdit.Controls.Add(this.txtEmailSOS);
            this.panelAddEdit.Controls.Add(this.lblEmailSOS);
            this.panelAddEdit.Controls.Add(this.txtNacionalidadSOS);
            this.panelAddEdit.Controls.Add(this.lblNacionalidadSOS);
            this.panelAddEdit.Controls.Add(this.dtFechaNacSOS);
            this.panelAddEdit.Controls.Add(this.lblFechaNacSOS);
            this.panelAddEdit.Controls.Add(this.cbGeneroSOS);
            this.panelAddEdit.Controls.Add(this.lblGeneroSOS);
            this.panelAddEdit.Controls.Add(this.txtCedulaSOS);
            this.panelAddEdit.Controls.Add(this.lblCedulaSOS);
            this.panelAddEdit.Controls.Add(this.txtNombreSOS);
            this.panelAddEdit.Controls.Add(this.lblNombreSOS);
            this.panelAddEdit.Controls.Add(this.lblTitulo2);
            this.panelAddEdit.Controls.Add(this.txtDireccion);
            this.panelAddEdit.Controls.Add(this.lblDireccion);
            this.panelAddEdit.Controls.Add(this.txtSangre);
            this.panelAddEdit.Controls.Add(this.lblSangre);
            this.panelAddEdit.Controls.Add(this.lblTelefono);
            this.panelAddEdit.Controls.Add(this.txtTelefono);
            this.panelAddEdit.Controls.Add(this.txtCelular);
            this.panelAddEdit.Controls.Add(this.lblCelular);
            this.panelAddEdit.Controls.Add(this.txtEmail);
            this.panelAddEdit.Controls.Add(this.lblEmail);
            this.panelAddEdit.Controls.Add(this.txtNacionalidad);
            this.panelAddEdit.Controls.Add(this.lblNacionalidad);
            this.panelAddEdit.Controls.Add(this.lblFechaNacimiento);
            this.panelAddEdit.Controls.Add(this.cbGenero);
            this.panelAddEdit.Controls.Add(this.lblGenero);
            this.panelAddEdit.Controls.Add(this.txtCedula);
            this.panelAddEdit.Controls.Add(this.lblCedula);
            this.panelAddEdit.Controls.Add(this.cbCategoria);
            this.panelAddEdit.Controls.Add(this.lblCategoria);
            this.panelAddEdit.Controls.Add(this.dtFechaNacimiento);
            this.panelAddEdit.Controls.Add(this.lblFechaIngreso);
            this.panelAddEdit.Controls.Add(this.txtNombre);
            this.panelAddEdit.Controls.Add(this.lblNombre);
            this.panelAddEdit.Controls.Add(this.lblTitulo1);
            this.panelAddEdit.Controls.Add(this.lblComent);
            this.panelAddEdit.Controls.Add(this.lblForm);
            this.panelAddEdit.Controls.Add(this.btnCerrarFormulario);
            this.panelAddEdit.Controls.Add(this.btnGuardar);
            this.panelAddEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddEdit.Location = new System.Drawing.Point(831, 59);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(287, 590);
            this.panelAddEdit.TabIndex = 1;
            this.panelAddEdit.Visible = false;
            // 
            // dtIngreso
            // 
            this.dtIngreso.Enabled = false;
            this.dtIngreso.Location = new System.Drawing.Point(6, 130);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(261, 20);
            this.dtIngreso.TabIndex = 71;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(93, 23);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(0, 13);
            this.lblClienteId.TabIndex = 70;
            this.lblClienteId.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Red;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 32;
            this.btnCerrar.Location = new System.Drawing.Point(219, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 24);
            this.btnCerrar.TabIndex = 69;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPeleas
            // 
            this.btnPeleas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeleas.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnPeleas.IconColor = System.Drawing.Color.Black;
            this.btnPeleas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPeleas.Location = new System.Drawing.Point(156, 1114);
            this.btnPeleas.Name = "btnPeleas";
            this.btnPeleas.Size = new System.Drawing.Size(75, 77);
            this.btnPeleas.TabIndex = 20;
            this.btnPeleas.Text = "Registro Peleas";
            this.btnPeleas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPeleas.UseVisualStyleBackColor = true;
            this.btnPeleas.Click += new System.EventHandler(this.btnPeleas_Click);
            // 
            // btnFichaTecnica
            // 
            this.btnFichaTecnica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaTecnica.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.btnFichaTecnica.IconColor = System.Drawing.Color.Black;
            this.btnFichaTecnica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFichaTecnica.Location = new System.Drawing.Point(41, 1114);
            this.btnFichaTecnica.Name = "btnFichaTecnica";
            this.btnFichaTecnica.Size = new System.Drawing.Size(75, 77);
            this.btnFichaTecnica.TabIndex = 19;
            this.btnFichaTecnica.Text = "Ficha Técnica";
            this.btnFichaTecnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFichaTecnica.UseVisualStyleBackColor = true;
            this.btnFichaTecnica.Click += new System.EventHandler(this.btnFichaTecnica_Click);
            // 
            // lblTelefonoSOS
            // 
            this.lblTelefonoSOS.AutoSize = true;
            this.lblTelefonoSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTelefonoSOS.Location = new System.Drawing.Point(144, 1045);
            this.lblTelefonoSOS.Name = "lblTelefonoSOS";
            this.lblTelefonoSOS.Size = new System.Drawing.Size(123, 14);
            this.lblTelefonoSOS.TabIndex = 66;
            this.lblTelefonoSOS.Text = "Teléfono Residencia*";
            // 
            // txtTelefonoSOS
            // 
            this.txtTelefonoSOS.Location = new System.Drawing.Point(147, 1062);
            this.txtTelefonoSOS.Name = "txtTelefonoSOS";
            this.txtTelefonoSOS.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoSOS.TabIndex = 18;
            // 
            // txtCelularSOS
            // 
            this.txtCelularSOS.Location = new System.Drawing.Point(6, 1062);
            this.txtCelularSOS.Name = "txtCelularSOS";
            this.txtCelularSOS.Size = new System.Drawing.Size(100, 20);
            this.txtCelularSOS.TabIndex = 17;
            // 
            // lblCelularSOS
            // 
            this.lblCelularSOS.AutoSize = true;
            this.lblCelularSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCelularSOS.Location = new System.Drawing.Point(6, 1045);
            this.lblCelularSOS.Name = "lblCelularSOS";
            this.lblCelularSOS.Size = new System.Drawing.Size(102, 14);
            this.lblCelularSOS.TabIndex = 63;
            this.lblCelularSOS.Text = "Teléfono Celular*";
            // 
            // txtEmailSOS
            // 
            this.txtEmailSOS.Location = new System.Drawing.Point(6, 1005);
            this.txtEmailSOS.Name = "txtEmailSOS";
            this.txtEmailSOS.Size = new System.Drawing.Size(261, 20);
            this.txtEmailSOS.TabIndex = 16;
            // 
            // lblEmailSOS
            // 
            this.lblEmailSOS.AutoSize = true;
            this.lblEmailSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblEmailSOS.Location = new System.Drawing.Point(6, 988);
            this.lblEmailSOS.Name = "lblEmailSOS";
            this.lblEmailSOS.Size = new System.Drawing.Size(41, 14);
            this.lblEmailSOS.TabIndex = 61;
            this.lblEmailSOS.Text = "Email*";
            // 
            // txtNacionalidadSOS
            // 
            this.txtNacionalidadSOS.Location = new System.Drawing.Point(6, 956);
            this.txtNacionalidadSOS.Name = "txtNacionalidadSOS";
            this.txtNacionalidadSOS.Size = new System.Drawing.Size(261, 20);
            this.txtNacionalidadSOS.TabIndex = 15;
            // 
            // lblNacionalidadSOS
            // 
            this.lblNacionalidadSOS.AutoSize = true;
            this.lblNacionalidadSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNacionalidadSOS.Location = new System.Drawing.Point(6, 939);
            this.lblNacionalidadSOS.Name = "lblNacionalidadSOS";
            this.lblNacionalidadSOS.Size = new System.Drawing.Size(80, 14);
            this.lblNacionalidadSOS.TabIndex = 59;
            this.lblNacionalidadSOS.Text = "Nacionalidad*";
            // 
            // dtFechaNacSOS
            // 
            this.dtFechaNacSOS.Location = new System.Drawing.Point(6, 906);
            this.dtFechaNacSOS.Name = "dtFechaNacSOS";
            this.dtFechaNacSOS.Size = new System.Drawing.Size(261, 20);
            this.dtFechaNacSOS.TabIndex = 14;
            // 
            // lblFechaNacSOS
            // 
            this.lblFechaNacSOS.AutoSize = true;
            this.lblFechaNacSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFechaNacSOS.Location = new System.Drawing.Point(6, 889);
            this.lblFechaNacSOS.Name = "lblFechaNacSOS";
            this.lblFechaNacSOS.Size = new System.Drawing.Size(110, 14);
            this.lblFechaNacSOS.TabIndex = 57;
            this.lblFechaNacSOS.Text = "Fecha Nacimiento*";
            // 
            // cbGeneroSOS
            // 
            this.cbGeneroSOS.FormattingEnabled = true;
            this.cbGeneroSOS.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.cbGeneroSOS.Location = new System.Drawing.Point(6, 856);
            this.cbGeneroSOS.Name = "cbGeneroSOS";
            this.cbGeneroSOS.Size = new System.Drawing.Size(261, 21);
            this.cbGeneroSOS.TabIndex = 13;
            // 
            // lblGeneroSOS
            // 
            this.lblGeneroSOS.AutoSize = true;
            this.lblGeneroSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblGeneroSOS.Location = new System.Drawing.Point(6, 839);
            this.lblGeneroSOS.Name = "lblGeneroSOS";
            this.lblGeneroSOS.Size = new System.Drawing.Size(54, 14);
            this.lblGeneroSOS.TabIndex = 55;
            this.lblGeneroSOS.Text = "Género*";
            // 
            // txtCedulaSOS
            // 
            this.txtCedulaSOS.Location = new System.Drawing.Point(6, 807);
            this.txtCedulaSOS.Name = "txtCedulaSOS";
            this.txtCedulaSOS.Size = new System.Drawing.Size(261, 20);
            this.txtCedulaSOS.TabIndex = 12;
            // 
            // lblCedulaSOS
            // 
            this.lblCedulaSOS.AutoSize = true;
            this.lblCedulaSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCedulaSOS.Location = new System.Drawing.Point(6, 790);
            this.lblCedulaSOS.Name = "lblCedulaSOS";
            this.lblCedulaSOS.Size = new System.Drawing.Size(50, 14);
            this.lblCedulaSOS.TabIndex = 53;
            this.lblCedulaSOS.Text = "Cédula*";
            // 
            // txtNombreSOS
            // 
            this.txtNombreSOS.Location = new System.Drawing.Point(6, 758);
            this.txtNombreSOS.Name = "txtNombreSOS";
            this.txtNombreSOS.Size = new System.Drawing.Size(261, 20);
            this.txtNombreSOS.TabIndex = 11;
            // 
            // lblNombreSOS
            // 
            this.lblNombreSOS.AutoSize = true;
            this.lblNombreSOS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNombreSOS.Location = new System.Drawing.Point(6, 741);
            this.lblNombreSOS.Name = "lblNombreSOS";
            this.lblNombreSOS.Size = new System.Drawing.Size(57, 14);
            this.lblNombreSOS.TabIndex = 51;
            this.lblNombreSOS.Text = "Nombre*";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo2.Location = new System.Drawing.Point(6, 716);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(163, 16);
            this.lblTitulo2.TabIndex = 50;
            this.lblTitulo2.Text = "CONTACTO EMERGENCIA:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 621);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(261, 62);
            this.txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDireccion.Location = new System.Drawing.Point(6, 604);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 14);
            this.lblDireccion.TabIndex = 48;
            this.lblDireccion.Text = "Dirección*";
            // 
            // txtSangre
            // 
            this.txtSangre.Location = new System.Drawing.Point(6, 572);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(261, 20);
            this.txtSangre.TabIndex = 9;
            // 
            // lblSangre
            // 
            this.lblSangre.AutoSize = true;
            this.lblSangre.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblSangre.Location = new System.Drawing.Point(6, 555);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(80, 14);
            this.lblSangre.TabIndex = 46;
            this.lblSangre.Text = "Tipo Sangre*";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTelefono.Location = new System.Drawing.Point(144, 506);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(123, 14);
            this.lblTelefono.TabIndex = 45;
            this.lblTelefono.Text = "Teléfono Residencia*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(147, 523);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(6, 523);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCelular.Location = new System.Drawing.Point(6, 506);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(102, 14);
            this.lblCelular.TabIndex = 42;
            this.lblCelular.Text = "Teléfono Celular*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 474);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblEmail.Location = new System.Drawing.Point(6, 457);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 14);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email*";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(6, 425);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(261, 20);
            this.txtNacionalidad.TabIndex = 5;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNacionalidad.Location = new System.Drawing.Point(6, 408);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(80, 14);
            this.lblNacionalidad.TabIndex = 38;
            this.lblNacionalidad.Text = "Nacionalidad*";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 355);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(110, 14);
            this.lblFechaNacimiento.TabIndex = 37;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento*";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "",
            "Femenino",
            "Masculino",
            "Otro"});
            this.cbGenero.Location = new System.Drawing.Point(6, 322);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(261, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblGenero.Location = new System.Drawing.Point(6, 305);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(54, 14);
            this.lblGenero.TabIndex = 35;
            this.lblGenero.Text = "Género*";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(6, 272);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(261, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCedula.Location = new System.Drawing.Point(6, 255);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 14);
            this.lblCedula.TabIndex = 33;
            this.lblCedula.Text = "Cédula*";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "",
            "Boxeo Recreativo",
            "Boxeo Competitivo",
            "Acondicionamiento Fisico"});
            this.cbCategoria.Location = new System.Drawing.Point(6, 173);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(261, 21);
            this.cbCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCategoria.Location = new System.Drawing.Point(6, 156);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 14);
            this.lblCategoria.TabIndex = 31;
            this.lblCategoria.Text = "Categoría*";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(6, 372);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(261, 20);
            this.dtFechaNacimiento.TabIndex = 4;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(3, 107);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(91, 14);
            this.lblFechaIngreso.TabIndex = 28;
            this.lblFechaIngreso.Text = "Fecha Ingreso*";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 223);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblNombre.Location = new System.Drawing.Point(6, 206);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 14);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre*";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo1.Location = new System.Drawing.Point(6, 82);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(161, 16);
            this.lblTitulo1.TabIndex = 25;
            this.lblTitulo1.Text = "INFORMACIÓN GENERAL:";
            // 
            // lblComent
            // 
            this.lblComent.AutoSize = true;
            this.lblComent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblComent.Location = new System.Drawing.Point(16, 44);
            this.lblComent.Name = "lblComent";
            this.lblComent.Size = new System.Drawing.Size(177, 13);
            this.lblComent.TabIndex = 24;
            this.lblComent.Text = "Los campos con (*) son obligatorios";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.lblForm.Location = new System.Drawing.Point(15, 20);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(85, 24);
            this.lblForm.TabIndex = 1;
            this.lblForm.Text = "Formulario";
            // 
            // errorProviderParticular
            // 
            this.errorProviderParticular.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderParticular.ContainerControl = this;
            // 
            // errorProviderSangre
            // 
            this.errorProviderSangre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSangre.ContainerControl = this;
            // 
            // errorProviderDireccion
            // 
            this.errorProviderDireccion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDireccion.ContainerControl = this;
            // 
            // errorProviderNombreCE
            // 
            this.errorProviderNombreCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNombreCE.ContainerControl = this;
            // 
            // errorProviderIdCE
            // 
            this.errorProviderIdCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderIdCE.ContainerControl = this;
            // 
            // errorProviderFecNacCE
            // 
            this.errorProviderFecNacCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFecNacCE.ContainerControl = this;
            // 
            // errorProviderNacionalidadCE
            // 
            this.errorProviderNacionalidadCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNacionalidadCE.ContainerControl = this;
            // 
            // errorProviderEmailCE
            // 
            this.errorProviderEmailCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmailCE.ContainerControl = this;
            // 
            // errorProviderCelularCE
            // 
            this.errorProviderCelularCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCelularCE.ContainerControl = this;
            // 
            // errorProviderParticularCE
            // 
            this.errorProviderParticularCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderParticularCE.ContainerControl = this;
            // 
            // errorProviderGeneroCE
            // 
            this.errorProviderGeneroCE.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderGeneroCE.ContainerControl = this;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1118, 649);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelAddEdit);
            this.Controls.Add(this.panel1);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecNac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCelular)).EndInit();
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParticular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSangre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombreCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFecNacCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidadCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmailCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCelularCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderParticularCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGeneroCE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.ErrorProvider errorProviderIngreso;
        private System.Windows.Forms.ErrorProvider errorProviderCategoria;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderId;
        private System.Windows.Forms.ErrorProvider errorProviderGenero;
        private System.Windows.Forms.ErrorProvider errorProviderFecNac;
        private System.Windows.Forms.ErrorProvider errorProviderNacionalidad;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.Panel panelAddEdit;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrarFormulario;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label lblComent;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtSangre;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTelefonoSOS;
        private System.Windows.Forms.MaskedTextBox txtTelefonoSOS;
        private System.Windows.Forms.MaskedTextBox txtCelularSOS;
        private System.Windows.Forms.Label lblCelularSOS;
        private System.Windows.Forms.TextBox txtEmailSOS;
        private System.Windows.Forms.Label lblEmailSOS;
        private System.Windows.Forms.TextBox txtNacionalidadSOS;
        private System.Windows.Forms.Label lblNacionalidadSOS;
        private System.Windows.Forms.DateTimePicker dtFechaNacSOS;
        private System.Windows.Forms.Label lblFechaNacSOS;
        private System.Windows.Forms.ComboBox cbGeneroSOS;
        private System.Windows.Forms.Label lblGeneroSOS;
        private System.Windows.Forms.MaskedTextBox txtCedulaSOS;
        private System.Windows.Forms.Label lblCedulaSOS;
        private System.Windows.Forms.TextBox txtNombreSOS;
        private System.Windows.Forms.Label lblNombreSOS;
        private FontAwesome.Sharp.IconButton btnPeleas;
        private FontAwesome.Sharp.IconButton btnFichaTecnica;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProviderCelular;
        private System.Windows.Forms.ErrorProvider errorProviderParticular;
        private System.Windows.Forms.ErrorProvider errorProviderSangre;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderNombreCE;
        private System.Windows.Forms.ErrorProvider errorProviderIdCE;
        private System.Windows.Forms.ErrorProvider errorProviderFecNacCE;
        private System.Windows.Forms.ErrorProvider errorProviderNacionalidadCE;
        private System.Windows.Forms.ErrorProvider errorProviderEmailCE;
        private System.Windows.Forms.ErrorProvider errorProviderCelularCE;
        private System.Windows.Forms.ErrorProvider errorProviderParticularCE;
        private System.Windows.Forms.ErrorProvider errorProviderGeneroCE;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}