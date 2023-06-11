using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8
{
    class Endereco
    {
        public String nomeRua;
        public String nomeCidade;
        public String opcao;

        //CONSTRUTOR
        public Endereco(String nomeRua, String nomeCidade)
        {
            this.nomeRua = nomeRua;
            this.nomeCidade = nomeCidade;
        }

        //RUA
        public String setNomeRua(String nomeRua)
        {
            return this.nomeRua = nomeRua;
        }

        //CIDADE
        public String setNomeCidade(String nomeCidade)
        {
            return this.nomeCidade = nomeCidade;
        }

        //VALIDAÇÕES
        public String validarRua()
        {
            return nomeRua.Length <= 7 ? opcao = "Endereço é inválido! (min. 8 dígitos) Fechando o Programa..." : nomeRua;
        }

        public String validarCidade()
        {
            return nomeCidade.Length <= 7 ? opcao = "Endereço é inválido! (min. 8 dígitos) Fechando o Programa..." : nomeCidade;
        }
    }
}
