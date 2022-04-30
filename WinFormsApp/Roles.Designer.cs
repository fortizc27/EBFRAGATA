
namespace WinFormsApp
{
    partial class Roles
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
            this.lblRoles = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgRoles = new System.Windows.Forms.DataGridView();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarios = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Clientes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FichasTecnicas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Peleas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reportes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bitacoras = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblForm = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.lblHabilitar = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblComent = new System.Windows.Forms.Label();
            this.lblRolId = new System.Windows.Forms.Label();
            this.panelAddEdit = new System.Windows.Forms.Panel();
            this.chbAcceso = new System.Windows.Forms.CheckedListBox();
            this.chbHabilitar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.panelAddEdit.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.lblRoles, 1, 2);
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
            // lblRoles
            // 
            this.lblRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.lblRoles.Location = new System.Drawing.Point(11, 39);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(75, 18);
            this.lblRoles.TabIndex = 1;
            this.lblRoles.Text = "Roles";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.Controls.Add(this.dgRoles, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(801, 590);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dgRoles
            // 
            this.dgRoles.AllowUserToAddRows = false;
            this.dgRoles.AllowUserToDeleteRows = false;
            this.dgRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRoles.ColumnHeadersHeight = 35;
            this.dgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRol,
            this.NombreRol,
            this.Usuarios,
            this.dataGridViewCheckBoxColumn1,
            this.Clientes,
            this.FichasTecnicas,
            this.Peleas,
            this.Reportes,
            this.Bitacoras,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRoles.Location = new System.Drawing.Point(12, 12);
            this.dgRoles.MultiSelect = false;
            this.dgRoles.Name = "dgRoles";
            this.dgRoles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRoles.RowHeadersWidth = 42;
            this.dgRoles.RowTemplate.Height = 25;
            this.dgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoles.Size = new System.Drawing.Size(777, 536);
            this.dgRoles.TabIndex = 3;
            // 
            // IdRol
            // 
            this.IdRol.DataPropertyName = "IdRol";
            this.IdRol.HeaderText = "Id";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Visible = false;
            // 
            // NombreRol
            // 
            this.NombreRol.DataPropertyName = "NombreRol";
            this.NombreRol.HeaderText = "Rol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.Usuarios.DataPropertyName = "Usuarios";
            this.Usuarios.HeaderText = "Usuarios";
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Roles";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Roles";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // Clientes
            // 
            this.Clientes.DataPropertyName = "Clientes";
            this.Clientes.HeaderText = "Clientes";
            this.Clientes.Name = "Clientes";
            this.Clientes.ReadOnly = true;
            // 
            // FichasTecnicas
            // 
            this.FichasTecnicas.DataPropertyName = "FichasTecnicas";
            this.FichasTecnicas.HeaderText = "FichasTecnicas";
            this.FichasTecnicas.Name = "FichasTecnicas";
            this.FichasTecnicas.ReadOnly = true;
            // 
            // Peleas
            // 
            this.Peleas.DataPropertyName = "Peleas";
            this.Peleas.HeaderText = "Peleas";
            this.Peleas.Name = "Peleas";
            this.Peleas.ReadOnly = true;
            // 
            // Reportes
            // 
            this.Reportes.DataPropertyName = "Reportes";
            this.Reportes.HeaderText = "Reportes";
            this.Reportes.Name = "Reportes";
            this.Reportes.ReadOnly = true;
            this.Reportes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reportes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Bitacoras
            // 
            this.Bitacoras.DataPropertyName = "Bitacoras";
            this.Bitacoras.HeaderText = "Bitacoras";
            this.Bitacoras.Name = "Bitacoras";
            this.Bitacoras.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Habilitado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(12, 554);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 33);
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
            this.btnEliminar.Location = new System.Drawing.Point(685, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 25);
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
            this.btnEditar.Location = new System.Drawing.Point(598, 4);
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
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 18;
            this.btnNuevo.Location = new System.Drawing.Point(511, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(81, 25);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNombre.ContainerControl = this;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F);
            this.lblForm.Location = new System.Drawing.Point(14, 19);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(85, 24);
            this.lblForm.TabIndex = 1;
            this.lblForm.Text = "Formulario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblRol.Location = new System.Drawing.Point(17, 69);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(30, 14);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol*";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(17, 84);
            this.txtRol.MaxLength = 250;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(248, 20);
            this.txtRol.TabIndex = 0;
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblAcceso.Location = new System.Drawing.Point(17, 114);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(52, 14);
            this.lblAcceso.TabIndex = 4;
            this.lblAcceso.Text = "Acesso*";
            // 
            // lblHabilitar
            // 
            this.lblHabilitar.AutoSize = true;
            this.lblHabilitar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblHabilitar.Location = new System.Drawing.Point(14, 247);
            this.lblHabilitar.Name = "lblHabilitar";
            this.lblHabilitar.Size = new System.Drawing.Size(66, 14);
            this.lblHabilitar.TabIndex = 6;
            this.lblHabilitar.Text = "Habilitado*";
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
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(123, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 49);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Crimson;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Crimson;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 32;
            this.btnCerrar.Location = new System.Drawing.Point(270, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrarFormulario_Click);
            // 
            // lblComent
            // 
            this.lblComent.AutoSize = true;
            this.lblComent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.lblComent.Location = new System.Drawing.Point(17, 43);
            this.lblComent.Name = "lblComent";
            this.lblComent.Size = new System.Drawing.Size(181, 13);
            this.lblComent.TabIndex = 27;
            this.lblComent.Text = "Los campos con (*) son mandatorios";
            // 
            // lblRolId
            // 
            this.lblRolId.AutoSize = true;
            this.lblRolId.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblRolId.ForeColor = System.Drawing.Color.Red;
            this.lblRolId.Location = new System.Drawing.Point(156, 24);
            this.lblRolId.Name = "lblRolId";
            this.lblRolId.Size = new System.Drawing.Size(0, 14);
            this.lblRolId.TabIndex = 29;
            this.lblRolId.Visible = false;
            // 
            // panelAddEdit
            // 
            this.panelAddEdit.AutoScroll = true;
            this.panelAddEdit.BackColor = System.Drawing.Color.White;
            this.panelAddEdit.Controls.Add(this.chbAcceso);
            this.panelAddEdit.Controls.Add(this.chbHabilitar);
            this.panelAddEdit.Controls.Add(this.lblRolId);
            this.panelAddEdit.Controls.Add(this.lblComent);
            this.panelAddEdit.Controls.Add(this.btnCerrar);
            this.panelAddEdit.Controls.Add(this.btnGuardar);
            this.panelAddEdit.Controls.Add(this.lblHabilitar);
            this.panelAddEdit.Controls.Add(this.lblAcceso);
            this.panelAddEdit.Controls.Add(this.txtRol);
            this.panelAddEdit.Controls.Add(this.lblRol);
            this.panelAddEdit.Controls.Add(this.lblForm);
            this.panelAddEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddEdit.Location = new System.Drawing.Point(801, 59);
            this.panelAddEdit.Name = "panelAddEdit";
            this.panelAddEdit.Size = new System.Drawing.Size(317, 590);
            this.panelAddEdit.TabIndex = 1;
            this.panelAddEdit.Visible = false;
            // 
            // chbAcceso
            // 
            this.chbAcceso.FormattingEnabled = true;
            this.chbAcceso.Items.AddRange(new object[] {
            "Usuarios",
            "Roles",
            "Clientes",
            "FichasTecnicas",
            "Peleas",
            "Reportes",
            "Bitacoras"});
            this.chbAcceso.Location = new System.Drawing.Point(17, 131);
            this.chbAcceso.Name = "chbAcceso";
            this.chbAcceso.Size = new System.Drawing.Size(120, 109);
            this.chbAcceso.TabIndex = 1;
            // 
            // chbHabilitar
            // 
            this.chbHabilitar.AutoSize = true;
            this.chbHabilitar.Location = new System.Drawing.Point(18, 264);
            this.chbHabilitar.Name = "chbHabilitar";
            this.chbHabilitar.Size = new System.Drawing.Size(15, 14);
            this.chbHabilitar.TabIndex = 2;
            this.chbHabilitar.UseVisualStyleBackColor = true;
            // 
            // Roles
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
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROLES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Roles_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoles)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.panelAddEdit.ResumeLayout(false);
            this.panelAddEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgRoles;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.Panel panelAddEdit;
        private System.Windows.Forms.Label lblRolId;
        private System.Windows.Forms.Label lblComent;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label lblHabilitar;
        private System.Windows.Forms.Label lblAcceso;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.CheckBox chbHabilitar;
        private System.Windows.Forms.CheckedListBox chbAcceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Usuarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Clientes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FichasTecnicas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Peleas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reportes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bitacoras;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}