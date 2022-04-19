using System;
using System.Collections.Generic;
using Entity;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FichaTecnica : Form
    {
        public FichaTecnica()
        {
            InitializeComponent();
        }

        private void FichaTecnica_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombre.Text = NAME ;
                txtCedula.Text = ID;
                LimpiarErrorProviders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ID;
        private string NAME;
        private string lateralidad;

        public FichaTecnica(string ID, string NAME) : this()
        {
            this.ID = ID;
            this.NAME = NAME;
        }

        public bool ValidacionFormulario()
        {
            var errors = new List<bool>();

            errors.Add(ErrorProviderHelper(txtPadecimiento, errorProviderPadecimientos));

            //VALIDACION DE LOS CAMPOS
            foreach (var item in errors)
            {
                if (item == false)
                {
                    return false;
                }
            }

            if (cbLateralidad.SelectedItem == null)
            {
                lateralidad = "N/A";
            }
            else
            {
                lateralidad = cbLateralidad.SelectedItem.ToString();
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
            errorProviderPadecimientos.Clear();
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
                    var entity = new FichasTecEntity
                    {
                        Fecha = dtFecha.Value,
                        Nombre = txtNombre.Text,
                        IdAtleta = int.Parse(txtCedula.Text),
                        Padecimientos = txtPadecimiento.Text.ToString(),
                        Peso = numPeso.Value,
                        Altura = numAltura.Value,
                        Lateralidad = lateralidad,
                        Alcance = numAlcance.Value,
                        Talla = txtTalla.Text,
                        Pecho = numPecho.Value,
                        Abdomen = numAbdomen.Value,
                        Gluteo = numGluteo.Value,
                        BicepD = numBicepDer.Value,
                        BicepI = numBicepIzq.Value,
                        MusloD = numMusloDer.Value,
                        MusloI = numMusloIzq.Value,
                        PantorrillaD = numPantDer.Value,
                        PantorrillaI = numPantIzq.Value
                    };

                    var result = new BDEntity();
                    //CREATE
                    var bitacora = new BitacorasEntity
                    {
                        Usuario = MenuPrincipal.nombreUsuario,
                        Registro = DateTime.Now,
                        Accion = ("CREACION DE FICHA TECNICA PARA CLIENTE: " + txtCedula.Text + " - " + txtNombre.Text + ".").ToUpper()
                    };
                    IApp.bitacorasService.Create(bitacora);
                    result = IApp.fichasTecService.Create(entity);

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
