using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExsFixacaoCursoCS.Pt3.RecapLogProg
{
    class Pt3Ex1
    {
        public static void Run()
        {
            //Exercicio 1
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            double preco1 = 2100.0;
            double preco2 = 650.50;

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double medida = 53.234567;

            string msg = ", cujo preço é $ ";
            Console.WriteLine("Produtos:\n" + produto1 + msg + preco1.ToString("F2")
                + "\n" + produto2 + msg + preco2.ToString("F2"));

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondando (três casas decimais): {0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));

            /*
            Produtos:
            Computador, cujo preço é $ 2100,00
            Mesa de escritório, cujo preco é $ 650,50
            Registro: 30 anos de idade, código 5290 e gênero: M
            Medida com oito casas decimais: 53,23456700
            Arredondado (três casas decimais): 53,235
            Separador decimal invariant culture: 53.235
            */
        }
    }
}
