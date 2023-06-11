using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ---------------------");

            /*Aluno aluno = new Aluno();
            //aluno.setAluno2();

            Turma turma = new Turma();
            turma.Aluno = aluno;

            Console.WriteLine($"Digíte o Nome da TURMA: ");
            turma.setNomeTurma();

            Console.WriteLine($"\nNome Turma: {turma.getNomeTurma()}");

            int i = 1;
            do
            {
                Console.WriteLine($"\nDigíte o Nome do ALUNO: ");
                turma.Aluno.setAluno();
                Console.WriteLine($"\nDigíte a NOTA do aluno: ");
                turma.Aluno.setNota();
                Console.WriteLine($"\n- Nome {i}: {turma.Aluno.getAluno()} \n- Nota: {turma.Aluno.getNota()}");

                i++;
            }
            while (i < 3);*/

            //Exercicio 2

            Filho filho = new Filho();
            Mae mae = new Mae();


            mae.Filho = filho;

            Console.WriteLine("Digite o nome da Mãe: ");
            mae.setNomeMae(Console.ReadLine());

            Console.WriteLine($"\nDigite o nome do Filho(a): ");
            Console.WriteLine($"Nome: {mae.Filho.setNomeFilho1()}");
            
            Console.WriteLine($"\nDigite o nome do Filho(a): ");
            Console.WriteLine($"Nome: {mae.Filho.setNomeFilho2()}");

            Console.WriteLine($"\n- Nome da Mãe: {mae.getNomeMae()} " +
                $"\n- Nome Filho: {mae.Filho.getNomeFilho1()}" +
                $"\n- Nome Filho: {mae.Filho.getNomeFilho2()}");
        }
    }
}
