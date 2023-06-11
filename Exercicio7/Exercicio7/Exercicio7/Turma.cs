using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    internal class Turma
    {
        private String nomeTurma;
        public Aluno Aluno;


        public String getNomeTurma()
        {
            return nomeTurma;
        }

        public String setNomeTurma() {
            return nomeTurma = Console.ReadLine();
        }

    }
}
