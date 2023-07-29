using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    internal class Motor
    {

        public int potencia;
        public String modelo;
        public String desempenho;

        public int setPotencia(int potencia)
        {
            return this.potencia = potencia;
        }
        public String setModelo(String modelo)
        {
            return this.modelo = modelo;
        }
        public Motor(int potencia, string modelo)
        {
            this.potencia = potencia;
            this.modelo = modelo;
        }   

        public String relatarDesempenho(String desempenho)
        {
            return this.desempenho = desempenho;
        }



    }
}
