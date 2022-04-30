using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            panelAddEdit.Visible = false;
            CargarDatos();
        }

        private void btnCerrarFormulario_Click(object sender, EventArgs e)
        {
            panelAddEdit.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            LimpiarErrorProviders();
            panelAddEdit.Visible = true;
            btnFichaTecnica.Visible = false;
            btnPeleas.Visible = false;
            lblClienteId.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
                LimpiarErrorProviders();

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.clientesService.GetById(new ClientesEntity()
                    {
                        IdCliente = IdSelected
                    });

                    var rol = IApp.rolesService.GetById(new RolesEntity()
                    {
                        IdRol = MenuPrincipal.rolusuario
                    });

                    lblClienteId.Text = result.IdCliente.ToString();
                    dtIngreso.Value = result.Fecha;
                    cbCategoria.SelectedItem = result.Categoria.ToString();
                    txtNombre.Text = result.Nombre.ToString();
                    txtCedula.Text = result.IdCliente.ToString();
                    cbGenero.SelectedItem = result.Genero.ToString();
                    dtFechaNacimiento.Value = result.FechaNac;
                    txtNacionalidad.Text = result.Nacionalidad.ToString();
                    txtEmail.Text = result.Correo.ToString();
                    txtCelular.Text = result.Celular.ToString();
                    txtTelefono.Text = result.Particular.ToString();
                    txtSangre.Text = result.Sangre.ToString();
                    txtDireccion.Text = result.Direccion.ToString();
                    txtNombreSOS.Text = result.NombreCE.ToString();
                    txtCedulaSOS.Text = result.IdCE.ToString();
                    cbGeneroSOS.SelectedItem = result.GeneroCE.ToString();
                    dtFechaNacSOS.Value = result.FechaNacCE;
                    txtNacionalidadSOS.Text = result.NacionalidadCE.ToString();
                    txtEmailSOS.Text = result.CorreoCE.ToString();
                    txtCelularSOS.Text = result.CelularCE.ToString();
                    txtTelefonoSOS.Text = result.ParticularCE.ToString();

                    panelAddEdit.Visible = true;
                    btnFichaTecnica.Visible = rol.FichasTecnicas;
                    btnPeleas.Visible = rol.Peleas;
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();

                panelAddEdit.Visible = false;

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    //VALIDACION SOBRE LA ELIMINACION DEL CLIENTE
                    if (DialogResult.Yes == MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        var result = IApp.clientesService.Delete(new ClientesEntity()
                        {
                            IdCliente = IdSelected
                        });

                        if (result.CodeError == 0)
                        {
                            var bitacora = new BitacorasEntity
                            {
                                Usuario = MenuPrincipal.nombreUsuario,
                                Registro = DateTime.Now,
                                Accion = ("ELIMINACION DE CLIENTE: " + IdSelected.ToString() + ".").ToUpper()
                            };

                            IApp.bitacorasService.Create(bitacora);
                            MessageBox.Show("El registro se elimino correctamente");
                            CargarDatos();
                        }
                        else if (result.CodeError == 547)
                        {
                            MessageBox.Show("El cliente posee algun registro guardado. No se puede eliminar.");
                        }
                        else
                        {
                            throw new Exception(result.MsgError);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var ClienteId = string.IsNullOrEmpty(lblClienteId.Text)
                                          ? (int?)null //INSERT
                                          : Convert.ToInt32(lblClienteId.Text);//EDIT
                    
                    var entity = new ClientesEntity
                    {
                        Fecha = DateTime.Now,
                        Categoria = cbCategoria.SelectedItem.ToString(),
                        Nombre = txtNombre.Text,
                        IdCliente = int.Parse(txtCedula.Text),
                        Genero = cbGenero.SelectedItem.ToString(),
                        FechaNac = dtFechaNacimiento.Value,
                        Nacionalidad = txtNacionalidad.Text,
                        Correo = txtEmail.Text,
                        Celular = int.Parse(txtCelular.Text),
                        Particular = int.Parse(txtTelefono.Text),
                        Sangre = txtSangre.Text,
                        Direccion = txtDireccion.Text,
                        NombreCE = txtNombreSOS.Text,
                        IdCE = int.Parse(txtCedulaSOS.Text),
                        GeneroCE = cbGeneroSOS.SelectedItem.ToString(),
                        FechaNacCE = dtFechaNacSOS.Value,
                        NacionalidadCE = txtNacionalidadSOS.Text,
                        CorreoCE = txtEmailSOS.Text,
                        CelularCE = int.Parse(txtCelularSOS.Text),
                        ParticularCE = int.Parse(txtTelefonoSOS.Text)
                    };

                    var result = new BDEntity();
                    if (ClienteId != null)
                    {
                        //UPDATE
                        var bitacora = new BitacorasEntity
                        {
                            Usuario = MenuPrincipal.nombreUsuario,
                            Registro = DateTime.Now,
                            Accion = ("ACTUALIZACION DE CLIENTE: " + txtCedula.Text + " - " + txtNombre.Text + ".").ToUpper()
                        };
                        IApp.bitacorasService.Create(bitacora);
                        result = IApp.clientesService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        //CREATE
                        var bitacora = new BitacorasEntity
                        {
                            Usuario = MenuPrincipal.nombreUsuario,
                            Registro = DateTime.Now,
                            Accion = ("CREACION DE CLIENTE: " + txtCedula.Text + " - " + txtNombre.Text + ".").ToUpper()
                        };
                        IApp.bitacorasService.Create(bitacora);
                        result = IApp.clientesService.Create(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se insertó correctamente");

                    }

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    LimpiarDatos();
                    CargarDatos();
                    panelAddEdit.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFichaTecnica_Click(object sender, EventArgs e)
        {
            var fichaTecnica = new FichaTecnica(txtCedula.Text,txtNombre.Text);
            fichaTecnica.ShowDialog();
        }

        private void btnPeleas_Click(object sender, EventArgs e)
        {
            var peleas = new Peleas(txtCedula.Text, txtNombre.Text);
            peleas.ShowDialog();
        }

        public bool ValidacionFormulario()
        {
            var errors = new List<bool>();

            errors.Add(ErrorProviderHelper(dtIngreso, errorProviderIngreso));
            errors.Add(ErrorProviderHelper(cbCategoria, errorProviderCategoria));
            errors.Add(ErrorProviderHelper(txtNombre, errorProviderNombre));
            errors.Add(ErrorProviderHelper(txtCedula, errorProviderId));
            errors.Add(ErrorProviderHelper(cbGenero, errorProviderGenero));
            errors.Add(ErrorProviderHelper(dtFechaNacimiento, errorProviderFecNac));
            errors.Add(ErrorProviderHelper(txtNacionalidad, errorProviderNacionalidad));
            errors.Add(ErrorProviderHelper(txtEmail, errorProviderEmail));
            errors.Add(ErrorProviderHelper(txtCelular, errorProviderCelular));
            errors.Add(ErrorProviderHelper(txtTelefono, errorProviderParticular));
            errors.Add(ErrorProviderHelper(txtSangre, errorProviderSangre));
            errors.Add(ErrorProviderHelper(txtDireccion, errorProviderDireccion));
            errors.Add(ErrorProviderHelper(txtNombreSOS, errorProviderNombreCE));
            errors.Add(ErrorProviderHelper(txtCedulaSOS, errorProviderIdCE));
            errors.Add(ErrorProviderHelper(cbGeneroSOS, errorProviderGeneroCE));
            errors.Add(ErrorProviderHelper(dtFechaNacSOS, errorProviderFecNacCE));
            errors.Add(ErrorProviderHelper(txtNacionalidadSOS, errorProviderNacionalidadCE));
            errors.Add(ErrorProviderHelper(txtEmailSOS, errorProviderEmailCE));
            errors.Add(ErrorProviderHelper(txtCelularSOS, errorProviderCelularCE));
            errors.Add(ErrorProviderHelper(txtTelefonoSOS, errorProviderParticularCE));

            //VALIDACION DE LOS CAMPOS
            foreach (var item in errors)
            {
                if (item == false)
                {
                    return false;
                }
            }

            return true;
        }

        private bool ErrorProviderHelper(Control cntrlToValidate, ErrorProvider errorProvider)
        {
            MaskedTextBox mskTemp = cntrlToValidate as MaskedTextBox;

            //VALIDACION DE MASKED TEXT BOX
            if (mskTemp != null)
            {
                if (!mskTemp.MaskCompleted)
                {
                    errorProvider.SetError(cntrlToValidate, "Campo Obligatorio");
                    return false;
                }
                if (string.IsNullOrEmpty(mskTemp.Text))
                {
                    errorProvider.SetError(cntrlToValidate, "Campo Obligatorio");
                    return false;
                }
                else
                {
                    errorProvider.Clear();
                    return true;
                }

            }
            
            //VALIDACION DE OTROS CAMPOS
            if (string.IsNullOrEmpty(cntrlToValidate.Text))
            {
                errorProvider.SetError(cntrlToValidate, "Campo Obligatorio");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }


        public void CargarDatos()
        {
            try
            {
                dgClientes.AutoGenerateColumns = false;
                dgClientes.DataSource = IApp.clientesService.Get();
                lblNum.Text = dgClientes.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarDatos()
        {
            dtIngreso.Value = DateTime.Now;
            cbCategoria.SelectedIndex = 0;
            txtNombre.Text = null;
            txtCedula.Text = null;
            cbGenero.SelectedIndex = 0;
            dtFechaNacimiento.Text = null;
            txtNacionalidad.Text = null;
            txtEmail.Text = null;
            txtCelular.Text = null;
            txtTelefono.Text = null;
            txtSangre.Text = null;
            txtDireccion.Text = null;
            txtNombreSOS.Text = null;
            txtCedulaSOS.Text = null;
            cbGeneroSOS.SelectedIndex = 0;
            dtFechaNacSOS.Text = null;
            txtNacionalidadSOS.Text = null;
            txtEmailSOS.Text = null;
            txtCelularSOS.Text = null;
            txtTelefonoSOS.Text = null;
        }

        private void LimpiarErrorProviders()
        {
            errorProviderIngreso.Clear();
            errorProviderCategoria.Clear();
            errorProviderNombre.Clear();
            errorProviderId.Clear();
            errorProviderGenero.Clear();
            errorProviderFecNac.Clear();
            errorProviderNacionalidad.Clear();
            errorProviderEmail.Clear();
            errorProviderCelular.Clear();
            errorProviderParticular.Clear();
            errorProviderSangre.Clear();
            errorProviderDireccion.Clear();
            errorProviderNombreCE.Clear();
            errorProviderIdCE.Clear();
            errorProviderGeneroCE.Clear();
            errorProviderFecNacCE.Clear();
            errorProviderNacionalidadCE.Clear();
            errorProviderEmailCE.Clear();
            errorProviderCelularCE.Clear();
            errorProviderParticularCE.Clear();
        }

        public int? GetSelectedRowGrid()
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                var row = dgClientes.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdCliente"].Value);
            }
            else
            {
                return null; 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelAddEdit.Visible = false;
        }
    }
}
