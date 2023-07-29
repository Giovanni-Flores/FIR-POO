using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Pessoa
    {
        public String nome;
        public String endereco;
        public int telefone;

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public String setEndereco(String endereco)
        {
            return this.endereco = endereco;
        }

        public int setTelefone(int telefone)
        {
            return this.telefone = telefone;
        }
    }
}
