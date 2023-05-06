using System;


namespace Aula1
{
    class Atividade1
    {
        static void Main(string[] args)
        {

            //Question 1 ---------------------------------------------------------------------
            //string nome = "Giovanni FLores";
            //string endereco = "Rua Vitalino Batista de Andrades";

            //Console.WriteLine("Nome:" + nome);
            //Console.WriteLine("Endereço: " + endereco + "");

            //Question 2 ---------------------------------------------------------------------
            //Console.WriteLine("\nEscreva o seu nome: ");
            //String name = Console.ReadLine();

            //Console.WriteLine("\nEscreva sua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //Question 3 ---------------------------------------------------------------------
            //Console.WriteLine("\nPara calcular a área do QUADRADO digíte: ");
            //Console.WriteLine("\nLado A: ");
            //int ladoA = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nLado B: ");
            //int ladoB = int.Parse(Console.ReadLine());

            //int soma = ladoA * ladoB;
            //Console.WriteLine("\nResultado: " + soma);

            ////Question 4 ---------------------------------------------------------------------
            //Console.WriteLine("\nDigite um número: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nDigite outro número: ");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1 + " é MAIOR que " + num2);
            //}
            //else
            //{
            //    Console.WriteLine($"{num1} é MENOR que {num2}");
            //}

            //Question 5 ---------------------------------------------------------------------
            //float nota1 = 4;
            //float nota2 = 8;
            //float nota3 = 9;
            //float media = (nota1 + nota2 + nota3) / 3;

            //if (media >= 7.0)
            //{
            //    Console.WriteLine("Aprovado");
            //}
            //else if (media >= 5.0 && media < 7.0)
            //{
            //    Console.WriteLine("Recuperação");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado");
            //}

            // Question 6 ---------------------------------------------------------------------
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}


            //Question 7 ---------------------------------------------------------------------

            Random numRandom = new Random();

            int aleatorio = numRandom.Next(1, 100);

            int confere = aleatorio % 2;

            Console.WriteLine($"O número é: {aleatorio}");

            if (confere == 0)
            {
                Console.WriteLine("Par");
            } else
            {
                Console.WriteLine("Ímpar");
            }
            
        }
    }
}
