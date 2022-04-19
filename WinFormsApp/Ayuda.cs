using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            DocManual.LoadFile("Manual de usuario - EBFRAGATA.pdf");
        }
    }
}
