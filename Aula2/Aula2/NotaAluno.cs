using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class NotaAluno
    {
        public String nomeAluno { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }

        public float media { get; set; }


        public String mostraNomeAluno()
        {
            return nomeAluno;
        }

        public void statusAluno()
        {
            Console.WriteLine("Aprovado");
        }

        public float mediaAluno()
        {
            return media = (nota1 + nota2) / 2;
        }
    }
}
