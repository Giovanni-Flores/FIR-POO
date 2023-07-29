using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Animais
    {
        public String nome;
        public String caracteristica;

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public String setCaracteristica(String caracteristica)
        {
            return this.caracteristica = caracteristica;
        }
    }
}
