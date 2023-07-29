using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculadora calculadora = new Calculadora();

            calculadora.soma(10,20);
            calculadora.soma(12f, 22f);
            calculadora.soma(11d, 21d);
            calculadora.soma(5, 6, 7);
            calculadora.soma(25f, 26f, 27f);
            calculadora.soma(15d, 16d, 17d);

            Relogio relogio = new Relogio();

            relogio.configuraHorario(0,45,12);
            relogio.configuraHorario(10, 30);

            Carro carro = new Carro();

            carro.montaCarro("BMW", "320i", 184);
            carro.montaCarro("BMW", "118i");
            carro.montaCarro("BMW", 625);

        }
    }
}
