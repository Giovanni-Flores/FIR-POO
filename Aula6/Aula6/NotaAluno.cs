using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    internal class NotaAluno
    {
        public String nomeAluno { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float media { get; set; }

        //public NotaAluno() { }
        public NotaAluno(String nomeAluno, float nota1, float nota2)
        {
            this.nomeAluno = nomeAluno;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public String mostrarNomeAluno()
        {
            return nomeAluno;
        }

        public float mostrarNota1()
        {
            return nota1;
        }
        public float mostrarNota2()
        {
            return nota2;
        }

        public float mediaAluno()
        {
            return media = (nota1 + nota2) / 2;
        }

        public string statusAluno()
        {
            if (mediaAluno() > 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

    }
}
