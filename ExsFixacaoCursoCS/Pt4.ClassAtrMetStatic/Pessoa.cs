using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt4.ClassAtrMetStatic
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade;
        }
    }
}
