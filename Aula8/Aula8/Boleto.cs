using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Aula8
{
    class Boleto
    {
        public Pessoa Pessoa;
        private float valorDocumento;
        private int codigoDocumento;

        //CONSTRUTOR
        public Boleto(float valorDocumento)
        {
            this.valorDocumento = valorDocumento;
        }

        //CODIGO DOCUMENTO
        public int setCodigoDocumento(int codigoDocumento)
        {
           return this.codigoDocumento = codigoDocumento;
        }
        //VALOR DOCUMENTO
        public float setValorDocumento(float valorDocumento)
        {
            return this.valorDocumento = valorDocumento;
        }

        //VALIDAÇÃO
        public String validarValor()
        {
            return valorDocumento < 0.10 ? "Valor de transferência abaixo do permitido!" : $"{valorDocumento}";
       
        }

        public override bool Equals(object obj)
        {
            return obj is Boleto boleto &&
            codigoDocumento == boleto.codigoDocumento;
        }

        public override string ToString()
        {
            return $"-------------------------------------------------" +
                $"\nBOLETO 001-{codigoDocumento}" +
                $"\n{Pessoa.escolherSituacao()} ***" +
                $"\nNome:           {Pessoa.validarNome()}" +
                $"\nEndereço:       {Pessoa.Endereco.validarRua()} - {Pessoa.Endereco.validarCidade()}" +
                $"\nTOTAL A SER {Pessoa.prosseguirSituacao()}:  {validarValor()}" +
                $"\n\n{Pessoa.destinarPessoa()} ***" +
                $"\nNome:   {Pessoa.situarPessoa()}" +
                $"\nTOTAL A SER {Pessoa.prosseguirSituacao()}:   {valorDocumento}";
        }
    }
}
