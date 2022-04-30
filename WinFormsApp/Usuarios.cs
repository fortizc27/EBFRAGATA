using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
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
                    var result = IApp.usuariosService.GetById(new UsuariosEntity()
                    {
                        IdUsuario = IdSelected
                    });

                    chbHabilitar.Enabled = true;
                    if (IdSelected == 1 || result.Usuario == MenuPrincipal.nombreUsuario)
                    {
                        chbHabilitar.Enabled = false;
                    }

                    lblUsuarioId.Text = result.IdUsuario.ToString();
                    txtUsuario.Text = result.Usuario.ToString();
                    txtClave.Text = result.Clave.ToString();
                    txtConfClave.Text = result.Clave.ToString();
                    cbRol.SelectedValue = result.Rol;
                    chbHabilitar.Checked = result.Estado;

                    panelAddEdit.Visible = true;
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
                    if (IdSelected == 1)
                    {
                        MessageBox.Show("No se puede eliminar este usuario.");
                    }
                    else
                    {
                        //Verifica si en realidad queremos eliminar este usuario
                        if (DialogResult.Yes == MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            var result = IApp.usuariosService.Delete(new UsuariosEntity()
                            {
                                IdUsuario = IdSelected
                            });

                            if (result.CodeError == 0)
                            {
                                var bitacora = new BitacorasEntity
                                {
                                    Usuario = MenuPrincipal.nombreUsuario,
                                    Registro = DateTime.Now,
                                    Accion = ("ELIMINACION DE USUARIO: " + IdSelected.ToString() + ".").ToUpper()
                                };

                                IApp.bitacorasService.Create(bitacora);
                                MessageBox.Show("El registro se elimino correctamente");
                                CargarDatos();
                            }
                            else
                            {
                                throw new Exception(result.MsgError);
                            }
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
                    if (txtClave.Text != txtConfClave.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                    }
                    else
                    {
                        var UsuarioId = string.IsNullOrEmpty(lblUsuarioId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(lblUsuarioId.Text);//Editar

                        var entity = new UsuariosEntity
                        {
                            IdUsuario = UsuarioId,
                            Usuario = txtUsuario.Text,
                            Clave = txtClave.Text,
                            Rol = Convert.ToInt32(cbRol.SelectedValue),
                            Estado = chbHabilitar.Checked
                        };



                        var result = new BDEntity();
                        if (UsuarioId != null)
                        {

                            var bitacora = new BitacorasEntity
                            {
                                Usuario = MenuPrincipal.nombreUsuario,
                                Registro = DateTime.Now,
                                Accion = ("ACTUALIZACION DE USUARIO: " + txtUsuario.Text + ".").ToUpper()
                            };

                            IApp.bitacorasService.Create(bitacora);
                            //Actualización
                            result = IApp.usuariosService.Update(entity);

                            if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                        }
                        else
                        {
                            var bitacora = new BitacorasEntity
                            {
                                Usuario = MenuPrincipal.nombreUsuario,
                                Registro = DateTime.Now,
                                Accion = ("CREACION DE USUARIO: " + txtUsuario.Text + ".").ToUpper()
                            };

                            IApp.bitacorasService.Create(bitacora);
                            result = IApp.usuariosService.Create(entity);

                            if (result.CodeError == 0) MessageBox.Show("El registro se insertó correctamente");

                        }

                        if (result.CodeError != 0) throw new Exception(result.MsgError);

                        LimpiarDatos();
                        CargarDatos();
                        panelAddEdit.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public bool ValidacionFormulario()
        {
            var errors = new List<bool>();

            errors.Add(ErrorProviderHelper(txtUsuario, errorProviderUsuario));
            errors.Add(ErrorProviderHelper(txtClave, errorProviderClave));
            errors.Add(ErrorProviderHelper(txtConfClave, errorProviderConfClave));
            errors.Add(ErrorProviderHelper(cbRol, errorProviderRol));

            //Detecta si algun campo se encuentra en blanco
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

            //Si el control es Masked Text Box, indicar el character que define el mask
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
            
            //Validacion para cualquier otro control (Textbox, Combobox, etc.)
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
                dgUsuarios.AutoGenerateColumns = false;
                dgUsuarios.DataSource = IApp.usuariosService.Get();
                lblNum.Text = dgUsuarios.Rows.Count.ToString();
                CargaCbs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargaCbs()
        {
            try
            {
                cbRol.DisplayMember = "NombreRol";
                cbRol.ValueMember = "IdRol";

                cbRol.DataSource = IApp.rolesService.GetLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarDatos()
        {
            lblUsuarioId.Text = null;
            txtUsuario.Text = null;
            txtClave.Text = null;
            txtConfClave.Text = null;
            chbHabilitar.Checked = false;
        }

        private void LimpiarErrorProviders()
        {
            errorProviderUsuario.Clear();
            errorProviderClave.Clear();
            errorProviderConfClave.Clear();
            errorProviderRol.Clear();
        }

        public int? GetSelectedRowGrid()
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                var row = dgUsuarios.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdUsuario"].Value);
            }
            else
            {
                return null; 
            }
        }
    }
}
