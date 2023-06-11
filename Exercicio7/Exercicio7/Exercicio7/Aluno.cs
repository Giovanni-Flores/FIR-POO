using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7
{
    class Aluno
    {
        public String aluno;
        private int nota;

        public String getAluno() {
            return aluno;
        }

        public String setAluno()
        {
            return aluno = Console.ReadLine();
        }

        public int getNota()
        {
            return nota;
        }

        public int setNota()
        {
            return nota = Int32.Parse(Console.ReadLine());
        }


    }
}
