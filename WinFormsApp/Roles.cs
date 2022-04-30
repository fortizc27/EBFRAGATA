using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
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
                    chbHabilitar.Enabled = true;
                    if (IdSelected == 1 || IdSelected == MenuPrincipal.rolusuario)
                    {
                        chbHabilitar.Enabled = false;
                    }
                    var result = IApp.rolesService.GetById(new RolesEntity()
                    {
                        IdRol = IdSelected
                    });

                    lblRolId.Text = result.IdRol.ToString();
                    txtRol.Text = result.NombreRol.ToString();
                    chbAcceso.SetItemChecked(0, result.Usuarios);
                    chbAcceso.SetItemChecked(1, result.Roles);
                    chbAcceso.SetItemChecked(2, result.Clientes);
                    chbAcceso.SetItemChecked(3, result.FichasTecnicas);
                    chbAcceso.SetItemChecked(4, result.Peleas);
                    chbAcceso.SetItemChecked(5, result.Reportes);
                    chbAcceso.SetItemChecked(6, result.Bitacoras);
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
                    if (IdSelected == 1 || IdSelected == MenuPrincipal.rolusuario)
                    {
                        MessageBox.Show("No se puede eliminar este rol.");
                    }
                    else
                    {
                        //Verifica si en realidad queremos eliminar este rol
                        if (DialogResult.Yes == MessageBox.Show("¿Estás seguro de eliminar este rol?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            var result = IApp.rolesService.Delete(new RolesEntity()
                            {
                                IdRol = IdSelected
                            });

                            if (result.CodeError == 0)
                            {
                                var bitacora = new BitacorasEntity
                                {
                                    Usuario = MenuPrincipal.nombreUsuario,
                                    Registro = DateTime.Now,
                                    Accion = ("ELIMINACION DE ROL: " + IdSelected.ToString() + ".").ToUpper()
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

                    bool [] acceso = new bool[7];
                    
                    for (int i = 0; i < chbAcceso.Items.Count; i++)
                    {
                        if(chbAcceso.GetItemCheckState(i) == 0)
                        {
                            acceso[i] = false;
                        }
                        else
                        {
                            acceso[i] = true;
                        }
                    }
                    
                    var RolId = string.IsNullOrEmpty(lblRolId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(lblRolId.Text);//Editar

                    var entity = new RolesEntity
                    {
                        IdRol = RolId,
                        NombreRol = txtRol.Text,
                        Usuarios = acceso[0],
                        Roles = acceso[1],
                        Clientes = acceso[2],
                        FichasTecnicas = acceso[3],
                        Peleas = acceso[4],
                        Reportes = acceso[5],
                        Bitacoras = acceso[6],
                        Estado = chbHabilitar.Checked
                    };



                    var result = new BDEntity();
                    if (RolId != null)
                    {

                        var bitacora = new BitacorasEntity
                        {
                            Usuario = MenuPrincipal.nombreUsuario,
                            Registro = DateTime.Now,
                            Accion = ("ACTUALIZACION DE ROL: " + txtRol.Text + ".").ToUpper()
                        };

                        IApp.bitacorasService.Create(bitacora);
                        //Actualización
                        result = IApp.rolesService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        var bitacora = new BitacorasEntity
                        {
                            Usuario = MenuPrincipal.nombreUsuario,
                            Registro = DateTime.Now,
                            Accion = ("CREACION DE ROL: " + txtRol.Text + ".").ToUpper()
                        };

                        IApp.bitacorasService.Create(bitacora);
                        result = IApp.rolesService.Create(entity);

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
        
        public bool ValidacionFormulario()
        {
            var errors = new List<bool>();

            errors.Add(ErrorProviderHelper(txtRol, errorProviderNombre));

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
                dgRoles.AutoGenerateColumns = false;
                dgRoles.DataSource = IApp.rolesService.Get();
                lblNum.Text = dgRoles.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarDatos()
        {
            lblRolId.Text = null;
            txtRol.Text = null;
            for (int i = 0; i < chbAcceso.Items.Count; i++)
            {
                chbAcceso.SetItemChecked(i, false);
            }
            chbHabilitar.Checked = false;
        }

        private void LimpiarErrorProviders()
        {
            errorProviderNombre.Clear();
        }

        public int? GetSelectedRowGrid()
        {
            if (dgRoles.SelectedRows.Count > 0)
            {
                var row = dgRoles.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdRol"].Value);
            }
            else
            {
                return null; 
            }
        }
    }
}
