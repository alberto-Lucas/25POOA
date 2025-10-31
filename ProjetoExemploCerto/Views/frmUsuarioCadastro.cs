using System;
using System.Windows.Forms;
using ProjetoExemploCerto.Controllers;
using ProjetoExemploCerto.Models;

namespace ProjetoExemploCerto.Views
{
    public partial class frmUsuarioCadastro : Form
    {
        //Importar camadas Models e Controllers
        //using Nome_Porjeto.Models;
        //using Nome_Porjeto.Controllers;

        //Cirar instancia com a controller
        UsuarioController usuarioController = new UsuarioController();
        public frmUsuarioCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja realmente sair?" + Environment.NewLine + Environment.NewLine +
                "Ao Sair os dados alterados serão descartados!",
                "Confirmação!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Primeiro preciamos instanciar o nosso objeto
            Usuario usuario = new Usuario();
            //Iremos mapear as informações com o objeto
            //OBS: nesse momento não iremos mapear
            //o campo ID, pois a nossa tabela é
            //IDENTITY
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            //Agora iremos salvar o cadastro
            //no banco de dados, via controller
            //E validamos o retorno se o cadastro
            //foi inserido com sucesso
            if (usuarioController.Inserir(usuario) > 0)
            {
                MessageBox.Show(
                    "Cadastro realizado com sucesso!",
                    "Informação!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(
                    "Falha ao realizar o cadastro!",
                    "Atenção!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }
    }
}
