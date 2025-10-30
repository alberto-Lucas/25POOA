using ProjetoExemploCerto.Controllers;
using System.Windows.Forms;

namespace ProjetoExemploCerto.Views
{
    public partial class frmUsuarioSelecao : Form
    {
        //Importar camadas Models e Controllers
        //using Nome_Porjeto.Models;
        //using Nome_Porjeto.Controllers;

        //Cirar instancia com a controller
        UsuarioController usuarioController = new UsuarioController();
        public frmUsuarioSelecao()
        {
            InitializeComponent();
            //Comando para evitar da grid gerar os campos automaticamente
            //dgvRegistros.AutoGenerateColumns = false;
        }

        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = usuarioController.GetAll();
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            frmUsuarioCadastro frm = new frmUsuarioCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
                AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
