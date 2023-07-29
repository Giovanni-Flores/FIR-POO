using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    internal class Onibus : Cadastro
    {
        public int responsavel = 297;
        public int poltrona;

        public Onibus(int codigo, String nome, int responsavel, int poltrona) : base(codigo, nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.responsavel = responsavel;
            this.poltrona = poltrona;
        }

        public int setPoltrona(int poltrona)
        {
            return this.poltrona = poltrona;
        }

        public override string ToString()
        {
            return $"\nCódigo: {codigo}" +
                $"\nNome Motorista: {nome}" +
                $"\nPoltronas: {poltrona}";
        }

    }
}
