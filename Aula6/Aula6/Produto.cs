using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula6
{
    internal class Produto
    {
        public String nome { get; set; }
        public float preco { get; set; }
        public String descricao { get; set; }

        public Produto(String nome, float preco, String descricao)
        {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        public String mostrarNomeProduto()
        {
            return nome;
        }

        public float mostrarPreco()
        {
            return preco;
        }

        public String mostrarDescricaoProduto()
        {
            return descricao;
        }
    }
}
