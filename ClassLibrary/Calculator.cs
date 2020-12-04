using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Calculator
    {
        public static double CalculateRetail(double wholesale, double markup)
        {
            double retail = wholesale * (markup / 100) + wholesale;
            return retail;
        }
    }
}
