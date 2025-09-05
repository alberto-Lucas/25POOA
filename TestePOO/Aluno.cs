using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO
{
    //Para realizar a herança
    //utilizamos o sinal de dois ponto (:)
    //e o nome da classe que herdaremos
    //Uma classe pode possuir apenas
    //uma herança
    public class Aluno : Pessoa
    {
        public string RA { get; set; }
        public bool Matriculado { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
