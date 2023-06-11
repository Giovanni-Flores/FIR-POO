using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5
{
    class FolhaPagamento
    {
        public String nome1 { get; set; }
        public float salario1 { get; set; }
        public String nome2 { get; set; }
        public float salario2 { get; set; }
        public String negativo { get; set; }

        public string setNaoNegativo()
        {

            if (salario1 < 0)
            {
                return negativo = "Não é permitido números negativos!!";
            }
            else
            {
                return negativo = Convert.ToString(salario1);
            }
        }

        public string setNaoNegativo2()
        {

            if (salario2 < 0)
            {
                return negativo = "Não é permitido números negativos!!";
            }
            else
            {
                return negativo = Convert.ToString(salario2);
            }
        }
        public float totalFolhaPagamento()
        {
            return salario1 + salario2;
        }


    }
}
