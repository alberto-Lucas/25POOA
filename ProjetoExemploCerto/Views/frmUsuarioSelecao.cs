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

        //Método para realizar a pesquisa no banco de dados
        void AtualizarGrid()
        {
            dgvRegistros.DataSource = null;
            //Aqui podemos chamar a consulta para retornar todos
            //dgvRegistros.DataSource = usuarioController.GetAll();
            //Aqui podemos chamar a consulta com filtro por nome
            //Passando o campo vazio, será retornado todos os registro
            dgvRegistros.DataSource = usuarioController.GetByName(txtNome.Text);
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
