using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5
{
    class Pessoa
    {
        public String nome { get; set; }
        public int idade { get; set; }
        public String endereco { get; set; }

        public string mostrarNome()
        {
            return nome;
        }

        public int mostrarIdade()
        {
            return idade ;
        }

        public string mostrarEndereco()
        {
            return endereco;
        }
    }
}
