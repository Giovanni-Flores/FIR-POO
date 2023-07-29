using System;
using System.Collections.Generic;
using System.Text;

namespace Aula11
{
    class Carro
    {

        public String nome;
        public String marca;
        public int potencia;

        public void montaCarro(String nome, String marca, int potencia)
        {
            this.nome = nome;
            this.marca = marca;
            this.potencia = potencia;
        }
        public void montaCarro(String nome, String marca)
        {
            this.nome = nome;
            this.marca = marca;
        }
        public void montaCarro(String nome, int potencia)
        {
            this.nome = nome;
            this.potencia = potencia;
        }
    }
}
