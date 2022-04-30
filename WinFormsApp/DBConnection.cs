using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class DBConnection : Form
    {
        public DBConnection()
        {
            InitializeComponent();
        }

        Configuration config;

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (IApp.usuariosService.Connection($"Data Source = {txtServer.Text}; Initial Catalog = {txtInitialCatalog.Text}; User ID=sa; Password=M4n4g3r01; Column Encryption Setting = Enabled;"))
                {
                    MessageBox.Show("Conexion establecida.");
                }
                else
                {
                    MessageBox.Show("Conexion no establecida.");
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
                config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["Conn"].Value = ($"Data Source = {txtServer.Text}; Initial Catalog = {txtInitialCatalog.Text}; User ID=sa; Password=M4n4g3r01; Column Encryption Setting = Enabled;");
                config.Save(ConfigurationSaveMode.Full,true);
                ConfigurationManager.RefreshSection("appSettings");

                MessageBox.Show("Conexion exitosa.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible guardar la conexion. \n" + ex.Message);
            }
        }
    }
}
