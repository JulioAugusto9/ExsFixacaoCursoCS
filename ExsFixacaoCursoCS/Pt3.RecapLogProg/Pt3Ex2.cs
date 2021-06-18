using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExsFixacaoCursoCS.Pt3.RecapLogProg
{
    class Pt3Ex2
    {
        public static void Run()
        {
            //Exercicio 2
            Console.WriteLine("Entre com seu nome completo:");
            //Alex Green
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            //3
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            //500.50
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura(mesma linha):");
            //Green 21 1.73
            string[] entradas  = Console.ReadLine().Split(' ');
            string lastName = entradas[0];
            int idade = int.Parse(entradas[1]);
            double altura = double.Parse(entradas[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}\n" +
                $"{quartos}\n" +
                $"{preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"{lastName}\n" +
                $"{idade}\n" +
                $"{altura.ToString("F2", CultureInfo.InvariantCulture)}\n");
        }
    }
}
