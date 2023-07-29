using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class PessoaFisica : Pessoa
    {
        public String cpf;
        public String rg;

        public String setCpf(String cpf)
        {
            return this.cpf = cpf;
        }

        public String setRg(String rg)
        {
            return this.rg = rg;
        }

        public override string ToString()
        {
            return $"Nome: {nome}" +
                $"\nTelefone {telefone}" +
                $"\nCPF: {cpf}" +
                $"\nRG: {rg}";
        }
    }
}
