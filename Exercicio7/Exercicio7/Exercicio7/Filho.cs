using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    internal class Filho
    {
        private String nomeFilho1;
        private String nomeFilho2;


        public String getNomeFilho1() 
        {
            return nomeFilho1;
        }
        public String setNomeFilho1()
        {
            return nomeFilho1 = Console.ReadLine();
        }

        public String getNomeFilho2()
        {
            return nomeFilho2;
        }
        public String setNomeFilho2()
        {
            return nomeFilho2 = Console.ReadLine();
        }
    }
}
