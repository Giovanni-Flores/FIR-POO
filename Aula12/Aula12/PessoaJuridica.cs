using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class PessoaJuridica : Pessoa
    {
        private String cnpj;
        private String inscricaoEstadual;

        public String setCnpj(String cnpj) 
        {
            return this.cnpj = cnpj;
        }

        public String setInscricaoEstadual(String inscricao)
        {
            return this.inscricaoEstadual = inscricao;
        }

        public override string ToString()
        {
            return $"\nNome: {nome}" +
                $"\nTelefone: {telefone}" +
                $"\nEndereço: {endereco}" +
                $"\nCNPJ: {cnpj}" +
                $"\nInscrição Estadual: {inscricaoEstadual}";
        }

    }
}
