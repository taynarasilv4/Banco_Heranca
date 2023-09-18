using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Heranca.classe
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial{ get ; set; }

        public string Cpf { get; set; }

        public string NomeInstituicao { get; set; }

        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, int numeroConta, string agencia, string titular, double saldo) : base (numeroConta, agencia, titular,  saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public override void Sacar(double valor)
        {
            if (valor <= (Saldo + LimiteChequeEspecial)) 
            {
               base.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficientes para saque.");
            }
        }
    }
}
