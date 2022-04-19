using System;
using System.Collections.Generic;
using Entity;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Peleas : Form
    {
        public Peleas()
        {
            InitializeComponent();
        }

        private void Peleas_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = NAME;
                lblIdAtleta.Text = ID;
                LimpiarErrorProviders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ID;
        private string NAME;
        public Peleas(string ID, string NAME) : this()
        {
            this.ID = ID;
            this.NAME = NAME;
        }

        public bool ValidacionFormulario()
        {
            var errors = new List<bool>();

            errors.Add(ErrorProviderHelper(dtFechaPelea, errorProviderFecha));
            errors.Add(ErrorProviderHelper(txtContrincante, errorProviderContrincante));
            errors.Add(ErrorProviderHelper(txtDescripcion, errorProviderDescripcion));
            errors.Add(ErrorProviderHelper(txtDecision, errorProviderDecision));

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

        private void LimpiarErrorProviders()
        {
            errorProviderFecha.Clear();
            errorProviderContrincante.Clear();
            errorProviderDescripcion.Clear();
            errorProviderDecision.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var entity = new PeleasEntity
                    {
                        Nombre = txtNombre.Text,
                        IdAtleta = int.Parse(lblIdAtleta.Text),
                        Fecha = dtFechaPelea.Value,
                        Contrincante = txtContrincante.Text,
                        Descripcion = txtDescripcion.Text,
                        Decision = txtDecision.Text,
                        Observaciones = txtObservacion.Text
                    };

                    var result = new BDEntity();
                    //CREATE
                    var bitacora = new BitacorasEntity
                    {
                        Usuario = MenuPrincipal.nombreUsuario,
                        Registro = DateTime.Now,
                        Accion = ("CREACION DE REGISTRO DE PELEA PARA CLIENTE: " + lblIdAtleta.Text + " - " + txtNombre.Text + ".").ToUpper()
                    };
                    IApp.bitacorasService.Create(bitacora);
                    result = IApp.peleasService.Create(entity);

                    if (result.CodeError == 0) MessageBox.Show("El registro se insertó correctamente");

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
