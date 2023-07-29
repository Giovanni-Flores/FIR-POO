using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;

namespace Aula12
{
    internal class Aves : Animais
    {
        public String alimentacao;
        public String regiao;

        public String setAlimentacao(String alimentacao)
        {
            return this.alimentacao = alimentacao;
        }

        public String setRegiao(String regiao)
        {
            return this.regiao = regiao;
        }

        public override string ToString()
        {
            return $"-----------------------------------" +
                $"\nNome: {nome}" +
                $"\nAlimentação: {alimentacao}" +
                $"\nRegião: {regiao}" +
                $"\n-----------------------------------";
        }
    }
}
