using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Radio : Eletrodomestico
    {
        public int potencia;

        public int setPotencia(int potencia)
        {
            return this.potencia = potencia;
        }

        public override string ToString()
        {
            return $"\nEmpresa: {nome}" +
                $"\nPreço: {preco}" +
                $"\nPotencia RMS: {potencia}";
        }
    }
}
