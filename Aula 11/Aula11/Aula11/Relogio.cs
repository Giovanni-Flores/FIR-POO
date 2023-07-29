using System;
using System.Collections.Generic;
using System.Text;

namespace Aula11
{
    class Relogio
    {

        public int segundo;
        public int minuto;
        public int hora;

        public void configuraHorario(int segundo, int minuto, int hora)
        {
            this.segundo = segundo;
            this.minuto = minuto;
            this.hora = hora;
        }

        public void configuraHorario(int segundo, int minuto)
        {
            this.segundo = segundo;
            this.minuto = minuto;
        }
    }
}
