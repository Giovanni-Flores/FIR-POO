using System;

namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 5 ************
            Aviao aviao = new Aviao(0, "", 0);

            Console.WriteLine("\nDigíte a potência do motor do avião:");
            aviao.setPotencia(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("\nDigíte o modelo do Avião:");
            Console.WriteLine(aviao.setModelo(Console.ReadLine()));

            Console.WriteLine("\nDigíte a velocidade máxima do Avião:");
            aviao.setVelocidade(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("\nDescreva o desempenho dos testes:");
            aviao.relatarDesempenho(Console.ReadLine());

            Console.WriteLine($"\nFICHA TÉCNICA (AVIÃO):" +
                $"\n{aviao.ToString()}");

            //Exercício 2 ************
            /*
            //Empresa
            Cadastro cadastro = new Cadastro(0, null);
            Empresa empresa = new Empresa(297, null, null);
            Rodoviaria rodoviaria = new Rodoviaria(180,null,0, 1);
            Onibus onibus = new Onibus(1764, null, 297, 0);

            Console.WriteLine("\n----- // -----------------------");
            Console.WriteLine("Dígite o nome da empresa:");
            empresa.setNome(Console.ReadLine());
            Console.WriteLine("Dígite o cnpj da empresa:");
            empresa.setCnpj(Console.ReadLine());

            //Rodoviaria
            Console.WriteLine("\nDígite a cidade da Rodoviária:");
            rodoviaria.setNome(Console.ReadLine());
            Console.WriteLine("\nDígite o total de boxes disponíveis:");
            rodoviaria.setTotalBox(Int32.Parse(Console.ReadLine()));
            

            //Onibus
            Console.WriteLine("\nDígite o nome do motorista:");
            onibus.setNome(Console.ReadLine());
            Console.WriteLine("Dígite o número de poltronas:");
            onibus.setPoltrona(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("\n----- // -------------- // -------");
            Console.WriteLine("\nEMPRESA*");
            Console.WriteLine($"{empresa.ToString()}" +
                $"\n{cadastro.relacao(onibus.responsavel, empresa.codigo, $"Ônibus ativo: {onibus.codigo}")}");
            Console.WriteLine("\nRODOVIÁRIA*");
            Console.WriteLine(rodoviaria.ToString());
            Console.WriteLine("\nÔNIBUS*");
            Console.WriteLine($"{onibus.ToString()} " +
                $"\n{cadastro.relacao(onibus.responsavel, empresa.codigo, $"Empresa responsável: {empresa.nome}")}");
            Console.WriteLine("\n----- // -------------- // -------");

            */

        }
    }
}
