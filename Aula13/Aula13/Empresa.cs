using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    internal class Empresa : Cadastro
    {

        private String cnpj;
        Onibus onibus;
        public int codigo = 1;

        public Empresa(int codigo, String nome, String cnpj) : base(codigo, nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cnpj = cnpj;
        }

        public String setCnpj(String cnpj) 
        {
            return this.cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"\nCódigo: {codigo}" +
                $"\nEmpresa: {nome}" +
                $"\nCNPJ: {cnpj}";
        }
    }
}