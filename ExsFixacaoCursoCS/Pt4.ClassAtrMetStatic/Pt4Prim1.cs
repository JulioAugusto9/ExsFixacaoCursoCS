using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pt4Prim1
    {
        public static void Run()
        {
            //Primeiros Exercicios: Exercicio 1
            Pessoa p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:\n" + p1.ToString());
            Console.WriteLine("Dados da segunda pessoa:\n" + p2.ToString());

            Console.WriteLine("Pessoa mais velha: " + (p1.Idade >= p2.Idade ? p1.Idade : p2.Idade));

            /*
            Dados da primeira pessoa:
            Nome: Maria
            Idade: 17
            Dados da segunda pessoa:
            Nome: Joao
            Idade: 16
            Pessoa mais velha: Maria
            */
        }
    }
}
