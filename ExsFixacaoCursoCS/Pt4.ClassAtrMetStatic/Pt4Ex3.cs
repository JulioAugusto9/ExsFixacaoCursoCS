using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pt4Ex3
    {
        public static void Run()
        {
            //Exercicio 3
            Aluno alu = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            alu.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            alu.Notas = new double[]
            {
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine())
            };

            Console.WriteLine(alu.Situacao());
        }
    }
}
