using System.Data;
using System.Data.SqlClient;

namespace ProjetoMVC.Services
{
    //Classe de conexão com o banco de dados
    //Importar as bibliotecas de banco de dados
    //using System.Data;
    //using System.Data.SqlClient;
    public class DataBaseService
    {
        //Método de conexão com o banco de dados
        //Será privado pois só será usado apenas
        //dentro da propria classe
        private SqlConnection GetConnection()
        {
            //Variavel para armazenar a conexão
            SqlConnection connection = new SqlConnection();

            //Definir a string de conexão 
            //inserir os dados de conexão com o banco de dados
            //Usando
            //Servidor: HOST/IP
            //Catalogo: Nome do banco de dados
            //Autenticação: Usuário e Senha ou Windows

            //OBS: o nome do servidor possui barra invertida \
            //porém no C# a barra invertida é um
            //caractere especial gerando erro
            //para isso precisamos usar duas barra \\
            //o C# entende que é uma barra \ apenas
            connection.ConnectionString =
                "Data Source=LUCAS-NOTE\\SQLEXPRESS;" +
                "Initial Catalog=ProjetoMVC;" +
                "Integrated Security=SSPI;"; //Autenticação do Windows
                //Exemplo de autenticação com usuário e senha
                //"User ID=sa;
                //Password=123456;";

            //Abrir a conexão
            connection.Open();

            //Retornamos a conexão aberta
            return connection;
        }

        //Método para executar comandos 
        //de manipulação de dados
        //Insert, Update, Delete
        //Retornando a quantidade de linhas afetadas
        public int ExecuteSQL(SqlCommand command)
        {
            //Abrir a conexão com o banco
            command.Connection = GetConnection();
            //Executar o comando no banco
            //E retornar as linhas afetadas
            //Retornos:
            //0 - O comando não foi executado
            //1 - Apenas um registrado afetado
            //N - Mais de um registro afetado
            //N é quantidade de numero e nao a letra
            return command.ExecuteNonQuery();
        }

        //Método de consulta para retornar
        //uma tabela de informações (DataTable)
        public DataTable GetDataTable(SqlCommand command)
        {
            //Abrir a conexão com o banco
            command.Connection = GetConnection();

            //Montar a execução da consulta
            //Semelhante ao comando
            //command.ExecuteNonQuery();
            SqlDataAdapter sqlData = 
                new SqlDataAdapter(command);

            //Precisamos converter a informação de
            //banco de dados em DataTable
            //Variavel para o DataTable
            DataTable dataTable = new DataTable();

            //Preencher o dataTable com o retorno do banco
            sqlData.Fill(dataTable);

            //Retorna os dados
            return dataTable;
        }
    }
}
