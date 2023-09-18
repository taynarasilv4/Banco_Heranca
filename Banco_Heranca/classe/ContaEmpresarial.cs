using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Heranca.classe
{
    internal class ContaEmpresarial:Conta
    {
        public double Anuidade { get; set; }

        public double LimiteEmprestimo { get; set; }

        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int numeroConta, string agencia, string titular, double saldo) : base (numeroConta,agencia, titular, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
            NumeroConta = numeroConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }

        public void FazerEmpestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                TotalEmprestimo += valor;
                Saldo += valor;
                Console.WriteLine("Emprestimo Realizado com Sucesso!");
            }
            else 
            {
                Console.WriteLine("Emprestimo Negado. Limite Insuficiente!");
            }

        }
        public override void Sacar(double valor)
        {
            if (valor >= Saldo)
            {
                Saldo -= valor;
                if (valor > 5000)
                {
                    Saldo -= 5; 
                }
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso. Saldo atual: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }
    }
}
