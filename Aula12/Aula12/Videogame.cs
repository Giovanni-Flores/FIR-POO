using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Videogame : Eletrodomestico
    {
        public int controle;

        public int setControle(int controle)
        {
            return this.controle = controle;
        }

        public String quantidadeControle()
        {
            switch (controle)
            {
                case 1:
                    return "1 controle";
                    break;
                case 2:
                    return "2 controles";
                    break;

                case 3:
                    return "3 controles";
                    break;

                case 4:
                    return "4 controles";
                    break;
                default:
                    return "Sem controles";
            }
        }

        public override string ToString()
        {
            return $"\nMarca: {marca}" +
                $"\nPreço: {preco}" +
                $"\nQuantidade de Controles: {quantidadeControle()}";
        }
    }
}
