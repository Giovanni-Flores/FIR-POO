using System;
using System.Runtime.ConstrainedExecution;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 5 - Class Car

            Console.WriteLine($"--- Class Carro");
            Carro carro = new Carro();

            carro.nome = "BMW 118i";
            carro.potencia = 136;

            Console.WriteLine($"\nModelo do carro: {carro.mostrarNome()} \nPotencia: {carro.mostrarPotencia()}CV.");

            //Exercise 5 - Class Telefone

            Console.WriteLine($"\n--- Class Telefone");
            Telefone telefone = new Telefone();

            telefone.numeroTelefone = "51 9012345678";
            telefone.operadora = "Tim";

            Console.WriteLine($"\nNúmero 1: {telefone.mostrarTelefone()} \nOperadora: {telefone.mostrarOperadora()}");

            Telefone telefone2 = new Telefone();

            telefone2.numeroTelefone = "51 9912345678";
            telefone2.operadora = "Claro";

            Console.WriteLine($"\nNúmero 2: {telefone2.mostrarTelefone()} \nOperadora: {telefone2.mostrarOperadora()}");

            //Exercise 5 - Class Pessoa 

            /*Console.WriteLine($"\n--- Class Pessoa");

            Pessoa pessoa = new Pessoa();

            Console.WriteLine($"\nPessoa 1:");
            Console.WriteLine($"\nEscreva seu nome:");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine($"\nEscreva sua idade:");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nEscreva seu endereço:");
            pessoa.endereco = Console.ReadLine();
            Console.WriteLine($"\nPrimeiro Cadastro \nNome:{pessoa.mostrarNome()} \nIdade:{pessoa.mostrarIdade()} \nEndereço:{pessoa.mostrarEndereco()}");

            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine($"\nPessoa 2:");
            Console.WriteLine($"\nEscreva seu nome:");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine($"\nEscreva sua idade:");
            pessoa2.idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nEscreva seu endereço:");
            pessoa2.endereco = Console.ReadLine();
            Console.WriteLine($"\nSegundo Cadastro \nNome:{pessoa2.mostrarNome()} \nIdade:{pessoa2.mostrarIdade()} \nEndereço:{pessoa2.mostrarEndereco()}");*/

            //Exercise 5 - Class FolhaPagamento

            Console.WriteLine($"\n--- Class FolhaPagamento");

            FolhaPagamento pagamento = new FolhaPagamento();

            pagamento.nome1 = "Mario";
            pagamento.salario1 = 100;
            pagamento.nome2 = "Luigi";
            pagamento.salario2 = 300;

            Console.WriteLine($"\nNome 1: {pagamento.nome1} \nSalário 1: {pagamento.salario1}");
            Console.WriteLine($"\nNome 2: {pagamento.nome2} \nSalário 2: {pagamento.salario2}");
            Console.WriteLine($"\nTotal dos Salários: {pagamento.totalFolhaPagamento()}");

            //Exercise 5 - Class Moto

            Console.WriteLine($"\n--- Class Moto");

            Console.WriteLine("\nMoto 1:");
            Moto moto1 = new Moto();

            moto1.nome = "YS 250 FAZER";
            moto1.marca = "Yamaha";
            moto1.potencia = 137;
            moto1.peso = 21;

            Console.WriteLine($"\nModelo: {moto1.nome} \nMarca: {moto1.marca} \nPotência: {moto1.potencia} \nPeso: {moto1.peso}");

            Console.WriteLine("\nMoto 2:");
            Moto moto2 = new Moto();

            moto2.nome = "PCX 150 DLX";
            moto2.marca = "PCX";
            moto2.potencia = 137;
            moto2.peso = 21;

            Console.WriteLine($"\nModelo: {moto2.nome} \nMarca: {moto2.marca} \nPotência: {moto2.potencia} \nPeso: {moto2.peso}");

            Console.WriteLine($"\n--- End ****************");



        }
    }
}
