using System;
using System.Collections.Generic;
using System.Text;

namespace Aula12
{
    internal class Eletrodomestico
    {
        public String nome;
        public float preco;
        public String marca;

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public float setPreco(float preco)
        {
            return this.preco = preco;
        }

        public String setMarca(String marca)
        {
            return this.marca = marca;
        }


    }
}
