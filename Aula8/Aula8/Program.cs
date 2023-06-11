using System;
using System.ComponentModel;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();
            Boleto boleto = new Boleto(0);

            cadastro.informacoes();
        }
    }
}
