using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Mamifero : Animais
    {
        public String grupo;
        public String revestimento;

        public String setGrupo(String grupo)
        {
            return this.grupo = grupo;
        }

        public String setRevestimento(String revestimento)
        {
            return this.revestimento = revestimento;
        }

        public override string ToString()
        {
            return $"-----------------------------------" +
                $"\nNome: {nome}" +
                $"\nCaracterística: {caracteristica}" +
                $"\nGrupo: {grupo}" +
                $"\nRevestimento: {revestimento}" +
                $"\n-----------------------------------";
        }
    }
}
