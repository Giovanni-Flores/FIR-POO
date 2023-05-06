using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    internal class NotaAluno
    {
        public String nomeAluno { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }

        public float media { get; set; }


        public String mostraNomeAluno()
        {
            return nomeAluno;
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
