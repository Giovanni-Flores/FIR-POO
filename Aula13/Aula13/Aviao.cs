using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aula13
{
    internal class Aviao : Motor
    {
        public int velocidade;

        public int setVelocidade(int velocidade)
        {
            return this.velocidade  = velocidade;
        }
        public Aviao(int potencia, String modelo, int velocidade) : base(potencia, modelo)
        {
            this.velocidade = velocidade;
        }

        public override string ToString()
        {
            return $"\nVelocidade: {velocidade} km/h" +
                $"\nPotencia do motor: {potencia}" +
                $"\nModelo: {modelo}" +
                $"\nDesempenho: {relatarDesempenho(desempenho)}";
        }
    }
}
