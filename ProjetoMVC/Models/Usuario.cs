using System.Collections.Generic;

namespace ProjetoMVC.Models
{
    //Classe de objeto Usuario
    //espelhando a tabela Usuario do banco de dados
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    //Criar uma classe com uma coleção de objetos Usuario
    //Teremos uma coleção de usuarios
    //ou seja  tipo da coleção é de Usuario
    //Precisamos herdar da classe List
    public class UsuarioCollection : List<Usuario> { }
}
