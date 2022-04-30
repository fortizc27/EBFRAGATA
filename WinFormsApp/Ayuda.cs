using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            DocManual.LoadFile("C:/Program Files/FRAGATA/EBF/Manual de usuario - EBFRAGATA.pdf");
        }
    }
}
