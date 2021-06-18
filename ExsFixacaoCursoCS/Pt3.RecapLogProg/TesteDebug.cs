using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt3.RecapLogProg
{
    class TesteDebug
    {
        public static void Run()
        {
            //Teste Debugging
            Console.WriteLine("Hello World!");
            int a = 10;
            Teste(a);
            Console.WriteLine(a);

        }

        static void Teste(int a)
        {
            a = 20;
        }
    }
}
