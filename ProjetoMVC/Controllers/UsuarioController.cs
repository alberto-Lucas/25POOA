using ProjetoMVC.Models;
using ProjetoMVC.Services;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoMVC.Controllers
{
    //Classe para controlar as ações do usuario
    //Ou seja regras de negocios, para manutenção
    //do objeto no banco de dados

    //Importar as camadas Models e Services
    //using Nome_Projeto.Models;
    //using Nome_Projeto.Services;
    public class UsuarioController
    {
        //Criar a varaivel local para instanciar
        //a classe de conexão com o banco
        DataBaseService dataBase = new DataBaseService();

        //Antes de criar os métodos
        //precisamos importar a biblioteca
        //using System.Data;
        //using System.Data.SqlClient;

        //Método publico para inserir um novo usuario
        //na tabela usuario do banco de dados.
        //Os dados serão inseridos através de um objeto 
        //do tipo Usuario passado via parametro
        //Esses dados foram preenchidos na View
        //na tela de cadastro de usuario
        //O método retorna um valor inteiro
        //pois é retornado a quantidade de linhas afetadas
        //no banco de dados
        //0 - Nada foi inserido
        //1 - Apenas um registro inserido
        public int Inserir(Usuario usuario)
        {
            //Criar o comando SQL para executar
            //a inserção do registro no banco
            //DICA!!!
            //sempre adicionar um espaço vazio
            //ao final da linha de comando
            //Utilizareamos parametros no comando
            //SQL utilizando @ para evitar
            //ataques via SQL Injection
            string query =
                "INSERT INTO Usuario " +
                "(nome, email, senha) " +
                "VALUES " +
                "(@Nome, @Email, @Senha)";

            //Precisamos transformar a nossa query
            //em comando de banco de dados
            SqlCommand command = new SqlCommand(query);
            //Definir os valores dos parametros @
            //é preciso definir parametro por parametro
            //precisamos definir qual parametro
            //recebara qual informação
            command.Parameters.AddWithValue
                ("@Nome", usuario.Nome);
            command.Parameters.AddWithValue
                ("@Email", usuario.Email);
            command.Parameters.AddWithValue
                ("@Senha", usuario.Senha);

            //Agora com os parametros definidos
            //podemos executar o comando
            //e retornar as linhas afetadas
            return dataBase.ExecuteSQL(command);
        }

        //Método pulico para alterar o registro
        public int Alterar(Usuario usuario)
        {
            //Criar o comando SQL para
            //alterar um registro na tabela
            //OBS: Todos os campos serão 
            //ATUALIZADO!!
            string query =
                "UPDATE Usuario SET " +
                "nome = @Nome, " +
                "email = @Email, " +
                "senha = @Senha " +
                "WHERE usuario_id = @UsuarioId";
            //Precisamos utilizar o mesmo processo 
            //que possui no insert
            //Transforma a query em comando
            //atribui valores aos parametros
            //executa o comando

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue
                ("@Nome", usuario.Nome);
            command.Parameters.AddWithValue
                ("@Email", usuario.Email);
            command.Parameters.AddWithValue
                ("@Senha", usuario.Senha);
            command.Parameters.AddWithValue
                ("@UsuarioId", usuario.UsuarioId);

            return dataBase.ExecuteSQL(command);
        }

        //Método publico par excluir um registro
        public int Excluir()
    }
}
