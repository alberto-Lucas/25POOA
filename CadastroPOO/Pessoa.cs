using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPOO
{
    public class Pessoa
    {
        //Criar os atributos(propriedades)
        //digitar prop e apertar TAB

        //Serão leitura e gravação(Get e Set)
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }

        //Propriedades somente leitura
        public string CPFNome
        {
            get 
            {
                return CPF + " - " + Nome.ToUpper();
                //Ex: 12345678901 - LUCAS
                //ToUpper() força o retorno do texto em 
                //caixa alta (maiusculo)
            }
        }

        //Propriedade que retorna a idedade
        //calculada com base na DtNascimento
        public int Idade
        {
            get
            {
                //Para descobrir a idade
                //realizamos a conta
                //data atual - data nascimento
                //Iremos usar o comando Now
                //para recuperar a data
                //atual do computador
                //Porém iremos calcular com base no dia
                //para maior precisão

                DateTime dataAtual = DateTime.Now;
                //Agora iremos calcular a idade bruta
                int idade = dataAtual.Year - DtNascimento.Year;

                //Olhar com na data
                //Se mes maior que o que o mes de nascimento
                //mantemos a idade
                //Se menor remove 1 da idade
                //Se igual validamos o dia
                //Se dia menor remove 1 da idade
                //Se igual ou superior mantemos a idade
                if (dataAtual.Month < DtNascimento.Month || //Remove 1
                    (dataAtual.Month == DtNascimento.Month && //Se igual valido o dia
                    dataAtual.Day < DtNascimento.Day))
                {
                    idade--; //Remove 1 da idade
                }

                //Por ultimo retorno a idade
                return idade;
            }
        }
    }
}
