using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO
{
    public class Pessoa
    {
        //Atributos
        //que são caracteristas a qual a classe
        //faz referencia

        //Dividido em 4 partes
        //Nivel de acesso (Public, Private)
        //Tipo de dado (int, string, bool...)
        //Nome do atributo (CPF, DataNascimento...)
        //Manipulação (Get, Set)
        //Get = Leitura
        //Set = Gravação
        
        public string Nome { get; set; }

        //Criar atributo automatico no visual studio
        //digite prop e aperte TAB
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }

        //Adicionar um atributo somente leitura
        //para exibir o CPF e o Nome concatenado
        public string CPFNome
        {
            get
            {
                return CPF + " - " + Nome;
            }
        }
    }
}
