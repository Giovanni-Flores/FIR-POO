using System;

namespace Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Atividade 4");

            Pessoa pessoa = new Pessoa();
            PessoaJuridica pj = new PessoaJuridica();
            PessoaFisica pf = new PessoaFisica();

            Console.WriteLine("Pessoa Jurídica ------");
            Console.WriteLine("Digite seu nome:");
            pj.setNome(Console.ReadLine());
            Console.WriteLine("Digite seu Endereco:");
            pj.setEndereco(Console.ReadLine());
            Console.WriteLine("Digite seu telefone:");
            pj.setTelefone(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Digite seu CNPJ:");
            pj.setCnpj(Console.ReadLine());
            Console.WriteLine("Digite sua Inscrição Estadual:");
            pj.setInscricaoEstadual(Console.ReadLine());

            Console.WriteLine("Pessoa Física ------");
            Console.WriteLine("Digite seu nome:");
            pf.setNome(Console.ReadLine());
            Console.WriteLine("Digite seu Telefone:");
            pf.setTelefone(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Digite seu CPF:");
            pf.setCpf(Console.ReadLine());
            Console.WriteLine("Digite seu RG:");
            pf.setRg(Console.ReadLine());



            Console.WriteLine(pj.ToString());
            Console.WriteLine("-------------------");
            Console.WriteLine(pf.ToString());*/

            //******************************************************************************
            /*Console.WriteLine("Atividade 5");

            Mamifero mamifero = new Mamifero();
            Anfibio anfibio = new Anfibio();
            Aves aves = new Aves();

            Console.WriteLine("Mamíferos ------");
            Console.WriteLine("Ficha Cadastral:");
            Console.WriteLine("\nNome do Animal:");
            mamifero.setNome(Console.ReadLine());
            Console.WriteLine("\nCaracterística:");
            mamifero.setCaracteristica(Console.ReadLine());
            Console.WriteLine("\nGrupo:");
            mamifero.setGrupo(Console.ReadLine());
            Console.WriteLine("\nRevestimento:");
            mamifero.setRevestimento(Console.ReadLine());

            Console.WriteLine(mamifero.ToString());

            Console.WriteLine("\nAnfíbios ------");
            Console.WriteLine("Ficha Cadastral:");
            Console.WriteLine("\nNome do Animal:");
            anfibio.setNome(Console.ReadLine());
            Console.WriteLine("\nCaracterística:");
            anfibio.setCaracteristica(Console.ReadLine());
            Console.WriteLine("\nPeso:");
            anfibio.setPeso(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("\nHabitat:");
            anfibio.setHabitat(Console.ReadLine());

            Console.WriteLine(anfibio.ToString());

            Console.WriteLine("\nAves ------");
            Console.WriteLine("Ficha Cadastral:");
            Console.WriteLine("\nNome do Animal:");
            aves.setNome(Console.ReadLine());
            Console.WriteLine("\nAlimetação:");
            aves.setAlimentacao(Console.ReadLine());
            Console.WriteLine("\nRegião:");
            aves.setRegiao(Console.ReadLine());

            Console.WriteLine(aves.ToString());*/


            Console.WriteLine("Atividade 6");

            Tv tv = new Tv();
            Radio radio = new Radio();
            Videogame game = new Videogame();
         

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Televisão:");
            Console.WriteLine("Digíte a marca:");
            tv.setMarca(Console.ReadLine());
            Console.WriteLine("Digíte o preço:");
            tv.setPreco(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Digíte quantas polegadas possuí:");
            tv.setPolegada(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Escolha uma opção: (em números)" +
                "\n1 - LCD" +
                "\n2 - Plasma");
            tv.setTipo(Int32.Parse(Console.ReadLine()));

            Console.WriteLine(tv.ToString());

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Rádio:");
            Console.WriteLine("Digíte o nome criadora:");
            radio.setNome(Console.ReadLine());
            Console.WriteLine("Digíte o preço");
            radio.setPreco(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Digíte a Potencia em RMS:");
            radio.setPotencia(Int32.Parse(Console.ReadLine()));

            Console.WriteLine(radio.ToString());

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("VídeoGame:");
            Console.WriteLine("Digíte a marca:");
            game.setMarca(Console.ReadLine());
            Console.WriteLine("Digíte o preço:");
            game.setPreco(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Digíte a quantidade de controles entre 1 e 4:");
            game.setControle(Int32.Parse(Console.ReadLine()));

            Console.WriteLine(game.ToString());









        }
    }
}
