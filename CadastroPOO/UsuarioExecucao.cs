using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    //Classe para manipular o objeto Usuario
    public class UsuarioExecucao
    {
        //Criar uma lista para armazenar
        //um conjunto de objetos(Usuarios)

        //Tornar a lista privada para somente
        //classe UsuarioExecucação ter acesso
        private List<Usuario> listaUsuario =
            new List<Usuario>();

        //Método para adicionar um usuário a lista
        public void Adicionar(Usuario usuario)
        {
            listaUsuario.Add(usuario);
        }

        //Método para remover um usuário da lista
        public void Remover(Usuario usuario)
        {
            listaUsuario.Remove(usuario);
        }

        //Método que retorna todos os usuários
        //ou seja retorna a propria Lista
        public List<Usuario> ListarTodos()
        {
            return listaUsuario;
        }
    }
}
