using System;

namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto 0

            Trabalho trabalho = new Trabalho();
            Pessoa pessoa = new Pessoa();
            Endereco endereco = new Endereco();
            DadosBancarios conta = new DadosBancarios();

            pessoa.Endereco = endereco;
            pessoa.DadosBanco = conta;
            trabalho.Pessoa = pessoa;
            
            pessoa.setNome("Robison Fernandes");
            pessoa.setDataNascimento("30/04/1990");
            pessoa.setDescendente("1 filho");
            pessoa.setFilho("Joaquim");
            pessoa.setMae("Rosana Santos");
            pessoa.setPai("Fabio Silva");

            pessoa.DadosBanco.setTipoConta("Corrente");
            pessoa.DadosBanco.setNumeroConta("1234 0-13 12345678-9");

            pessoa.Endereco.setRua("Av.São João");
            pessoa.Endereco.setCidade("São Leopoldo");
            pessoa.Endereco.setPais("Brasil");

            trabalho.setSetor("Logística");
            trabalho.setSalario(800);

            Console.WriteLine(trabalho.ToString());

            //Objeto 1

            Trabalho trabalho1 = new Trabalho();
            Pessoa pessoa1 = new Pessoa();
            Endereco endereco1 = new Endereco();
            DadosBancarios conta1 = new DadosBancarios();

            pessoa1.Endereco = endereco1;
            pessoa1.DadosBanco = conta1;
            trabalho1.Pessoa = pessoa1;

            Console.WriteLine("Digíte seu nome:");
            pessoa1.setNome(Console.ReadLine());
            Console.WriteLine("Digíte sua data de nascimento:");
            pessoa1.setDataNascimento(Console.ReadLine());
            Console.WriteLine("Você possui quantos filhos?");
            pessoa1.setDescendente(Console.ReadLine());
            Console.WriteLine("Digíte o nome do seu filho:");
            pessoa1.setFilho(Console.ReadLine());
            Console.WriteLine("Digíte o nome da sua MÃE:");
            pessoa1.setMae(Console.ReadLine());
            Console.WriteLine("Digíte o nome do seu PAI:");
            pessoa1.setPai(Console.ReadLine());

            Console.WriteLine("Qual sua conta? (Corrente/Salário)");
            pessoa1.DadosBanco.setTipoConta(Console.ReadLine());
            Console.WriteLine("Digíte o número da Conta:");
            pessoa1.DadosBanco.setNumeroConta(Console.ReadLine());

            Console.WriteLine("Digíte o seu endereço:");
            pessoa1.Endereco.setRua(Console.ReadLine());
            Console.WriteLine("Digíte a sua cidade:");
            pessoa1.Endereco.setCidade(Console.ReadLine());
            Console.WriteLine("Digíte o seu país:");
            pessoa1.Endereco.setPais(Console.ReadLine());

            Console.WriteLine("Digíte o seu setor:");
            trabalho1.setSetor(Console.ReadLine());
            Console.WriteLine("Digíte o seu salário:");
            trabalho1.setSalario(Int32.Parse(Console.ReadLine()));

            Console.WriteLine(trabalho1.ToString());
        }
          
    }
}
