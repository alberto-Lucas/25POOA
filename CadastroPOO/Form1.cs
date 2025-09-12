using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPOO
{
    public partial class Form1 : Form
    {
        //Primeiro é preciso instanciar a classe
        //UsuarioExecucacao
        UsuarioExecucao usuarioExecucao = 
            new UsuarioExecucao();
        public Form1()
        {
            InitializeComponent();
        }

        //Método para atualizar a List Box
        void AtualizarLisBox()
        {
            //Limpar a listBox
            //DataSource = Fonte de Dados (Ex: listaUsuario)
            lstUsuarios.DataSource = null;
            //Chamar o método ListarTodos da usuarioExecucao
            //e atribuir o resultado a listBox
            lstUsuarios.DataSource = 
                usuarioExecucao.ListarTodos();

            //Definir qual campo de Usuario será
            //exibido na listaBox
            //DisplayMember o dados a ser exibido na list
            //é precisso colocar o nome correto 
            //do atributo desejado
            lstUsuarios.DisplayMember = "NomeEmail";
        }

        //Método para extrair o objeto Usuario
        //selecionada da ListBox
        Usuario ExtrairUsuario()
        {
            //Recuperar o registro selecionado
            //e transformalo no objeto Usuario
            //usar o as para converter o item em objeto
            return lstUsuarios.SelectedItem as Usuario;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Vamos popular o objeto com os dados informados

            //Neste caso para ser mais objeto, iremos 
            //pular a parte de validação (Ex: campo vazio)

            //Foco é a manipulação do objeto e da lista

            //Criar uma instancia do objeto Usuario
            //Existe em memória durante a execução do
            //botão adicionar
            //Após terminar, a instancia é liberada da memória
            Usuario usuario = new Usuario();

            //Atribuir as informações ao objeto
            usuario.CPF = txtCPF.Text;
            usuario.Nome = txtNome.Text;
            usuario.DtNascimento = dtpDtNascimento.Value;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            //Agora podemos adicionar o nosso objeto 
            //a lista de objetos usando o método adicionar
            //da classe usuarioExecucacao
            usuarioExecucao.Adicionar(usuario);

            //Atualizar a listBox para exibir o novo cadastro
            AtualizarLisBox();

            //Limpeza dos campos
            txtCPF.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDtNascimento.Value = DateTime.Now;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Iremos chamar o método ExtrairUsuario
            //para recuperar o usuario selecionado
            //e passar este usuario via parametro
            //para o método remover
            usuarioExecucao.Remover(ExtrairUsuario());

            //Atualizar a listBox
            AtualizarLisBox();
        }

        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            //Chamar o método ExtrairUsuario
            //para recuperar o usuario selecionado

            Usuario usuarioSelecionado =
                ExtrairUsuario();

            //Exibir os dados na parte de Visualização
            txtVisCPF.Text = usuarioSelecionado.CPF;
            txtVisNome.Text = usuarioSelecionado.Nome;
            txtVisEmail.Text = usuarioSelecionado.Email;
            txtVisSenha.Text = usuarioSelecionado.Senha;
            txtVisDtNascimento.Text =
                usuarioSelecionado.DtNascimento.ToShortDateString();

            //Exemplo para exibir a data de nascimento
            //em um DateTimePicker
            //dtpDtNascimento.Value =
            //  usuarioSelecionado.DtNascimento;

            txtVisIdade.Text = usuarioSelecionado.Idade.ToString();

        }
    }
}
