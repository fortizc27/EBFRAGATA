using System;
using System.Windows.Forms;
using Entity;

namespace WinFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginProccess()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("El campo de usuario es obligatorio", "Campo Mandatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtClave.Text))
                {
                    MessageBox.Show("El campo de contraseña es obligatorio", "Campo Mandatorio", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                var result = IApp.usuariosService.Login(new UsuariosEntity
                {
                    Usuario = txtUsuario.Text,
                    Clave = txtClave.Text
                });

                if (result !=null)
                {
                    var bitacora = new BitacorasEntity
                    {
                        Usuario = txtUsuario.Text,
                        Registro = DateTime.Now,
                        Accion = "LOGIN."
                    };

                    if (result.CodeError == 0)
                    {
                        var usuario = IApp.usuariosService.GetById(new UsuariosEntity
                        {
                            Usuario = txtUsuario.Text
                        });
                        //Escribe en bitacora
                        IApp.bitacorasService.Create(bitacora);
                        this.Hide();
                        var MenuPrincipal = new MenuPrincipal(txtUsuario.Text, result.Rol);
                        MenuPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show(result.MsgError);
                    }
                }
                else
                {
                    if (MessageBox.Show("No hay conexion de BD. ¿Desea modificar la conexion?", "BD ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBConnection dBConnection = new DBConnection();
                        dBConnection.ShowDialog();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginProccess();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginProccess();
            }
        }
    }
}
