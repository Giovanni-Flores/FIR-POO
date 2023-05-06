using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade3
{
    internal class Produto
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

        public String mostraDescricaoProduto()
        {
            return descricao;
        }
    }
}
