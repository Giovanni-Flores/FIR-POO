using System;

namespace Atividade3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Classe Computador

            Console.WriteLine($"\n**** Computador 1");
            Computador computador1 = new Computador();

            computador1.nome = "Pedro";
            computador1.clock = 1200;
            Console.WriteLine($"O nome do computador é: {computador1.mostraNomeComputador()}");
            Console.WriteLine($"O clock é: {computador1.mostraClock()}");

            //2 - Classe Produto
            Produto produto1 = new Produto();

            Console.WriteLine($"\n---- Produto 1");

            produto1.nome = "Arroz";
            produto1.preco = 12;
            produto1.descricao = "2kg";

            Console.WriteLine($"\nO produto é {produto1.mostraNomeProduto()}, custa R${produto1.mostraPreco()} e tem o peso de {produto1.mostraDescricaoProduto()}");

            Console.WriteLine($"\n---- Produto 2");

            Produto produto2 = new Produto();

            produto2.nome = "Feijão";
            produto2.preco = 5;
            produto2.descricao = "1kg";

            Console.WriteLine($"\nO produto é {produto2.mostraNomeProduto()}, custa R${produto2.mostraPreco()} e tem o peso de {produto2.mostraDescricaoProduto()}");

            //3 - Classe Calculadora

            Console.WriteLine($"\n**** Calculo 1 ****");

            Calculadora calculadora = new Calculadora();

            calculadora.a = 10;
            calculadora.b = 20;

            Console.WriteLine($"\nValor de A: {calculadora.a}  Valor de B: {calculadora.b}");
            Console.WriteLine($"\nResultado da subtração: {calculadora.subtrair()}");
            Console.WriteLine($"Resultado da soma: {calculadora.somar()}");
            Console.WriteLine($"\nUltimo resultado: {calculadora.ultimoResultado()}");
            Console.WriteLine($"Ultima operação: {calculadora.ultimaOperacao()}");

            //4 - Classe NotaAluno
            NotaAluno aluno1 = new NotaAluno();

            Console.WriteLine($"\n---- Nota Aluno 1 ---- ");
            aluno1.nomeAluno = "Adalberto";
            aluno1.nota1 = 5;
            aluno1.nota2 = 6;
            Console.WriteLine($"\nNome Aluno: {aluno1.nomeAluno}  Status: {aluno1.statusAluno()} Total da Nota: {aluno1.mediaAluno()}");

            NotaAluno aluno2 = new NotaAluno();

            Console.WriteLine($"\n---- Nota Aluno 2 ---- ");
            aluno2.nomeAluno = "Miguel";
            aluno2.nota1 = 4;
            aluno2.nota2 = 3;
            Console.WriteLine($"\nNome Aluno: {aluno2.nomeAluno}  Status: {aluno2.statusAluno()} Total da Nota: {aluno2.mediaAluno()}");

            NotaAluno aluno3 = new NotaAluno();

            Console.WriteLine($"\n---- Nota Aluno 3 ---- ");
            aluno3.nomeAluno = "Pietro";
            aluno3.nota1 = 9;
            aluno3.nota2 = 8;
            Console.WriteLine($"\nNome Aluno: {aluno3.nomeAluno}  Status: {aluno3.statusAluno()} Total da Nota: {aluno3.mediaAluno()}");


            //5 - Classe NotaFiscal
            NotaFiscal nota1 = new NotaFiscal();

            Console.WriteLine($"\n**** Nota Fiscal 1");
            nota1.nomeItem1 = "SSD 256gb";
            nota1.nomeItem2 = "Memória ram 8gb";
            nota1.precoItem1 = 200;
            nota1.precoItem2 = 150;

            Console.WriteLine($"\nItem 1: R${nota1.mostraPrecoItem1()}  Preço: {nota1.precoItem1}");
            Console.WriteLine($"\nItem 2: R${nota1.mostraPrecoItem2()}  Preço: {nota1.precoItem2}");
            Console.WriteLine($"\nTotal da Compra 1: R${nota1.calculaNotaFiscal()}");

            Console.WriteLine($"\n**** Nota Fiscal 2");

            NotaFiscal nota2 = new NotaFiscal();

            nota2.nomeItem1 = "SSD 128gb";
            nota2.nomeItem2 = "Memória ram 4gb";
            nota2.precoItem1 = 120;
            nota2.precoItem2 = 110;

            Console.WriteLine($"\nItem 1: R${nota2.mostraPrecoItem1()}  Preço: {nota2.precoItem1}");
            Console.WriteLine($"\nItem 2: R${nota2.mostraPrecoItem2()}  Preço: {nota2.precoItem2}");
            Console.WriteLine($"\nTotal da Compra 1: R${nota2.calculaNotaFiscal()}");

            Console.WriteLine($"\n**** Nota Fiscal 3");

            NotaFiscal nota3 = new NotaFiscal();

            nota3.nomeItem1 = "SSD 1TB";
            nota3.nomeItem2 = "Memória ram 16gb";
            nota3.precoItem1 = 450;
            nota3.precoItem2 = 300;

            Console.WriteLine($"\nItem 1: R${nota3.mostraPrecoItem1()}  Preço: {nota3.precoItem2}");
            Console.WriteLine($"\nItem 2: R${nota3.mostraPrecoItem2()}  Preço: {nota3.precoItem2}");
            Console.WriteLine($"\nTotal da Compra 1: R${nota3.calculaNotaFiscal()}");


            Console.WriteLine("End ***************");
        }
    }
}
