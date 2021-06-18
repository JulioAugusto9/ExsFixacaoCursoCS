using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pt4Ex1
    {
        public static void Run()
        {
            //Exercicio 1
            Console.WriteLine("Entre a largura e altura do retângulo:");
            Retangulo ret = new Retangulo();
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(ret.Area("F2"));
            Console.WriteLine(ret.Perimetro("F2"));
            Console.WriteLine(ret.Diagonal("F2"));
        }
    }
}
