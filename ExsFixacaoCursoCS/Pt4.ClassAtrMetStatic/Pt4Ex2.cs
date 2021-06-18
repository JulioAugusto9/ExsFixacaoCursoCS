using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pt4Ex2
    {
        public static void Run()
        {
            //Exercicio 2
            Funcionario fun = new Funcionario();
            fun.Nome = Console.ReadLine();
            fun.SalarioBruto = double.Parse(Console.ReadLine());
            fun.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + fun.ToString());
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            fun.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + fun.ToString());
        }
    }
}


