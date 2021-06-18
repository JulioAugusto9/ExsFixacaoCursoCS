using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double DolarParaReal(double dolares, double cotacao)
        {
            return ComIOF(dolares) * cotacao;
        }

        public static double IOF(double dolares)
        {
            return dolares * Iof;
        }

        public static double ComIOF(double dolares)
        {
            return dolares + IOF(dolares);
        }


    }
}
