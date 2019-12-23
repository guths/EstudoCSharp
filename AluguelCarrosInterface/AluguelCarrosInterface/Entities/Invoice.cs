﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AluguelCarrosInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Base payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                                    + "\nTotal payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
