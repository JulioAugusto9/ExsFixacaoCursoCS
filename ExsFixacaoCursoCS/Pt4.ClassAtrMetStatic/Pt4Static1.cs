using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pt4Static1
    {
        public static void Run()
        {
            //Exercicio 1 de Metodos Estaticos
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar?");
            double dolares = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(dolares, cotacao).ToString("F2"));

        }
    }
}
