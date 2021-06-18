using System;
using System.Collections.Generic;
using System.Text;

namespace ExsFixacaoCursoCS.Pt5Encapsulamento
{
    class Conta
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        private double _saldo;
        public static double TaxaSaque { get; private set; } = 5.0;

        public Conta(int numero, string nomeTitular)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
            _saldo = 0;
        }

        public Conta(int numero, string nomeTitular, double depositIni) 
            : this(numero, nomeTitular)
        {
            _saldo = depositIni;
        }

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public void Saque(double valor)
        {
            _saldo -= valor + TaxaSaque;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {NomeTitular}, Saldo: $ {_saldo}";
        }
    }
}
