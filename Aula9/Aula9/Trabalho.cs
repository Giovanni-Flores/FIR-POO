using System;
using System.Collections.Generic;
using System.Text;

namespace Aula9
{
    class Trabalho
    {
        private String setor;
        private float salario;
        public Pessoa Pessoa;

        public String setSetor(String setor)
        {
            return this.setor = setor;
        }

        public float setSalario(float salario)
        {
            return this.salario = salario;
        }

        public String verificarSalario()
        {
            if(salario > 0 && salario < 500)
            {
                return "Abaixo da média.";
            } else
            {
                return "Acima da média.";
            }
        }

        public override string ToString()
        {
            return $"\nSetor: {setor}" +
                $"\nSalário: {salario}" +
                $"\nSituação salario: {verificarSalario()}" +
                $"\n{Pessoa.ToString()}" +
                $"\n--------------------------------------------------";
        }
    }
}
