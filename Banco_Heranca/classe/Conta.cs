using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Heranca.classe
{
    internal class Conta
    {
        public int NumeroConta { get; set; }

        public string Agencia{ get; set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(int numeroConta, string agencia, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Saldo atual: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
            
        }

        public void Depositar(double valor)
        {
            
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso. Saldo atual: R$ {Saldo}");
        }
       
        

       
    }
}
