using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    internal class Mae
    {
        private String nomeMae;
        public Filho Filho;

        public String getNomeMae() 
        {
            return nomeMae;
        }

        public String setNomeMae(String nome) 
        {
            return nomeMae = nome;
        }

    }
}
