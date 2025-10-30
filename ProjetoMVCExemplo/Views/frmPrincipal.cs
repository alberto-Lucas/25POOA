using System;
using System.Windows.Forms;

namespace ProjetoMVCExemplo.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioSelecao frm = new frmUsuarioSelecao();
            frm.ShowDialog();
        }
    }
}
