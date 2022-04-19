using System;
using System.Windows.Forms;
using Entity;

namespace WinFormsApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string nombreUsuario, int rol) : this()
        {
            MenuPrincipal.nombreUsuario = nombreUsuario;
            MenuPrincipal.rolusuario = rol;
        }

        public static string nombreUsuario;
        public static int rolusuario;

        public Form CurrentForm { get; set; }

        private void AbrirFormPrincipal(Form menuitem)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }

            CurrentForm = menuitem;

            menuitem.TopLevel = false;
            menuitem.FormBorderStyle = FormBorderStyle.None;
            menuitem.Dock = DockStyle.Fill;

            pp4.Controls.Add(menuitem);
            pp4.Tag = menuitem;

            menuitem.BringToFront();
            menuitem.Show();

            lblVentana.Text = menuitem.Text;

            if (menuitem.Text == "PANEL PRINCIPAL")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.Home;
            }
            else if(menuitem.Text == "CLIENTES")    
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.Running;
            }
            else if (menuitem.Text == "USUARIOS")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            }
            else if (menuitem.Text == "ROLES")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.Lock;
            }
            else if (menuitem.Text == "REPORTES")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.Paste;
            }
            else if (menuitem.Text == "AYUDA")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.Question;
            }
            else if (menuitem.Text == "ACERCA DE")
            {
                iconVentana.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            }
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                var result = IApp.rolesService.GetById(new RolesEntity()
                {
                    IdRol = MenuPrincipal.rolusuario
                });

                btnClientes.Visible = result.Clientes;
                btnUsuarios.Visible = result.Usuarios;
                btnRoles.Visible = result.Roles;
                if (result.Bitacoras == true || result.Reportes == true)
                {
                    btnReportes.Visible = true;
                }
                else { btnReportes.Visible = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPanelPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new PanelPrincipal());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Clientes());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new PanelPrincipal());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new AcercaDe());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Reportes());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var entity = new BitacorasEntity
            {
                Usuario = MenuPrincipal.nombreUsuario,
                Registro = DateTime.Now,
                Accion = "LOGOUT."
            };

            IApp.bitacorasService.Create(entity);

            this.Hide();
            var Login = new Login();
            Login.Show();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Usuarios());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Roles());

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new Ayuda());
        }
    }
}
