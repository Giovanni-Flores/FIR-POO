using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula6
{
    internal class Computador
    {
        public String nome { get; set; }
        public int clock { get; set; }

        public Computador(String nome, int clock)
        {
            this.nome = nome;
            this.clock = clock;
        }
        public String mostrarNomeComputador()
        {
            return nome;
        }

        public int mostrarClock()
        {
            return clock;
        }
    }
}
