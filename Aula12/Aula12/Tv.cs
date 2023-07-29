using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Tv : Eletrodomestico
    {
        private int polegada;
        private int tipo;

        public int setPolegada(int polegada)
        {
            return this.polegada = polegada;
        }

        public int setTipo(int tipo)
        {
            return this.tipo = tipo;
        }

        public String tipoTv()
        {
            switch (tipo) 
            {
                case 1:
                    return "LCD";
                    break;
                case 2:
                    return "Plasma";
                default:
                    return "Escolha de novo...";
            }
        }

        public override string ToString()
        {
            return $"\nMarca: {marca}" +
                $"\nPreço: {preco}" +
                $"\nPolegada: {polegada}" +
                $"\nModelo: {tipoTv()}";
        }
    }
}
