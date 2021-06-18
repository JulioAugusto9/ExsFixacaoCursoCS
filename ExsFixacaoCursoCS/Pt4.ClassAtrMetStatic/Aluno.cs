using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }
        public double NotaFinal()
        {
            double res = 0;
            foreach (var nota in Notas) res += nota;
            return res;
        }
        public string Situacao()
        {
            double nota = NotaFinal();
            string sit = "NOTA FINAL = " + nota.ToString("F2");
            sit += (
                nota >= 60.0 ?
                "\nAPROVADO" :
                "\nREPROVADO" +
                $"\nFALTARAM {60.0 - nota} pontos"
            );
            return sit;
        }
    }
}
