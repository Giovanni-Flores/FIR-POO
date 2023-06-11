using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 6 - Classe Computador

            Console.WriteLine("\n**** Computador");
            Computador computador = new Computador("Dell Inspiron 15", 10);

            Console.WriteLine($"O nome do computador é: {computador.mostrarNomeComputador()} e seu clock é {computador.mostrarClock()}");

            //Exercise 6 - Classe Produto

            Console.WriteLine("\n**** Produto");
            Produto produto1 = new Produto("Batata Frita", 30, "2");
            Console.WriteLine($"\nProduto 1: {produto1.mostrarNomeProduto()}, custa R${produto1.mostrarPreco()}");

            Produto produto2 = new Produto("Arroz", 12, "5kg");
            Console.WriteLine($"\nProduto 2: {produto2.mostrarNomeProduto()}, custa R${produto2.mostrarPreco()} e tem o peso de {produto2.mostrarDescricaoProduto()}");

            //Exercise 6 - Classe NotaAluno

            Console.WriteLine("\n**** Nota Alunos");

            NotaAluno aluno1 = new NotaAluno("Joaozinho", 7, 10);
            Console.WriteLine($"\nNome Aluno 1: {aluno1.mostrarNomeAluno()} \n1 Nota: {aluno1.mostrarNota1()} \n2 Nota: {aluno1.mostrarNota2()} \nStatus: {aluno1.statusAluno()}");
            
            NotaAluno aluno2 = new NotaAluno("", 0,0);
            aluno2.nomeAluno = "Mariazinha";
            aluno2.nota1 = 3;
            aluno2.nota2 = 5;
            Console.WriteLine($"\nNome Aluno 2: {aluno2.mostrarNomeAluno()} \n1 Nota: {aluno2.mostrarNota1()} \n2 Nota: {aluno2.mostrarNota2()} \nStatus: {aluno2.statusAluno()}");

            Console.WriteLine($"\n--- End ****************");

        }
    }
}
