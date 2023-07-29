using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    internal class Rodoviaria : Cadastro
    {
        public int totalBox;
        private int situacao = 1;

        public Rodoviaria(int codigo, String nome, int totalBox, int situacao) : base(codigo, nome)
        {

            this.codigo = codigo;
            this.nome = nome;
            this.totalBox = totalBox;
            this.situacao = situacao;
        }
        public int setCodigo(int codigo)
        {
            return this.codigo = codigo;
        }

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public int setTotalBox(int box)
        {
            return this.totalBox = box;
        }

        public String getSituacao()
        {
            return situacao == 1 ? "Ativa" : "Desativada";
        }

        public override string ToString()
        {
            return $"\nCódigo: {codigo}" +
                $"\nRodoviária: {nome}" +
                $"\nTotal de Boxes: {totalBox}" +
                $"\nSituação: {getSituacao()}";
        }
    }
}
