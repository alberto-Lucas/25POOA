using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para manipular uma classe
            //é preciso criar um objeto
            //realizando a instancia da classe
            //alocando em memoria (RAM)

            //Para instanciar é dividida
            //em 5 partes
            //Tipo de dado (string, int, Pessoa)
            //Variavel referente ao objeto
            //(gerealmente faz referencia ao nome da classe)
            //o sinal de igual (=) atribuir informações
            //palavra reservador new
            //(responsavel por alocar a classe em memoria)
            //Construtor da Classe a ser instancia 
            //(repete o mesmo nome do tipo de dados)
            //o parenteses () faz referente ao método
            //construtor
            Pessoa pessoa = new Pessoa();

            //Atribuir informações
            pessoa.Nome = "Lucas";
            pessoa.CPF = "64646";
            //Utilizar o DateTime.Now
            //para recuperar a data atual do computador
            pessoa.DtNascimento = DateTime.Now;

            //Nesse momento estou subistituindo a informações
            //anterior
            pessoa.Nome = "João";

            Pessoa pessoa2 = new Pessoa();
            //Irei atribuir os dados da segunda pessoa

            pessoa2.Nome = "Guilherme";
            pessoa2.CPF = "65465454";
            pessoa2.DtNascimento = DateTime.Now;

            //Nesse momento possuo 2 instancia da classe Pessoa
            //sendo um com a informação do
            //João e outra do Guilherme

            //Exibir os dados do atributo Nome
            //das classes Pessoa

            MessageBox.Show(
                "pessoa - Nome: " + pessoa.Nome + Environment.NewLine +
                "pessoa2 - Nome: " + pessoa2.Nome);

            //Agora iremos para parte herença
            //iremos criar a classe aluno que herdara de pessoa


        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            //Iremos instancia e popular o objeto Aluno
            Aluno aluno = new Aluno();

            aluno.Nome = "Maria";
            aluno.CPF = "2213248";
            aluno.DtNascimento = DateTime.Now;
            aluno.RA = "202571817949";
            aluno.Matriculado = true;

            MessageBox.Show(aluno.CPFNome);
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.Nome = "Muriel";
            professor.CPF = "1324894653";
            professor.DtNascimento = DateTime.Now;
            professor.RE = "54656";
            professor.Salario = 50000;

            //Repetir no botão aluno
            MessageBox.Show(professor.CPFNome);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //Para cadastrar um aluno
            //é preciso cadastrar uma disciplina
            //para cadastrar a disciplina
            //é preciso cadastrar um professor

            //Cadastro Professor
            Professor professor = new Professor();
            professor.Nome = "Lucas";
            professor.CPF = "1324789";
            professor.DtNascimento = DateTime.Now;
            professor.RE = "12345";
            professor.Salario = 1;

            //Cadastro da Disciplina
            Disciplina disciplina = new Disciplina();
            disciplina.Nome = "Programação Orientada a Objeto";
            disciplina.Professor = professor;

            //Cadastro do Aluno
            Aluno aluno = new Aluno();
            aluno.Nome = "Arthur";
            aluno.CPF = "321564654";
            aluno.DtNascimento = DateTime.Now;
            aluno.RA = "213464";
            aluno.Matriculado = true;
            aluno.Disciplina = disciplina;

            ExibirDados(aluno);
        }

        //Método para exibir os dados do cadastro
        //no textBox
        void ExibirDados(Aluno aluno)
        {
            txtCadastro.Text =
                "Aluno:" + Environment.NewLine + 
                "RA: " + aluno.RA + Environment.NewLine + 
                "Nome: " + aluno.Nome + Environment.NewLine + 
                "Disciplina:" + Environment.NewLine + 
                "Nome: " + aluno.Disciplina.Nome + Environment.NewLine + 
                "Professor: " + aluno.Disciplina.Professor.Nome;
        }
    }
}
