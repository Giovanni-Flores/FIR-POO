using System;
using System.Collections.Generic;
using System.Text;

namespace Aula11
{
    class Calculadora
    {
        //SobreEscrita -> 
        //Sobrecarga de métodos (Override é das filhas que usa do PAI)
        //Assinatura do método: é o nome do método e seus parâmetros  somar(int a){};

        public int soma(int a, int b)
        {
            return a + b;
        }

        public float soma(float a, float b)
        {
            return a + b;
        }

        public double soma(double a, double b)
        {
            return a + b;
        }

        public int soma(int a, int b, int c)
        {
            return a + b + c;
        }

        public float soma(float a, float b, float c)
        {
            return a + b + c;
        }

        public double soma(double a, double b, double c)
        {
            return a + b + c;
        }




    }
}
