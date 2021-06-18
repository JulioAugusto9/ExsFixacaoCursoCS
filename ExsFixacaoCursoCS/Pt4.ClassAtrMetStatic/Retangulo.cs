using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return Altura * 2 + Largura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        private static string Format(double val, string format)
        {
            return val.ToString(format, CultureInfo.InvariantCulture);
        }

        public string Area(string format)
        {
            return "Área = " + Format(this.Area(), format);
        }

        public string Perimetro(string format)
        {
            return "Perímetro = " +  Format(this.Perimetro(), format);
        }

        public string Diagonal(string format)
        {
            return "Diagonal = " +  Format(this.Diagonal(), format);
        }
    }
}
