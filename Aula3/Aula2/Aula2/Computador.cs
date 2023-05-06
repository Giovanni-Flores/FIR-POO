using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Computador
    {
           public String nome { get; set; }
           public int clock { get; set; }

            public String mostraNomeComputador()
            {
                return nome;
            }

            public int mostraClock()
            {
                return clock;
            }
    }
}
