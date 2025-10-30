namespace ProjetoMVCExemplo
{
    internal class Tutorial
    {
        //Primeiro para programação em camdas
        //é criar as pastas das camdas
        //Models: armazenar as classes de objetos
        //Views: armazenar as telas do sistema
        //Controllers: armazenar as classes de regras de negócio
        //Teremos uma camada adicional para armazenar
        //a conexão com o banco de dados
        //Services: armazenar a conexão com o banco de dados
        //***************************************************
        //Segundo passo é criar as classe na Models
        //geralmente espelhando as tabelas do banco de dados
        //Dentro da pasta Models
        //OBS: Criar a classe de coleção junto
        //com a classe do objeto
        //Ex: Usuario e UsuarioCollection
        //***************************************************
        //Terceiro passo é criar a classe de conexão
        //com o banco de dados na camada de Serviço
        //Dentro da pasta Services
        //Ex: DataBaseService
        //***************************************************
        //Quarto passo é criar a classe de controle dentro
        //da pasta Controllers
        //Ou seja iremos criar a classe que ira gerenciar
        //o objeto com o banco de dados
        //realizando o CRUD do objeto na conexão com o banco
        //Ex: UsuarioController
        //***************************************************
    }
}
