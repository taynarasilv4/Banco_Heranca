using Banco_Heranca.classe;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            ContaEmpresarial contaEmpresarial = new ContaEmpresarial(123, 5000, 90, 134, "003", "Fulano", 40);
            ContaEstudante contaEstudante = new ContaEstudante(234, "044.099.345-45", "Ifro Campus Jiparana", 004, "134", "Beltrano", 4000);

            Console.WriteLine("Escolha um Tipo de Conta");
            Console.WriteLine("1 - Conta Empresarial");//menu tipo de conta
            Console.WriteLine("2 - Conta Estudante");

            int tipoConta = Convert.ToInt32(Console.ReadLine());


            if (tipoConta == 1)//Conta Empresarial
            {

                Console.WriteLine("Escolha a Operação que deseja Realizar:");
                Console.WriteLine("1 - Fazer emprestimo");
                Console.WriteLine("2 - sacar");

                int operacao = Convert.ToInt32(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Digite o valor do empréstimo: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    contaEmpresarial.FazerEmpestimo(valor);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Digite o valor do saque: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    contaEmpresarial.Sacar(valor);
                }
                
            }
            else if (tipoConta == 2) //Conta Estudante
            {
                Console.WriteLine("Escolha a operação que você deseja realizar:");
                Console.WriteLine("1 - saque");//menu operacoes da conta
          
                int operacao2 = Convert.ToInt32(Console.ReadLine());

                if (operacao2 == 1)
                {
                    Console.WriteLine("Digite o valor do saque: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    contaEstudante.Sacar(valor);
                }
                
            }
        }
        
    }
}
