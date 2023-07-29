using System;
using System.Collections.Generic;
using System.Text;

namespace Aula9
{
    class Pessoa
    {
        private String nome;
        private String dataNascimento;
        private String descendente;
        private String pai;
        private String mae;
        private String filho;
        public Endereco Endereco;
        public DadosBancarios DadosBanco;
        public Trabalho trabalho;

        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        public String setDataNascimento(String dataNascimento)
        {
            return this.dataNascimento = dataNascimento;
        }

        public String getFilho()
        {
            return filho;
        }

        public String setDescendente(String descendente)
        {
            return this.descendente = descendente;
        }
        public String setFilho(String filho)
        {
            return this.filho = filho;
        }

        public String setMae(String mae)
        {
            return this.mae = mae;
        }

        public String setPai(String pai)
        {
            return this.pai = pai;
        }

        public override string ToString()
        {
            return $"\nNome: {nome}" +
                $"\nData Nascimento: {dataNascimento}" +
                $"\nPrimogênitos: {descendente}" +
                $"\nFilhos: {filho}" +
                $"\nNome Pai: {pai}" +
                $"\nNome Mãe: {mae}" +
                $"\n{Endereco.ToString()}" +
                $"\n{DadosBanco.ToString()}";
        }
    }
}
