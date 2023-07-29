using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    internal class Cadastro
    {
        public int codigo;
        public String nome;

        public Cadastro(int codigo, String nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public int setCodigo(int codigo)
        {
            return this.codigo = codigo;
        }

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public String relacao(int a, int b, String c)
        {
            if(a == b)
            {
                return $"{c}";
            }
            else
            {
                return "O sistema não encontrou o cadastro. Tente novamente...";
            }
        }
    }
}
