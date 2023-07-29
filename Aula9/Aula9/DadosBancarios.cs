using System;
using System.Collections.Generic;
using System.Text;

namespace Aula9
{
    class DadosBancarios
    {

        private String tipoConta;
        private String numeroConta;


        public String setTipoConta(String tipoConta)
        {
            return this.tipoConta = tipoConta;
        }

        public String setNumeroConta(String numeroConta)
        {
            return this.numeroConta = numeroConta;
        }

        public override string ToString()
        {
            return $"\nConta: {tipoConta}" +
                $"\nNúmero: {numeroConta}";
        }
    }
}
