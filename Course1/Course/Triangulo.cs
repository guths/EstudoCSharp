using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double CalculaArea() //Não entra parametros pois os mesmo se encontram dentro da propria classe 
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
