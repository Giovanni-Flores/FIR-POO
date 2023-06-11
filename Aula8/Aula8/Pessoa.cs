using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace Aula8
{
    class Pessoa
    {
        public String nome;
        public String destinatario;
        private String situacao;
        private String pagador;
        private String beneficiario;
        public Endereco Endereco;
        public String opcao;

        //Construtor
        public Pessoa(String nome, String pagador, String beneficiario)
        {
            this.nome = nome;
            this.pagador = pagador;
            this.beneficiario = beneficiario;
        }

        //NOME
        public String setNome(String nome)
        {
            return this.nome = nome;
        }

        //PAGADOR
        public String getPagador()
        {
            return pagador;
        }
        //BENEFICIARIO
        public String getBeneficiario()
        {
            return beneficiario;
        }
        //SITUACAO
        public String getSituacao()
        {
            return situacao;
        }
        public String setSituacao(String situacao) {
            return this.situacao = situacao;
        }
        //DESTINATARIO
        public String getDestinatario()
        {
            return destinatario;
        }
        public String setDestinatario(String destinatario)
        {
            return this.destinatario = destinatario;
        }

        //MÉTODOS DE REGRAS

        public String escolherSituacao() 
        {
            switch (situacao)
            {
                case "p":
                    return pagador = "Pagador";
                    break;
                case "b":
                    return beneficiario = "Beneficiario";
                    break;
                default:
                    return opcao = "Opção não existe. Fechando o programa...";
            }
        }

        //VALIDAÇÃO
        public String validarNome()
        {
            return nome.Length <= 2 ? opcao = "Nome é inválido! (min. 3 dígitos). Fechando o programa..." : nome;
        }
        public String validarNomeDestinatario()
        {
            return destinatario.Length <= 2 ? opcao = "Nome é inválido! (min. 3 dígitos). Fechando o programa..." : destinatario;
        }

        //SITUAÇÕES
        public String prosseguirSituacao(){return situacao.Equals("p") ? "PAGO" : "RECEBIDO";}

        public String destinarPessoa() { return situacao.Equals("p") ? "Beneficiário" : "Pagador"; }

        public String destinarValor() { return situacao.Equals("p") ? "RECEBIDO" : "PAGO"; }
        public String situarPessoa()
        {
           return situacao.Equals("p") ? beneficiario = getDestinatario() : pagador = getDestinatario();
        }
    }
}
