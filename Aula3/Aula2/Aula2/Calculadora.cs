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
        public int a { get; set; }
        public int b { get; set; }
        public String operacao { get; set; }

        public int somar()
        {
            return valor = a + b;

        }

        public int subtrair()
        {
            return valor = a - b;
        }

        public int ultimoResultado()
        {
            return valor;
        }

        public string ultimaOperacao()
        {
            return valor == somar() ? "Soma" : "Subtracao";
        }

    }
}
