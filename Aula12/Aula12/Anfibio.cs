using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;

namespace Aula12
{
    internal class Anfibio : Animais
    {
        public float peso;
        public String habitat;

        public float setPeso(float peso)
        {
            return this.peso = peso;
        }

        public String setHabitat(String habitat)
        {
            return this.habitat = habitat;
        }

        public override string ToString()
        {
            return $"-----------------------------------" +
                $"\nNome: {nome}" +
                $"\nCaracterística: {caracteristica}" +
                $"\nPeso: {peso}" +
                $"\nHabitat: {habitat}" +
                $"\n-----------------------------------";
        }
    }
}
