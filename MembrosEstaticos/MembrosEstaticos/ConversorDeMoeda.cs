using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6;
        public static double ConverteMoeda(double quantia,double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
       
    }
}
