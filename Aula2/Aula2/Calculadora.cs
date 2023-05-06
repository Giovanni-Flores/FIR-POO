using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Calculadora
    {
        public int valor { get; set; }

        public int somar(int a, int b)
        {
            return valor = a + b;

        }

        public int subtrair(int a, int b)
        {
            return valor = a - b;
        }

        public int ultimoResultado()
        {
            return valor;
        }

    }
}
