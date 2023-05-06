using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Produto
    {
        public String nome { get; set; }
        public float preco { get; set; }
        public String descricao { get; set; }

        public String mostraNomeProduto()
        {
            return nome;
        }

        public float mostraPreco()
        {
            return preco;
        }

        public void mostraDescricaoProduto()
        {
            Console.WriteLine(descricao);
        }

    }
}
