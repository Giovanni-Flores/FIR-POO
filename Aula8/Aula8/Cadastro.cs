using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Aula8
{
    public class Cadastro
    {
        public void informacoes()
        {
            Boleto boleto = new Boleto(0);
            Pessoa pessoa = new Pessoa(null,null,null);
            Endereco endereco = new Endereco(null, null);

            boleto.Pessoa = pessoa;
            boleto.Pessoa.Endereco = endereco;

            Random numRandom = new Random();
            boleto.setCodigoDocumento(numRandom.Next(1, 100));

            //Beneficiario ou Pagador
            Console.WriteLine("\n***---------------------------------------------------------------------------------***");
            Console.WriteLine($"Escolha sua situção: \nPAGAR (p) \nRECEBER (b)");
            boleto.Pessoa.setSituacao(Console.ReadLine());
            Console.WriteLine(boleto.Pessoa.escolherSituacao());
            if (boleto.Pessoa.escolherSituacao().Equals(boleto.Pessoa.opcao))
            {
                Environment.Exit(1);
            }
            //Nome
            Console.WriteLine("\nDigíte seu nome:");
            pessoa.setNome(Console.ReadLine());
            Console.WriteLine($"\n{boleto.Pessoa.escolherSituacao()} --- {boleto.Pessoa.validarNome()}");
            if (boleto.Pessoa.validarNome().Equals(boleto.Pessoa.opcao))
            {
                Environment.Exit(1);
            }
            //Endereco Rua
            Console.WriteLine("\nInforme seu Endereço:");
            boleto.Pessoa.Endereco.setNomeRua(Console.ReadLine());
            Console.WriteLine($"{boleto.Pessoa.Endereco.validarRua()}");
            if (boleto.Pessoa.Endereco.validarRua().Equals(boleto.Pessoa.Endereco.opcao))
            {
                Environment.Exit(1);
            }
            //Endereco Cidade
            Console.WriteLine("\nInforme sua Cidade:");
            boleto.Pessoa.Endereco.setNomeCidade(Console.ReadLine());
            Console.WriteLine($"{boleto.Pessoa.Endereco.validarCidade()}");
            if (boleto.Pessoa.Endereco.validarCidade().Equals(boleto.Pessoa.Endereco.opcao))
            {
                Environment.Exit(1);
            }
            //Valor Documento
            Console.WriteLine($"\nInforme o valor a ser {boleto.Pessoa.prosseguirSituacao()}");
            boleto.setValorDocumento(Convert.ToInt32(Console.ReadLine()));
            //Destinatario
            Console.WriteLine($"\nInforme o nome do {boleto.Pessoa.destinarPessoa()}:");
            boleto.Pessoa.setDestinatario(Console.ReadLine());
            Console.WriteLine(boleto.Pessoa.validarNomeDestinatario());
            if (pessoa.validarNomeDestinatario().Equals(boleto.Pessoa.opcao))
            {
                Environment.Exit(1);
            }

            //Data
            Console.WriteLine(boleto.ToString());
            var date = DateTime.Now;
            Console.WriteLine($"{date} -----------------------------");

            //Cadastrar novamente  ( s/n ? )
            Console.WriteLine($"\nDeseja realizar outro cadastro? \nSIM (s) \nNÃO (n)");
            continuara = Console.ReadLine();
            switch (continuara)
            {
                case "s":
                    informacoes();
                    break;
                case "n":
                    Environment.Exit(1);
                    break;
            }
        }
        String continuara;
    }
}
