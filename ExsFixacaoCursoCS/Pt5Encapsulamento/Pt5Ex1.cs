using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt5Encapsulamento
{
    class Pt5Ex1
    {
        public static void Run()
        {
            Console.WriteLine("Entre o número da conta:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta:");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            string yes = Console.ReadLine();
            Conta conta;
            if (yes.Equals("s"))
            {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double depositIni = double.Parse(Console.ReadLine());
                conta = new Conta(num, nome, depositIni);
            }
            else
            {
                conta = new Conta(num, nome);
            }

            Console.WriteLine("Dados da conta:\n" + conta.ToString());

            Console.WriteLine("Entre um valor para depósito:");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:\n" 
                + conta.ToString());

            Console.WriteLine("Entre um valor para saque:");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:\n"
                + conta.ToString());
        }
    }
}
