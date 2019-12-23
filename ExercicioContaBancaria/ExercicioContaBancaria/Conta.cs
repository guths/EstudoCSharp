using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioContaBancaria
{
    public class Conta
    {
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial)
        {
            Deposita(depositoInicial);
        }
        public string Titular { get; set; }

        public int Numero { get; private set; }

        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Saldo -= valor - 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + Saldo.ToString();
        }
    }
}
