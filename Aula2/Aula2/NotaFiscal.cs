using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class NotaFiscal
    {

        public String nomeItem1 { get; set; }
        public String nomeItem2 { get; set; }
        public float precoItem1 { get; set; }
        public float precoItem2 { get; set; }

        public float precoTotal { get; set; }

        public float calculaNotaFiscal()
        {
            return precoTotal = precoItem1 + precoItem2;
        }
        public String mostraPrecoItem1()
        {
            return nomeItem1;
        }

        public String mostraPrecoItem2()
        {
            return nomeItem2;
        }
    }
}
